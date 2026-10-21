
#nullable enable

namespace Together
{
    /// <summary>
    /// Stored job specification containing the request and resolved configuration.
    /// </summary>
    public sealed partial class QuantizationPipelineSpec
    {
        /// <summary>
        /// Adapter inputs requested by the caller.<br/>
        /// Example: {"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
        /// </summary>
        /// <example>{"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.QuantizationPipelineInputs Inputs { get; set; }

        /// <summary>
        /// Server-resolved configuration for the run.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Together.QuantizationPipelineConfiguration Configuration { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationPipelineSpec" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Adapter inputs requested by the caller.<br/>
        /// Example: {"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
        /// </param>
        /// <param name="configuration">
        /// Server-resolved configuration for the run.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationPipelineSpec(
            global::Together.QuantizationPipelineInputs inputs,
            global::Together.QuantizationPipelineConfiguration configuration = default!)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationPipelineSpec" /> class.
        /// </summary>
        public QuantizationPipelineSpec()
        {
        }

        /// <summary>
        /// Creates a new <see cref="QuantizationPipelineSpec"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static QuantizationPipelineSpec FromInputs(global::Together.QuantizationPipelineInputs inputs)
        {
            return new QuantizationPipelineSpec
            {
                Inputs = inputs,
            };
        }

    }
}