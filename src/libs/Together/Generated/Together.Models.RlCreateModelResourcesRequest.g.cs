
#nullable enable

namespace Together
{
    /// <summary>
    /// Request to provision a standalone model resource
    /// </summary>
    public sealed partial class RlCreateModelResourcesRequest
    {
        /// <summary>
        /// Base model to provision the resource for<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </summary>
        /// <example>Qwen/Qwen3-0.6B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Compute layout to provision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_config")]
        public global::Together.RlComputeConfigCreateRequest? ComputeConfig { get; set; }

        /// <summary>
        /// Whether the resource hosts LoRA sessions or a single full-weight session<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_enabled")]
        public bool? LoraEnabled { get; set; }

        /// <summary>
        /// Optimizer configuration for this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer_config")]
        public global::Together.RlOptimizerConfig? OptimizerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCreateModelResourcesRequest" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// Base model to provision the resource for<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </param>
        /// <param name="computeConfig">
        /// Compute layout to provision.
        /// </param>
        /// <param name="loraEnabled">
        /// Whether the resource hosts LoRA sessions or a single full-weight session<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="optimizerConfig">
        /// Optimizer configuration for this resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlCreateModelResourcesRequest(
            string baseModel,
            global::Together.RlComputeConfigCreateRequest? computeConfig,
            bool? loraEnabled,
            global::Together.RlOptimizerConfig? optimizerConfig)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.ComputeConfig = computeConfig;
            this.LoraEnabled = loraEnabled;
            this.OptimizerConfig = optimizerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCreateModelResourcesRequest" /> class.
        /// </summary>
        public RlCreateModelResourcesRequest()
        {
        }

    }
}