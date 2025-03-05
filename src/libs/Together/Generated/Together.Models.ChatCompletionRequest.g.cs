
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// Defined the behavior of the API when max_tokens exceed the maximum context length of the model. When set to 'error', API will return 400 with appropriate error message. When set to 'truncate', override the max_tokens with maximum context length of the model.<br/>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length_exceeded_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionRequestContextLengthExceededBehaviorJsonConverter))]
        public global::Together.ChatCompletionRequestContextLengthExceededBehavior? ContextLengthExceededBehavior { get; set; }

        /// <summary>
        /// If true, the response will contain the prompt. Can be used with `logprobs` to return prompt logprobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo")]
        public bool? Echo { get; set; }

        /// <summary>
        /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>))]
        public global::Together.OneOf<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>? FunctionCall { get; set; }

        /// <summary>
        /// Adjusts the likelihood of specific tokens appearing in the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, float>? LogitBias { get; set; }

        /// <summary>
        /// Integer (0 or 1) that controls whether log probabilities of generated tokens are returned. Log probabilities help assess model confidence in token predictions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public int? Logprobs { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.ChatCompletionRequestMessage> Messages { get; set; }

        /// <summary>
        /// A number between 0 and 1 that can be used as an alternative to top_p and top-k.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_p")]
        public float? MinP { get; set; }

        /// <summary>
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#chat-models)<br/>
        /// Example: meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo
        /// </summary>
        /// <example>meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.ChatCompletionRequestModel?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.ChatCompletionRequestModel?, string> Model { get; set; }

        /// <summary>
        /// The number of completions to generate for each prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Together.ChatCompletionRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The name of the moderation model used to validate tokens. Choose from the available moderation models found [here](https://docs.together.ai/docs/inference-models#moderation-models).<br/>
        /// Example: safety_model_name
        /// </summary>
        /// <example>safety_model_name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_model")]
        public string? SafetyModel { get; set; }

        /// <summary>
        /// Seed value for reproducibility.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A list of string sequences that will truncate (stop) inference text output. For example, "&lt;/s&gt;" will stop generation as soon as the model generates the given token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// If true, stream tokens as Server-Sent Events as the model generates them instead of waiting for the full model response. The stream terminates with `data: [DONE]`. If false, return a single JSON object containing the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Controls which (if any) function is called by the model. By default uses `auto`, which lets the model pick between generating a message or calling a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.ToolChoice2>))]
        public global::Together.OneOf<string, global::Together.ToolChoice2>? ToolChoice { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Together.ToolsPart>? Tools { get; set; }

        /// <summary>
        /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
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
        /// Integer (0 or 1) that controls whether log probabilities of generated tokens are returned. Log probabilities help assess model confidence in token predictions.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            global::System.Collections.Generic.IList<global::Together.ChatCompletionRequestMessage> messages,
            global::Together.AnyOf<global::Together.ChatCompletionRequestModel?, string> model,
            global::Together.ChatCompletionRequestContextLengthExceededBehavior? contextLengthExceededBehavior,
            bool? echo,
            float? frequencyPenalty,
            global::Together.OneOf<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>? functionCall,
            global::System.Collections.Generic.Dictionary<string, float>? logitBias,
            int? logprobs,
            int? maxTokens,
            float? minP,
            int? n,
            float? presencePenalty,
            double? repetitionPenalty,
            global::Together.ChatCompletionRequestResponseFormat? responseFormat,
            string? safetyModel,
            int? seed,
            global::System.Collections.Generic.IList<string>? stop,
            bool? stream,
            float? temperature,
            global::Together.OneOf<string, global::Together.ToolChoice2>? toolChoice,
            global::System.Collections.Generic.IList<global::Together.ToolsPart>? tools,
            int? topK,
            float? topP)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.ContextLengthExceededBehavior = contextLengthExceededBehavior;
            this.Echo = echo;
            this.FrequencyPenalty = frequencyPenalty;
            this.FunctionCall = functionCall;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.MaxTokens = maxTokens;
            this.MinP = minP;
            this.N = n;
            this.PresencePenalty = presencePenalty;
            this.RepetitionPenalty = repetitionPenalty;
            this.ResponseFormat = responseFormat;
            this.SafetyModel = safetyModel;
            this.Seed = seed;
            this.Stop = stop;
            this.Stream = stream;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopK = topK;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}