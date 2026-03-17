
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlTrainingSession
    {
        /// <summary>
        /// ID of the training session<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Status of the training session<br/>
        /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTrainingSessionStatusJsonConverter))]
        public global::Together.RlTrainingSessionStatus? Status { get; set; }

        /// <summary>
        /// Base model used for the training session<br/>
        /// Example: meta-llama/Meta-Llama-3-8B-Instruct
        /// </summary>
        /// <example>meta-llama/Meta-Llama-3-8B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// List of saved inference checkpoints for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_checkpoints")]
        public global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint>? InferenceCheckpoints { get; set; }

        /// <summary>
        /// List of saved training checkpoints for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_checkpoints")]
        public global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint>? TrainingCheckpoints { get; set; }

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
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public string? Step { get; set; }

        /// <summary>
        /// Timestamp when the training session was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </summary>
        /// <example>2026-01-02T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the training session was last updated<br/>
        /// Example: 2026-01-02T00:00:05Z
        /// </summary>
        /// <example>2026-01-02T00:00:05Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// LoRA adapter configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_config")]
        public global::Together.RlLoraConfig? LoraConfig { get; set; }

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
        /// <param name="resumeFromCheckpointId">
        /// Checkpoint ID this session was resumed from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSession(
            string? id,
            global::Together.RlTrainingSessionStatus? status,
            string? baseModel,
            global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint>? inferenceCheckpoints,
            global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint>? trainingCheckpoints,
            string? resumeFromCheckpointId,
            string? step,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::Together.RlLoraConfig? loraConfig)
        {
            this.Id = id;
            this.Status = status;
            this.BaseModel = baseModel;
            this.InferenceCheckpoints = inferenceCheckpoints;
            this.TrainingCheckpoints = trainingCheckpoints;
            this.ResumeFromCheckpointId = resumeFromCheckpointId;
            this.Step = step;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LoraConfig = loraConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSession" /> class.
        /// </summary>
        public RlTrainingSession()
        {
        }
    }
}