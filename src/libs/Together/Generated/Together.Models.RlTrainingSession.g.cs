
#nullable enable

namespace Together
{
    /// <summary>
    /// A training session and its current state
    /// </summary>
    public sealed partial class RlTrainingSession
    {
        /// <summary>
        /// ID of the training session<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name used to identify the training session<br/>
        /// Example: gsm8k-experiment-2
        /// </summary>
        /// <example>gsm8k-experiment-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Auxiliary metadata associated with the training session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlTrainingSessionMetadata Metadata { get; set; }

        /// <summary>
        /// Status of the training session<br/>
        /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
        /// </summary>
        /// <default>global::Together.RlTrainingSessionStatus.TrainingSessionStatusUnspecified</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTrainingSessionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlTrainingSessionStatus Status { get; set; } = global::Together.RlTrainingSessionStatus.TrainingSessionStatusUnspecified;

        /// <summary>
        /// Structured detail for the training session's current error. Set when the session is in an error state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.RlTrainingSessionError? Error { get; set; }

        /// <summary>
        /// List of saved inference checkpoints for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_checkpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint> InferenceCheckpoints { get; set; }

        /// <summary>
        /// List of saved training checkpoints for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_checkpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint> TrainingCheckpoints { get; set; }

        /// <summary>
        /// Checkpoint ID this session was resumed from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_from_checkpoint_id")]
        public string? ResumeFromCheckpointId { get; set; }

        /// <summary>
        /// Current training step<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </summary>
        /// <default>"0"</default>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> Step { get; set; } = "0";

        /// <summary>
        /// Timestamp when the training session was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </summary>
        /// <example>2026-01-02T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the training session was last updated<br/>
        /// Example: 2026-01-02T00:00:05Z
        /// </summary>
        /// <example>2026-01-02T00:00:05Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// LoRA adapter configuration. Present only for sessions running on a LoRA-enabled model resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_config")]
        public global::Together.RlLoraConfig? LoraConfig { get; set; }

        /// <summary>
        /// Model resource this session is attached to. The session runs on that resource's GPU pods.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_resources_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelResourcesId { get; set; }

        /// <summary>
        /// Base model the session trains, taken from the model resource it is attached to<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </summary>
        /// <example>Qwen/Qwen3-0.6B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// ID of the user who created the training session<br/>
        /// Example: user_123
        /// </summary>
        /// <example>user_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Session-scoped policy and weight versions for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlSessionPolicyState PolicyState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSession" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the training session<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="metadata">
        /// Auxiliary metadata associated with the training session
        /// </param>
        /// <param name="status">
        /// Status of the training session<br/>
        /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
        /// </param>
        /// <param name="inferenceCheckpoints">
        /// List of saved inference checkpoints for this session
        /// </param>
        /// <param name="trainingCheckpoints">
        /// List of saved training checkpoints for this session
        /// </param>
        /// <param name="step">
        /// Current training step<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the training session was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the training session was last updated<br/>
        /// Example: 2026-01-02T00:00:05Z
        /// </param>
        /// <param name="modelResourcesId">
        /// Model resource this session is attached to. The session runs on that resource's GPU pods.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="baseModel">
        /// Base model the session trains, taken from the model resource it is attached to<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </param>
        /// <param name="createdBy">
        /// ID of the user who created the training session<br/>
        /// Example: user_123
        /// </param>
        /// <param name="policyState">
        /// Session-scoped policy and weight versions for this session
        /// </param>
        /// <param name="displayName">
        /// Display name used to identify the training session<br/>
        /// Example: gsm8k-experiment-2
        /// </param>
        /// <param name="error">
        /// Structured detail for the training session's current error. Set when the session is in an error state.
        /// </param>
        /// <param name="resumeFromCheckpointId">
        /// Checkpoint ID this session was resumed from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration. Present only for sessions running on a LoRA-enabled model resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSession(
            string id,
            global::Together.RlTrainingSessionMetadata metadata,
            global::Together.RlTrainingSessionStatus status,
            global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint> inferenceCheckpoints,
            global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint> trainingCheckpoints,
            global::Together.OneOf<string, int?> step,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string modelResourcesId,
            string baseModel,
            string createdBy,
            global::Together.RlSessionPolicyState policyState,
            string? displayName,
            global::Together.RlTrainingSessionError? error,
            string? resumeFromCheckpointId,
            global::Together.RlLoraConfig? loraConfig)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Status = status;
            this.Error = error;
            this.InferenceCheckpoints = inferenceCheckpoints ?? throw new global::System.ArgumentNullException(nameof(inferenceCheckpoints));
            this.TrainingCheckpoints = trainingCheckpoints ?? throw new global::System.ArgumentNullException(nameof(trainingCheckpoints));
            this.ResumeFromCheckpointId = resumeFromCheckpointId;
            this.Step = step;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LoraConfig = loraConfig;
            this.ModelResourcesId = modelResourcesId ?? throw new global::System.ArgumentNullException(nameof(modelResourcesId));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.PolicyState = policyState ?? throw new global::System.ArgumentNullException(nameof(policyState));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSession" /> class.
        /// </summary>
        public RlTrainingSession()
        {
        }

    }
}