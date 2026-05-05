
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
        /// Status of the training session<br/>
        /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
        /// </summary>
        /// <default>global::Together.RlTrainingSessionStatus.TrainingSessionStatusUnspecified</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTrainingSessionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlTrainingSessionStatus Status { get; set; } = global::Together.RlTrainingSessionStatus.TrainingSessionStatusUnspecified;

        /// <summary>
        /// Base model used for the training session<br/>
        /// Example: meta-llama/Meta-Llama-3-8B-Instruct
        /// </summary>
        /// <example>meta-llama/Meta-Llama-3-8B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

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
        /// LoRA adapter configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLoraConfig LoraConfig { get; set; }

        /// <summary>
        /// Type of the training session. TRAINER_AND_GENERATOR provisions both trainer and generator; TRAINER_ONLY provisions only the trainer and rejects generator-dependent operations such as sample.<br/>
        /// Default Value: SESSION_TYPE_UNSPECIFIED
        /// </summary>
        /// <default>global::Together.RlSessionType.SessionTypeUnspecified</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlSessionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlSessionType Type { get; set; } = global::Together.RlSessionType.SessionTypeUnspecified;

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
        /// <param name="status">
        /// Status of the training session<br/>
        /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
        /// </param>
        /// <param name="baseModel">
        /// Base model used for the training session<br/>
        /// Example: meta-llama/Meta-Llama-3-8B-Instruct
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
        /// <param name="loraConfig">
        /// LoRA adapter configuration
        /// </param>
        /// <param name="type">
        /// Type of the training session. TRAINER_AND_GENERATOR provisions both trainer and generator; TRAINER_ONLY provisions only the trainer and rejects generator-dependent operations such as sample.<br/>
        /// Default Value: SESSION_TYPE_UNSPECIFIED
        /// </param>
        /// <param name="resumeFromCheckpointId">
        /// Checkpoint ID this session was resumed from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSession(
            string id,
            global::Together.RlTrainingSessionStatus status,
            string baseModel,
            global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint> inferenceCheckpoints,
            global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint> trainingCheckpoints,
            global::Together.OneOf<string, int?> step,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Together.RlLoraConfig loraConfig,
            global::Together.RlSessionType type,
            string? resumeFromCheckpointId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.InferenceCheckpoints = inferenceCheckpoints ?? throw new global::System.ArgumentNullException(nameof(inferenceCheckpoints));
            this.TrainingCheckpoints = trainingCheckpoints ?? throw new global::System.ArgumentNullException(nameof(trainingCheckpoints));
            this.ResumeFromCheckpointId = resumeFromCheckpointId;
            this.Step = step;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LoraConfig = loraConfig ?? throw new global::System.ArgumentNullException(nameof(loraConfig));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSession" /> class.
        /// </summary>
        public RlTrainingSession()
        {
        }
    }
}