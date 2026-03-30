
#nullable enable

namespace Together
{
    /// <summary>
    /// A single generated completion sequence with tokens and logprobs
    /// </summary>
    public sealed partial class RlSampleSequence
    {
        /// <summary>
        /// Generated token IDs<br/>
        /// Example: [123, 456, 789]
        /// </summary>
        /// <example>[123, 456, 789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tokens { get; set; }

        /// <summary>
        /// Log probabilities for each generated token<br/>
        /// Example: [-0.5, -1.2, -0.3]
        /// </summary>
        /// <example>[-0.5, -1.2, -0.3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<double>? Logprobs { get; set; }

        /// <summary>
        /// Reason for stopping generation<br/>
        /// Example: length
        /// </summary>
        /// <example>length</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        public string? StopReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleSequence" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Generated token IDs<br/>
        /// Example: [123, 456, 789]
        /// </param>
        /// <param name="logprobs">
        /// Log probabilities for each generated token<br/>
        /// Example: [-0.5, -1.2, -0.3]
        /// </param>
        /// <param name="stopReason">
        /// Reason for stopping generation<br/>
        /// Example: length
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleSequence(
            global::System.Collections.Generic.IList<string> tokens,
            global::System.Collections.Generic.IList<double>? logprobs,
            string? stopReason)
        {
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.Logprobs = logprobs;
            this.StopReason = stopReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleSequence" /> class.
        /// </summary>
        public RlSampleSequence()
        {
        }
    }
}