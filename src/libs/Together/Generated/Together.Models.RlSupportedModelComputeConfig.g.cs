
#nullable enable

namespace Together
{
    /// <summary>
    /// A validated hardware configuration available for an RL base model.
    /// </summary>
    public sealed partial class RlSupportedModelComputeConfig
    {
        /// <summary>
        /// GPU type this configuration provisions.<br/>
        /// Example: H100-80GB
        /// </summary>
        /// <example>H100-80GB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlSupportedModelComputeConfigGpuTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlSupportedModelComputeConfigGpuType GpuType { get; set; }

        /// <summary>
        /// Training config for this GPU type. Set when the model supports at least one training mode on this GPU type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_config")]
        public global::Together.RlModelTrainerConfig? TrainerConfig { get; set; }

        /// <summary>
        /// Inference config for this GPU type. Set when the model can be provisioned with generator replicas on this GPU type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generator_config")]
        public global::Together.RlModelGeneratorConfig? GeneratorConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSupportedModelComputeConfig" /> class.
        /// </summary>
        /// <param name="gpuType">
        /// GPU type this configuration provisions.<br/>
        /// Example: H100-80GB
        /// </param>
        /// <param name="trainerConfig">
        /// Training config for this GPU type. Set when the model supports at least one training mode on this GPU type.
        /// </param>
        /// <param name="generatorConfig">
        /// Inference config for this GPU type. Set when the model can be provisioned with generator replicas on this GPU type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSupportedModelComputeConfig(
            global::Together.RlSupportedModelComputeConfigGpuType gpuType,
            global::Together.RlModelTrainerConfig? trainerConfig,
            global::Together.RlModelGeneratorConfig? generatorConfig)
        {
            this.GpuType = gpuType;
            this.TrainerConfig = trainerConfig;
            this.GeneratorConfig = generatorConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSupportedModelComputeConfig" /> class.
        /// </summary>
        public RlSupportedModelComputeConfig()
        {
        }

    }
}