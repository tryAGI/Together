
#nullable enable

namespace Together
{
    public partial class ChatClient
    {
        partial void PrepareChatCompletionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Together.ChatCompletionRequest request);
        partial void PrepareChatCompletionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.ChatCompletionRequest request);
        partial void ProcessChatCompletionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatCompletionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create chat completion<br/>
        /// Query a chat model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.ChatCompletionResponse> ChatCompletionsAsync(
            global::Together.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareChatCompletionsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
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
            PrepareChatCompletionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatCompletionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // BadRequest
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::Together.ErrorData? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Together.ErrorData.FromJson(__content_400, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::Together.ErrorData.FromJsonStreamAsync(__contentStream_400, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Together.ApiException<global::Together.ErrorData>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::Together.ErrorData? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Together.ErrorData.FromJson(__content_401, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::Together.ErrorData.FromJsonStreamAsync(__contentStream_401, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Together.ApiException<global::Together.ErrorData>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // NotFound
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::Together.ErrorData? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::Together.ErrorData.FromJson(__content_404, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::Together.ErrorData.FromJsonStreamAsync(__contentStream_404, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Together.ApiException<global::Together.ErrorData>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // RateLimit
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::Together.ErrorData? __value_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = global::Together.ErrorData.FromJson(__content_429, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = await global::Together.ErrorData.FromJsonStreamAsync(__contentStream_429, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Together.ApiException<global::Together.ErrorData>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Overloaded
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::Together.ErrorData? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::Together.ErrorData.FromJson(__content_503, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::Together.ErrorData.FromJsonStreamAsync(__contentStream_503, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Together.ApiException<global::Together.ErrorData>(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Timeout
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::Together.ErrorData? __value_504 = null;
                if (ReadResponseAsString)
                {
                    __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = global::Together.ErrorData.FromJson(__content_504, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_504 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = await global::Together.ErrorData.FromJsonStreamAsync(__contentStream_504, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Together.ApiException<global::Together.ErrorData>(
                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessChatCompletionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
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

                return
                    global::Together.ChatCompletionResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Together.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::Together.ChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create chat completion<br/>
        /// Query a chat model.
        /// </summary>
        /// <param name="contextLengthExceededBehavior">
        /// Defined the behavior of the API when max_tokens exceed the maximum context length of the model. When set to 'error', API will return 400 with appropriate error message. When set to 'truncate', override the max_tokens with maximum context length of the model.<br/>
        /// Default Value: error
        /// </param>
        /// <param name="echo">
        /// If true, the response will contain the prompt. Can be used with `logprobs` to return prompt logprobs.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
        /// </param>
        /// <param name="functionCall"></param>
        /// <param name="logitBias">
        /// Adjusts the likelihood of specific tokens appearing in the generated output.
        /// </param>
        /// <param name="logprobs">
        /// Determines the number of most likely tokens to return at each token position log probabilities to return.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="minP">
        /// A number between 0 and 1 that can be used as an alternative to top_p and top-k.
        /// </param>
        /// <param name="model">
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#chat-models)<br/>
        /// Example: meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo
        /// </param>
        /// <param name="n">
        /// The number of completions to generate for each prompt.
        /// </param>
        /// <param name="presencePenalty">
        /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
        /// </param>
        /// <param name="repetitionPenalty">
        /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.
        /// </param>
        /// <param name="safetyModel">
        /// The name of the moderation model used to validate tokens. Choose from the available moderation models found [here](https://docs.together.ai/docs/inference-models#moderation-models).<br/>
        /// Example: safety_model_name
        /// </param>
        /// <param name="seed">
        /// Seed value for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="stop">
        /// A list of string sequences that will truncate (stop) inference text output. For example, "&lt;/s&gt;" will stop generation as soon as the model generates the given token.
        /// </param>
        /// <param name="stream">
        /// If true, stream tokens as Server-Sent Events as the model generates them instead of waiting for the full model response. The stream terminates with `data: [DONE]`. If false, return a single JSON object containing the results.
        /// </param>
        /// <param name="temperature">
        /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) function is called by the model. By default uses `auto`, which lets the model pick between generating a message or calling a function.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for.
        /// </param>
        /// <param name="topK">
        /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
        /// </param>
        /// <param name="topP">
        /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.ChatCompletionResponse> ChatCompletionsAsync(
            global::System.Collections.Generic.IList<global::Together.ChatCompletionRequestMessage> messages,
            global::Together.AnyOf<global::Together.ChatCompletionRequestModel?, string> model,
            global::Together.ChatCompletionRequestContextLengthExceededBehavior? contextLengthExceededBehavior = default,
            bool? echo = default,
            float? frequencyPenalty = default,
            global::Together.OneOf<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>? functionCall = default,
            global::System.Collections.Generic.Dictionary<string, float>? logitBias = default,
            int? logprobs = default,
            int? maxTokens = default,
            float? minP = default,
            int? n = default,
            float? presencePenalty = default,
            double? repetitionPenalty = default,
            global::Together.ChatCompletionRequestResponseFormat? responseFormat = default,
            string? safetyModel = default,
            int? seed = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            bool? stream = default,
            float? temperature = default,
            global::Together.OneOf<string, global::Together.ToolChoice2>? toolChoice = default,
            global::System.Collections.Generic.IList<global::Together.ToolsPart>? tools = default,
            int? topK = default,
            float? topP = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.ChatCompletionRequest
            {
                ContextLengthExceededBehavior = contextLengthExceededBehavior,
                Echo = echo,
                FrequencyPenalty = frequencyPenalty,
                FunctionCall = functionCall,
                LogitBias = logitBias,
                Logprobs = logprobs,
                MaxTokens = maxTokens,
                Messages = messages,
                MinP = minP,
                Model = model,
                N = n,
                PresencePenalty = presencePenalty,
                RepetitionPenalty = repetitionPenalty,
                ResponseFormat = responseFormat,
                SafetyModel = safetyModel,
                Seed = seed,
                Stop = stop,
                Stream = stream,
                Temperature = temperature,
                ToolChoice = toolChoice,
                Tools = tools,
                TopK = topK,
                TopP = topP,
            };

            return await ChatCompletionsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}