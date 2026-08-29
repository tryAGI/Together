
#nullable enable

namespace Together
{
    /// <summary>
    /// Result of a forward pass operation
    /// </summary>
    public sealed partial class RlForwardResult
    {
        /// <summary>
        /// Per-sample per-token log-probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlTargetLogprobs> Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardResult" /> class.
        /// </summary>
        /// <param name="logprobs">
        /// Per-sample per-token log-probabilities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlForwardResult(
            global::System.Collections.Generic.IList<global::Together.RlTargetLogprobs> logprobs)
        {
            this.Logprobs = logprobs ?? throw new global::System.ArgumentNullException(nameof(logprobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardResult" /> class.
        /// </summary>
        public RlForwardResult()
        {
        }

    }
}