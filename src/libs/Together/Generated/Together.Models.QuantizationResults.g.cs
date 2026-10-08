
#nullable enable

namespace Together
{
    /// <summary>
    /// Model artifact produced by a completed quantization job.
    /// </summary>
    public sealed partial class QuantizationResults
    {
        /// <summary>
        /// Model object ID registered by the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_object_id")]
        public string? ModelObjectId { get; set; }

        /// <summary>
        /// Model revision ID registered by the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_revision_id")]
        public string? ModelRevisionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationResults" /> class.
        /// </summary>
        /// <param name="modelObjectId">
        /// Model object ID registered by the job.
        /// </param>
        /// <param name="modelRevisionId">
        /// Model revision ID registered by the job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationResults(
            string? modelObjectId,
            string? modelRevisionId)
        {
            this.ModelObjectId = modelObjectId;
            this.ModelRevisionId = modelRevisionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationResults" /> class.
        /// </summary>
        public QuantizationResults()
        {
        }

    }
}