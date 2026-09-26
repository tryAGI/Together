
#nullable enable

namespace Together
{
    /// <summary>
    /// A single generated completion sequence with tokens and logprobs
    /// </summary>
    public sealed partial class RlSampledSequence
    {
        /// <summary>
        /// Generated token IDs<br/>
        /// Example: [123, 456, 789]
        /// </summary>
        /// <example>[123, 456, 789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> Tokens { get; set; }

        /// <summary>
        /// Log probabilities for each generated token<br/>
        /// Example: [-0.5, -1.2, -0.3]
        /// </summary>
        /// <example>[-0.5, -1.2, -0.3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<double>? Logprobs { get; set; }

        /// <summary>
        /// Reason for stopping generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlStopReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlStopReason StopReason { get; set; }

        /// <summary>
        /// Number of model input tokens served from the prefix cache while generating this sequence.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_hit_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptCacheHitTokens { get; set; }

        /// <summary>
        /// Opaque key for reusing this sequence's expert selections during training. Pass it unchanged with the corresponding training sample. Absent for non-mixture-of-experts models or when `return_routed_experts` is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routed_experts_key")]
        public string? RoutedExpertsKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampledSequence" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Generated token IDs<br/>
        /// Example: [123, 456, 789]
        /// </param>
        /// <param name="stopReason">
        /// Reason for stopping generation
        /// </param>
        /// <param name="promptCacheHitTokens">
        /// Number of model input tokens served from the prefix cache while generating this sequence.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="logprobs">
        /// Log probabilities for each generated token<br/>
        /// Example: [-0.5, -1.2, -0.3]
        /// </param>
        /// <param name="routedExpertsKey">
        /// Opaque key for reusing this sequence's expert selections during training. Pass it unchanged with the corresponding training sample. Absent for non-mixture-of-experts models or when `return_routed_experts` is disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampledSequence(
            global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> tokens,
            global::Together.RlStopReason stopReason,
            int promptCacheHitTokens,
            global::System.Collections.Generic.IList<double>? logprobs,
            string? routedExpertsKey)
        {
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.Logprobs = logprobs;
            this.StopReason = stopReason;
            this.PromptCacheHitTokens = promptCacheHitTokens;
            this.RoutedExpertsKey = routedExpertsKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampledSequence" /> class.
        /// </summary>
        public RlSampledSequence()
        {
        }

    }
}