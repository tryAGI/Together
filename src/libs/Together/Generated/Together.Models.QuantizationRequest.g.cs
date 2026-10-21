
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for preparing an adapter for FP4 inference.
    /// </summary>
    public sealed partial class QuantizationRequest
    {
        /// <summary>
        /// Adapter inputs to prepare.<br/>
        /// Example: {"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
        /// </summary>
        /// <example>{"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.QuantizationPipelineInputs Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Adapter inputs to prepare.<br/>
        /// Example: {"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationRequest(
            global::Together.QuantizationPipelineInputs inputs)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationRequest" /> class.
        /// </summary>
        public QuantizationRequest()
        {
        }

    }
}