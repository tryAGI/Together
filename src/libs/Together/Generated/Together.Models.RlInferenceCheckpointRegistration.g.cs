
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlInferenceCheckpointRegistration(
            string modelName,
            global::System.DateTime registeredAt)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.RegisteredAt = registeredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointRegistration" /> class.
        /// </summary>
        public RlInferenceCheckpointRegistration()
        {
        }
    }
}