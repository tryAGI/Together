
#nullable enable

namespace Together
{
    /// <summary>
    /// Allocated GPU resources that training sessions attach to
    /// </summary>
    public sealed partial class RlModelResources
    {
        /// <summary>
        /// Unique identifier for the model resource<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Lifecycle status of the model resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlModelResourcesStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlModelResourcesStatus Status { get; set; }

        /// <summary>
        /// Structured detail for the model resource's current error. Set when the resource is in an error state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.RlModelResourcesError? Error { get; set; }

        /// <summary>
        /// Base model the resource is provisioned for<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </summary>
        /// <example>Qwen/Qwen3-0.6B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Compute layout provisioned for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlComputeConfig ComputeConfig { get; set; }

        /// <summary>
        /// Whether the resource hosts LoRA sessions or a full-weight session<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LoraEnabled { get; set; }

        /// <summary>
        /// Timestamp when the model resource was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </summary>
        /// <example>2026-01-02T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the model resource was last updated<br/>
        /// Example: 2026-01-02T00:00:05Z
        /// </summary>
        /// <example>2026-01-02T00:00:05Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Optimizer configuration for this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlOptimizerConfig OptimizerConfig { get; set; }

        /// <summary>
        /// ID of the user who created the model resource<br/>
        /// Example: user_123
        /// </summary>
        /// <example>user_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResources" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the model resource<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="status">
        /// Lifecycle status of the model resource
        /// </param>
        /// <param name="baseModel">
        /// Base model the resource is provisioned for<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </param>
        /// <param name="computeConfig">
        /// Compute layout provisioned for the resource.
        /// </param>
        /// <param name="loraEnabled">
        /// Whether the resource hosts LoRA sessions or a full-weight session<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the model resource was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the model resource was last updated<br/>
        /// Example: 2026-01-02T00:00:05Z
        /// </param>
        /// <param name="optimizerConfig">
        /// Optimizer configuration for this resource.
        /// </param>
        /// <param name="createdBy">
        /// ID of the user who created the model resource<br/>
        /// Example: user_123
        /// </param>
        /// <param name="error">
        /// Structured detail for the model resource's current error. Set when the resource is in an error state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelResources(
            string id,
            global::Together.RlModelResourcesStatus status,
            string baseModel,
            global::Together.RlComputeConfig computeConfig,
            bool loraEnabled,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Together.RlOptimizerConfig optimizerConfig,
            string createdBy,
            global::Together.RlModelResourcesError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Error = error;
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.ComputeConfig = computeConfig ?? throw new global::System.ArgumentNullException(nameof(computeConfig));
            this.LoraEnabled = loraEnabled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OptimizerConfig = optimizerConfig ?? throw new global::System.ArgumentNullException(nameof(optimizerConfig));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResources" /> class.
        /// </summary>
        public RlModelResources()
        {
        }

    }
}