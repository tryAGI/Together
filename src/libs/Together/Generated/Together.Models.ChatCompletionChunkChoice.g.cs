
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunkChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FinishReason FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public double? Logprobs { get; set; }

        /// <summary>
        /// Top log probabilities for the tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.Dictionary<string, double>? TopLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ChatCompletionChunkChoiceDelta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="finishReason"></param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs">
        /// Top log probabilities for the tokens.
        /// </param>
        /// <param name="seed"></param>
        /// <param name="delta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunkChoice(
            int index,
            global::Together.FinishReason finishReason,
            global::Together.ChatCompletionChunkChoiceDelta delta,
            double? logprobs,
            global::System.Collections.Generic.Dictionary<string, double>? topLogprobs,
            int? seed)
        {
            this.Index = index;
            this.FinishReason = finishReason;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        public ChatCompletionChunkChoice()
        {
        }
    }
}