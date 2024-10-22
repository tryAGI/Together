
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.ChatCompletionResponse> ChatCompletionsAsync(
            global::Together.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareChatCompletionsArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/chat/completions",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareChatCompletionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessChatCompletionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChatCompletionsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Together.ChatCompletionResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create chat completion<br/>
        /// Query a chat model.
        /// </summary>
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
        /// The name of the model to query.  Popular models:<br/>
        ///   - meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo<br/>
        ///   - meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo<br/>
        ///   - meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo<br/>
        ///   - Qwen/Qwen2.5-7B-Instruct-Turbo<br/>
        ///   - Qwen/Qwen2.5-72B-Instruct-Turbo<br/>
        ///   <br/>
        /// [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models)<br/>
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
            string model,
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
            var request = new global::Together.ChatCompletionRequest
            {
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
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}