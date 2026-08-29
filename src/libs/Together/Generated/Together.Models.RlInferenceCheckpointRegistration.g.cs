
#nullable enable

namespace Together
{
    /// <summary>
    /// Model registration details for an inference checkpoint
    /// </summary>
    public sealed partial class RlInferenceCheckpointRegistration
    {
        /// <summary>
        /// Registered model name for downloading the checkpoint<br/>
        /// Example: username/Meta-Llama-3-8B-rl-step-42-20260216
        /// </summary>
        /// <example>username/Meta-Llama-3-8B-rl-step-42-20260216</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Timestamp when the model was registered<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </summary>
        /// <example>2026-01-02T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("registered_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RegisteredAt { get; set; }

        /// <summary>
        /// Together model registry object ID for the model checkpoint (e.g. `ml_...`), set on full-weight training sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_object_id")]
        public string? ModelObjectId { get; set; }

        /// <summary>
        /// Together model registry revision ID for the model checkpoint (e.g. `rv_...`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_object_revision_id")]
        public string? ModelObjectRevisionId { get; set; }

        /// <summary>
        /// Together model registry object ID for the adapter checkpoint (e.g. `ml_...`), set on LoRA training sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_object_id")]
        public string? AdapterObjectId { get; set; }

        /// <summary>
        /// Together model registry revision ID for the adapter checkpoint (e.g. `rv_...`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_object_revision_id")]
        public string? AdapterObjectRevisionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointRegistration" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Registered model name for downloading the checkpoint<br/>
        /// Example: username/Meta-Llama-3-8B-rl-step-42-20260216
        /// </param>
        /// <param name="registeredAt">
        /// Timestamp when the model was registered<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </param>
        /// <param name="modelObjectId">
        /// Together model registry object ID for the model checkpoint (e.g. `ml_...`), set on full-weight training sessions
        /// </param>
        /// <param name="modelObjectRevisionId">
        /// Together model registry revision ID for the model checkpoint (e.g. `rv_...`)
        /// </param>
        /// <param name="adapterObjectId">
        /// Together model registry object ID for the adapter checkpoint (e.g. `ml_...`), set on LoRA training sessions
        /// </param>
        /// <param name="adapterObjectRevisionId">
        /// Together model registry revision ID for the adapter checkpoint (e.g. `rv_...`)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlInferenceCheckpointRegistration(
            string modelName,
            global::System.DateTime registeredAt,
            string? modelObjectId,
            string? modelObjectRevisionId,
            string? adapterObjectId,
            string? adapterObjectRevisionId)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.RegisteredAt = registeredAt;
            this.ModelObjectId = modelObjectId;
            this.ModelObjectRevisionId = modelObjectRevisionId;
            this.AdapterObjectId = adapterObjectId;
            this.AdapterObjectRevisionId = adapterObjectRevisionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointRegistration" /> class.
        /// </summary>
        public RlInferenceCheckpointRegistration()
        {
        }

    }
}