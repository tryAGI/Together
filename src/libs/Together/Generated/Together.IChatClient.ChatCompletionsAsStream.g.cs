#nullable enable

namespace Together
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create chat completion<br/>
        /// Generate a model response for a given chat conversation. Supports single queries and multi-turn conversations with system, user, and assistant messages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Together.ChatCompletionStream> ChatCompletionsAsStreamAsync(

            global::Together.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create chat completion<br/>
        /// Generate a model response for a given chat conversation. Supports single queries and multi-turn conversations with system, user, and assistant messages.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#chat-models)<br/>
        /// Example: Qwen/Qwen3.5-9B
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Together.ChatCompletionStream> ChatCompletionsAsStreamAsync(
            global::System.Collections.Generic.IList<global::Together.ChatCompletionMessageParam> messages,
            global::Together.AnyOf<global::Together.ChatCompletionRequestModel?, string> model,
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}