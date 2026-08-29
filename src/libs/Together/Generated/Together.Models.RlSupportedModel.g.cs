
#nullable enable

namespace Together
{
    /// <summary>
    /// A base model supported by the RL service. Per-mode configs are present only when the model supports that mode.
    /// </summary>
    public sealed partial class RlSupportedModel
    {
        /// <summary>
        /// Base model identifier to pass as base_model when creating a model resource<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </summary>
        /// <example>Qwen/Qwen3-0.6B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Training config. Set when the model supports at least one training mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_config")]
        public global::Together.RlModelTrainerConfig? TrainerConfig { get; set; }

        /// <summary>
        /// Inference config. Set when the model can be provisioned with generator replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generator_config")]
        public global::Together.RlModelGeneratorConfig? GeneratorConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSupportedModel" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// Base model identifier to pass as base_model when creating a model resource<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </param>
        /// <param name="trainerConfig">
        /// Training config. Set when the model supports at least one training mode.
        /// </param>
        /// <param name="generatorConfig">
        /// Inference config. Set when the model can be provisioned with generator replicas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSupportedModel(
            string baseModel,
            global::Together.RlModelTrainerConfig? trainerConfig,
            global::Together.RlModelGeneratorConfig? generatorConfig)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.TrainerConfig = trainerConfig;
            this.GeneratorConfig = generatorConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSupportedModel" /> class.
        /// </summary>
        public RlSupportedModel()
        {
        }

    }
}