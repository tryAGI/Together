
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Together
{
    public partial class ChatClient
    {
        partial void PrepareChatCompletionsAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Together.ChatCompletionRequest request);
        partial void PrepareChatCompletionsAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.ChatCompletionRequest request);
        partial void ProcessChatCompletionsAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create chat completion<br/>
        /// Generate a model response for a given chat conversation. Supports single queries and multi-turn conversations with system, user, and assistant messages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.chat.completions.create(<br/>
        ///     model="Qwen/Qwen3.5-9B",<br/>
        ///     messages=[<br/>
        ///         {"role": "system", "content": "You are a helpful assistant."},<br/>
        ///         {"role": "user", "content": "What are some fun things to do in New York?"},<br/>
        ///     ],<br/>
        ///     reasoning={"enabled": False}<br/>
        /// )
        /// </remarks>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Together.ChatCompletionStream> ChatCompletionsAsStreamAsync(

            global::Together.ChatCompletionRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));


            request = new global::Together.ChatCompletionRequest
            {
                Messages = request.Messages,
                Model = request.Model,
                MaxTokens = request.MaxTokens,
                Stop = request.Stop,
                Temperature = request.Temperature,
                TopP = request.TopP,
                TopK = request.TopK,
                ContextLengthExceededBehavior = request.ContextLengthExceededBehavior,
                RepetitionPenalty = request.RepetitionPenalty,
                Stream = true,
                Logprobs = request.Logprobs,
                Echo = request.Echo,
                N = request.N,
                MinP = request.MinP,
                PresencePenalty = request.PresencePenalty,
                FrequencyPenalty = request.FrequencyPenalty,
                LogitBias = request.LogitBias,
                Seed = request.Seed,
                FunctionCall = request.FunctionCall,
                ResponseFormat = request.ResponseFormat,
                Tools = request.Tools,
                ToolChoice = request.ToolChoice,
                Compliance = request.Compliance,
                ChatTemplateKwargs = request.ChatTemplateKwargs,
                SafetyModel = request.SafetyModel,
                ReasoningEffort = request.ReasoningEffort,
                Reasoning = request.Reasoning,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatCompletionsAsStreamArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatCompletionsAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatCompletionsAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                string? __content = null;
                try
                {
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }
                catch (global::System.Exception)
                {
                }

                throw new global::Together.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::Together.ChatCompletionStream.FromJson(__content, JsonSerializerContext) ??
                                       throw new global::Together.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Create chat completion<br/>
        /// Generate a model response for a given chat conversation. Supports single queries and multi-turn conversations with system, user, and assistant messages.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#chat-models)
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="stop">
        /// A list of string sequences that will truncate (stop) inference text output. For example, "&lt;/s&gt;" will stop generation as soon as the model generates the given token.
        /// </param>
        /// <param name="temperature">
        /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
        /// </param>
        /// <param name="topP">
        /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
        /// </param>
        /// <param name="topK">
        /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
        /// </param>
        /// <param name="contextLengthExceededBehavior">
        /// Defined the behavior of the API when max_tokens exceed the maximum context length of the model. When set to 'error', API will return 400 with appropriate error message. When set to 'truncate', override the max_tokens with maximum context length of the model.<br/>
        /// Default Value: error
        /// </param>
        /// <param name="repetitionPenalty">
        /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
        /// </param>
        /// <param name="logprobs">
        /// An integer between 0 and 20 of the top k tokens to return log probabilities for at each generation step, instead of just the sampled token. Log probabilities help assess model confidence in token predictions.
        /// </param>
        /// <param name="echo">
        /// If true, the response will contain the prompt. Can be used with `logprobs` to return prompt logprobs.
        /// </param>
        /// <param name="n">
        /// The number of completions to generate for each prompt.
        /// </param>
        /// <param name="minP">
        /// A number between 0 and 1 that can be used as an alternative to top_p and top-k.
        /// </param>
        /// <param name="presencePenalty">
        /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
        /// </param>
        /// <param name="logitBias">
        /// Adjusts the likelihood of specific tokens appearing in the generated output.<br/>
        /// Example: {"1024":-10.5,"105":21.4}
        /// </param>
        /// <param name="seed">
        /// Seed value for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="functionCall"></param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](https://docs.together.ai/docs/json-mode).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) function is called by the model. By default uses `auto`, which lets the model pick between generating a message or calling a function.
        /// </param>
        /// <param name="compliance"></param>
        /// <param name="chatTemplateKwargs">
        /// Additional configuration to pass to model engine.
        /// </param>
        /// <param name="safetyModel">
        /// The name of the moderation model used to validate tokens. Choose from the available moderation models found [here](https://docs.together.ai/docs/inference-models#moderation-models).<br/>
        /// Example: safety_model_name
        /// </param>
        /// <param name="reasoningEffort">
        /// Controls the level of reasoning effort the model should apply when generating responses. Higher values may result in more thoughtful and detailed responses but may take longer to generate.<br/>
        /// Example: medium
        /// </param>
        /// <param name="reasoning">
        /// For models that support toggling reasoning functionality, this object can be used to control that functionality.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Together.ChatCompletionStream> ChatCompletionsAsStreamAsync(
            global::System.Collections.Generic.IList<global::Together.ChatCompletionMessageParam> messages,
            string model,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            float? temperature = default,
            float? topP = default,
            int? topK = default,
            global::Together.ChatCompletionRequestContextLengthExceededBehavior? contextLengthExceededBehavior = default,
            double? repetitionPenalty = default,
            int? logprobs = default,
            bool? echo = default,
            int? n = default,
            float? minP = default,
            float? presencePenalty = default,
            float? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, float>? logitBias = default,
            int? seed = default,
            global::Together.OneOf<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>? functionCall = default,
            global::Together.ResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::Together.ToolsPart>? tools = default,
            global::Together.OneOf<string, global::Together.ToolChoice2>? toolChoice = default,
            string? compliance = default,
            object? chatTemplateKwargs = default,
            string? safetyModel = default,
            global::Together.ChatCompletionRequestReasoningEffort? reasoningEffort = default,
            global::Together.ChatCompletionRequestReasoning? reasoning = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.ChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                MaxTokens = maxTokens,
                Stop = stop,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                ContextLengthExceededBehavior = contextLengthExceededBehavior,
                RepetitionPenalty = repetitionPenalty,
                Stream = true,
                Logprobs = logprobs,
                Echo = echo,
                N = n,
                MinP = minP,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Seed = seed,
                FunctionCall = functionCall,
                ResponseFormat = responseFormat,
                Tools = tools,
                ToolChoice = toolChoice,
                Compliance = compliance,
                ChatTemplateKwargs = chatTemplateKwargs,
                SafetyModel = safetyModel,
                ReasoningEffort = reasoningEffort,
                Reasoning = reasoning,
            };

            var __enumerable = ChatCompletionsAsStreamAsync(
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}