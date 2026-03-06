
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlSampleSequence
    {
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
        /// Generated token IDs<br/>
        /// Example: [123, 456, 789]
        /// </summary>
        /// <example>[123, 456, 789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleSequence" /> class.
        /// </summary>
        /// <param name="logprobs">
        /// Log probabilities for each generated token<br/>
        /// Example: [-0.5, -1.2, -0.3]
        /// </param>
        /// <param name="stopReason">
        /// Reason for stopping generation<br/>
        /// Example: length
        /// </param>
        /// <param name="tokens">
        /// Generated token IDs<br/>
        /// Example: [123, 456, 789]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleSequence(
            global::System.Collections.Generic.IList<double>? logprobs,
            string? stopReason,
            global::System.Collections.Generic.IList<string>? tokens)
        {
            this.Logprobs = logprobs;
            this.StopReason = stopReason;
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleSequence" /> class.
        /// </summary>
        public RlSampleSequence()
        {
        }
    }
}