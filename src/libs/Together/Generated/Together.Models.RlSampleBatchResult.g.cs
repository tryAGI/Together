
#nullable enable

namespace Together
{
    /// <summary>
    /// Batched result of a sample operation
    /// </summary>
    public sealed partial class RlSampleBatchResult
    {
        /// <summary>
        /// One result per model input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlSampleResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBatchResult" /> class.
        /// </summary>
        /// <param name="results">
        /// One result per model input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleBatchResult(
            global::System.Collections.Generic.IList<global::Together.RlSampleResult> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBatchResult" /> class.
        /// </summary>
        public RlSampleBatchResult()
        {
        }

    }
}