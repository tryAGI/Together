
#nullable enable

namespace Together
{
    /// <summary>
    /// Quantization job that prepares an adapter for FP4 inference.
    /// </summary>
    public sealed partial class QuantizationJobVariant2
    {
        /// <summary>
        /// Job specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.QuantizationPipelineSpec Params { get; set; }

        /// <summary>
        /// Model artifacts produced by the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::Together.QuantizationResults? Results { get; set; }

        /// <summary>
        /// Events emitted by the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.QuantizationEvent> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationJobVariant2" /> class.
        /// </summary>
        /// <param name="params">
        /// Job specification.
        /// </param>
        /// <param name="events">
        /// Events emitted by the job.
        /// </param>
        /// <param name="results">
        /// Model artifacts produced by the job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationJobVariant2(
            global::Together.QuantizationPipelineSpec @params,
            global::System.Collections.Generic.IList<global::Together.QuantizationEvent> events,
            global::Together.QuantizationResults? results)
        {
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.Results = results;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationJobVariant2" /> class.
        /// </summary>
        public QuantizationJobVariant2()
        {
        }

    }
}