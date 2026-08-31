
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
        /// GPU type used when model-resource creation omits gpu_type.<br/>
        /// Example: H100-80GB
        /// </summary>
        /// <example>H100-80GB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlSupportedModelDefaultGpuTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlSupportedModelDefaultGpuType DefaultGpuType { get; set; }

        /// <summary>
        /// Validated GPU configurations available for this base model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_configs")]
        public global::System.Collections.Generic.IList<global::Together.RlSupportedModelComputeConfig>? ComputeConfigs { get; set; }

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
        /// <param name="defaultGpuType">
        /// GPU type used when model-resource creation omits gpu_type.<br/>
        /// Example: H100-80GB
        /// </param>
        /// <param name="computeConfigs">
        /// Validated GPU configurations available for this base model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSupportedModel(
            string baseModel,
            global::Together.RlSupportedModelDefaultGpuType defaultGpuType,
            global::System.Collections.Generic.IList<global::Together.RlSupportedModelComputeConfig>? computeConfigs)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.DefaultGpuType = defaultGpuType;
            this.ComputeConfigs = computeConfigs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSupportedModel" /> class.
        /// </summary>
        public RlSupportedModel()
        {
        }

    }
}