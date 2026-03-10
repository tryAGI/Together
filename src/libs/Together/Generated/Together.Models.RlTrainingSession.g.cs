
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlTrainingSession
    {
        /// <summary>
        /// ID of the training session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

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
        /// Checkpoint ID to use for the training session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_id")]
        public string? CheckpointId { get; set; }

        /// <summary>
        /// Current training step<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public string? Step { get; set; }

        /// <summary>
        /// Timestamp when the training session was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the training session was last updated
        /// </summary>
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
        /// <param name="sessionId">
        /// ID of the training session
        /// </param>
        /// <param name="status">
        /// Status of the training session<br/>
        /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
        /// </param>
        /// <param name="baseModel">
        /// Base model used for the training session<br/>
        /// Example: meta-llama/Meta-Llama-3-8B-Instruct
        /// </param>
        /// <param name="checkpointId">
        /// Checkpoint ID to use for the training session
        /// </param>
        /// <param name="step">
        /// Current training step<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the training session was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the training session was last updated
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSession(
            string? sessionId,
            global::Together.RlTrainingSessionStatus? status,
            string? baseModel,
            string? checkpointId,
            string? step,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::Together.RlLoraConfig? loraConfig)
        {
            this.SessionId = sessionId;
            this.Status = status;
            this.BaseModel = baseModel;
            this.CheckpointId = checkpointId;
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