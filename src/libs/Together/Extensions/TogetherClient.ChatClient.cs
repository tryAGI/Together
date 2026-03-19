using System.Runtime.CompilerServices;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Together;

public partial class TogetherClient : Meai.IChatClient
{
    private Meai.ChatClientMetadata? _chatMetadata;

    object? Meai.IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.ChatClientMetadata) ? (_chatMetadata ??= new(nameof(TogetherClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateChatRequest(messages, options);
        request.Stream = false;

        var response = await Chat.ChatCompletionsAsync(request, cancellationToken).ConfigureAwait(false);

        return CreateChatResponse(response, options?.ModelId);
    }

    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateChatRequest(messages, options);
        request.Stream = true;

        await foreach (var streamItem in Chat.ChatCompletionsAsStreamAsync(request, cancellationToken).ConfigureAwait(false))
        {
            if (!streamItem.IsEvent || streamItem.Event?.Data is not { } chunk)
            {
                continue;
            }

            foreach (var choice in chunk.Choices)
            {
                var update = new Meai.ChatResponseUpdate
                {
                    ResponseId = chunk.Id,
                    ModelId = chunk.Model,
                    Role = Meai.ChatRole.Assistant,
                    FinishReason = ToFinishReason(choice.FinishReason),
                    RawRepresentation = chunk,
                };

                if (!string.IsNullOrEmpty(choice.Delta.Content))
                {
                    update.Contents.Add(new Meai.TextContent(choice.Delta.Content)
                    {
                        RawRepresentation = choice.Delta,
                    });
                }

                if (!string.IsNullOrEmpty(choice.Delta.Reasoning))
                {
                    update.Contents.Add(new Meai.TextReasoningContent(choice.Delta.Reasoning)
                    {
                        RawRepresentation = choice.Delta,
                    });
                }

                if (choice.Delta.ToolCalls is { Count: > 0 } toolCalls)
                {
                    foreach (var toolCall in toolCalls)
                    {
                        update.Contents.Add(new Meai.FunctionCallContent(
                            callId: toolCall.Id,
                            name: toolCall.Function.Name,
                            arguments: ParseArguments(toolCall.Function.Arguments))
                        {
                            RawRepresentation = toolCall,
                        });
                    }
                }

                yield return update;
            }

            if (chunk.Usage is { } usage)
            {
                yield return new Meai.ChatResponseUpdate
                {
                    ResponseId = chunk.Id,
                    ModelId = chunk.Model,
                    Role = Meai.ChatRole.Assistant,
                    Contents = [new Meai.UsageContent(CreateUsageDetails(usage.Value1 ?? new UsageData
                    {
                        PromptTokens = 0,
                        CompletionTokens = 0,
                        TotalTokens = 0,
                    }))
                    {
                        RawRepresentation = usage,
                    }],
                };
            }
        }
    }

    private static ChatCompletionRequest CreateChatRequest(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options)
    {
        var requestMessages = new List<ChatCompletionMessageParam>();

        if (!string.IsNullOrWhiteSpace(options?.Instructions))
        {
            requestMessages.Add(new ChatCompletionSystemMessageParam
            {
                Content = options!.Instructions!,
            });
        }

        foreach (var message in messages)
        {
            requestMessages.Add(ToTogetherMessage(message));
        }

        var request = options?.RawRepresentationFactory?.Invoke(null!) as ChatCompletionRequest;
        if (request is null)
        {
            request = new ChatCompletionRequest
            {
                Model = options?.ModelId ?? "meta-llama/Llama-3-8b-chat-hf",
                Messages = requestMessages,
            };
        }
        else
        {
            request.Model ??= options?.ModelId ?? "meta-llama/Llama-3-8b-chat-hf";
            request.Messages ??= [];
            foreach (var message in requestMessages)
            {
                request.Messages.Add(message);
            }
        }

        ApplyChatOptions(request, options);
        return request;
    }

    private static ChatCompletionMessageParam ToTogetherMessage(Meai.ChatMessage message)
    {
        if (message.Role == Meai.ChatRole.System)
        {
            return new ChatCompletionSystemMessageParam
            {
                Content = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text)),
            };
        }

        if (message.Role == Meai.ChatRole.Tool)
        {
            var functionResult = message.Contents.OfType<Meai.FunctionResultContent>().FirstOrDefault();
            return new ChatCompletionToolMessageParam
            {
                ToolCallId = functionResult?.CallId ?? string.Empty,
                Content = ToResultString(functionResult),
            };
        }

        if (message.Role == Meai.ChatRole.Assistant)
        {
            var toolCalls = message.Contents.OfType<Meai.FunctionCallContent>().ToList();
            var text = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text));

            var assistantMessage = new ChatCompletionAssistantMessageParam
            {
                Content = string.IsNullOrEmpty(text) ? null : text,
            };

            if (toolCalls.Count > 0)
            {
                assistantMessage.ToolCalls = toolCalls.Select(tc => new ToolChoice2
                {
                    Index = 0,
                    Id = tc.CallId ?? string.Empty,
                    Type = ToolChoiceType.Function,
                    Function = new ToolChoiceFunction
                    {
                        Name = tc.Name,
                        Arguments = tc.Arguments is { } args
                            ? JsonSerializer.Serialize(args)
                            : "{}",
                    },
                }).ToList();
            }

            return assistantMessage;
        }

        // User message
        return new ChatCompletionUserMessageParam
        {
            Content = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text)),
        };
    }

    private static void ApplyChatOptions(ChatCompletionRequest request, Meai.ChatOptions? options)
    {
        if (options is null)
        {
            return;
        }

        request.Temperature ??= options.Temperature;
        request.TopP ??= options.TopP;
        request.TopK ??= options.TopK;
        request.MaxTokens ??= options.MaxOutputTokens;
        request.Seed ??= options.Seed is { } seed ? (int)seed : null;

        if (request.Stop is null && options.StopSequences is { Count: > 0 })
        {
            request.Stop = options.StopSequences.ToList();
        }

        if (request.ResponseFormat is null && options.ResponseFormat is Meai.ChatResponseFormatJson)
        {
            request.ResponseFormat = new ResponseFormatJsonObject
            {
                Type = ResponseFormatJsonObjectType.JsonObject,
            };
        }

        ApplyTools(request, options);
    }

    private static void ApplyTools(ChatCompletionRequest request, Meai.ChatOptions options)
    {
        if (options.ToolMode is Meai.NoneChatToolMode)
        {
            request.ToolChoice = new OneOf<string, ToolChoice2>("none");
            return;
        }

        if (options.Tools is { Count: > 0 } aiTools)
        {
            request.Tools ??= [];
            foreach (var tool in aiTools)
            {
                if (tool is not Meai.AIFunction function)
                {
                    throw new NotSupportedException(
                        $"Tool type '{tool.GetType().Name}' is not supported by Together. Only function tools are supported.");
                }

                request.Tools.Add(new ToolsPart
                {
                    Type = "function",
                    Function = new ToolsPartFunction
                    {
                        Name = function.Name,
                        Description = function.Description,
                        Parameters = function.JsonSchema.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined
                            ? new object()
                            : function.JsonSchema,
                    },
                });
            }
        }

        if (options.ToolMode is Meai.RequiredChatToolMode)
        {
            request.ToolChoice = new OneOf<string, ToolChoice2>("required");
        }
    }

    private static Meai.ChatResponse CreateChatResponse(ChatCompletionResponse response, string? requestedModelId)
    {
        var firstChoice = response.Choices.FirstOrDefault();
        var responseMessage = new Meai.ChatMessage
        {
            Role = Meai.ChatRole.Assistant,
            RawRepresentation = response,
        };

        if (firstChoice?.Message is { } message)
        {
            AddAssistantContents(responseMessage.Contents, message);
        }

        return new Meai.ChatResponse(responseMessage)
        {
            ResponseId = response.Id,
            ModelId = requestedModelId ?? response.Model,
            FinishReason = firstChoice is not null ? ToFinishReason(firstChoice.FinishReason) : null,
            Usage = response.Usage is { } usage ? CreateUsageDetails(usage) : null,
            RawRepresentation = response,
        };
    }

    private static void AddAssistantContents(IList<Meai.AIContent> contents, ChatCompletionMessage message)
    {
        if (!string.IsNullOrEmpty(message.Content))
        {
            contents.Add(new Meai.TextContent(message.Content)
            {
                RawRepresentation = message,
            });
        }

        if (!string.IsNullOrEmpty(message.Reasoning))
        {
            contents.Add(new Meai.TextReasoningContent(message.Reasoning)
            {
                RawRepresentation = message,
            });
        }

        if (message.ToolCalls is { Count: > 0 } toolCalls)
        {
            foreach (var toolCall in toolCalls)
            {
                contents.Add(new Meai.FunctionCallContent(
                    callId: toolCall.Id,
                    name: toolCall.Function.Name,
                    arguments: ParseArguments(toolCall.Function.Arguments))
                {
                    RawRepresentation = toolCall,
                });
            }
        }
    }

    private static Dictionary<string, object?>? ParseArguments(string? argumentsJson)
    {
        if (string.IsNullOrWhiteSpace(argumentsJson) || argumentsJson is "{}")
        {
            return null;
        }

        try
        {
            var element = JsonSerializer.Deserialize<JsonElement>(argumentsJson);
            if (element.ValueKind == JsonValueKind.Object)
            {
                var dict = new Dictionary<string, object?>(StringComparer.Ordinal);
                foreach (var property in element.EnumerateObject())
                {
                    dict[property.Name] = property.Value;
                }

                return dict;
            }
        }
        catch (JsonException)
        {
            return null;
        }

        return null;
    }

    private static string ToResultString(Meai.FunctionResultContent? functionResult)
    {
        if (functionResult is null)
        {
            return string.Empty;
        }

        if (functionResult.Result is JsonElement jsonElement)
        {
            return jsonElement.ValueKind == JsonValueKind.String
                ? jsonElement.GetString() ?? string.Empty
                : jsonElement.GetRawText();
        }

        if (functionResult.Result is string text)
        {
            return text;
        }

        if (functionResult.Result is not null)
        {
            return JsonSerializer.Serialize(functionResult.Result);
        }

        return functionResult.Exception?.Message ?? string.Empty;
    }

    private static Meai.ChatFinishReason? ToFinishReason(FinishReason? finishReason) =>
        finishReason switch
        {
            FinishReason.Stop => Meai.ChatFinishReason.Stop,
            FinishReason.Eos => Meai.ChatFinishReason.Stop,
            FinishReason.Length => Meai.ChatFinishReason.Length,
            FinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
            FinishReason.FunctionCall => Meai.ChatFinishReason.ToolCalls,
            _ => null,
        };

    private static Meai.UsageDetails CreateUsageDetails(UsageData usage) =>
        new()
        {
            InputTokenCount = usage.PromptTokens,
            OutputTokenCount = usage.CompletionTokens,
            TotalTokenCount = usage.TotalTokens,
        };
}
