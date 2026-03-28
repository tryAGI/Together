
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChoicesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinishReasonJsonConverter))]
        public global::Together.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Together.ChatCompletionMessage? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AllOfJsonConverter<object, global::Together.LogprobsPart>))]
        public global::Together.AllOf<object, global::Together.LogprobsPart>? Logprobs { get; set; }

        /// <summary>
        /// Top log probabilities for the tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.Dictionary<string, double>? TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoicesDataItem" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="index"></param>
        /// <param name="seed"></param>
        /// <param name="finishReason"></param>
        /// <param name="message"></param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs">
        /// Top log probabilities for the tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChoicesDataItem(
            string? text,
            int? index,
            int? seed,
            global::Together.FinishReason? finishReason,
            global::Together.ChatCompletionMessage? message,
            global::Together.AllOf<object, global::Together.LogprobsPart>? logprobs,
            global::System.Collections.Generic.Dictionary<string, double>? topLogprobs)
        {
            this.Text = text;
            this.Index = index;
            this.Seed = seed;
            this.FinishReason = finishReason;
            this.Message = message;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoicesDataItem" /> class.
        /// </summary>
        public ChatCompletionChoicesDataItem()
        {
        }
    }
}