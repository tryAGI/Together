
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlStartTrainingSessionRequest
    {
        /// <summary>
        /// Base model to use for the training session<br/>
        /// Example: meta-llama/Meta-Llama-3-8B-Instruct
        /// </summary>
        /// <example>meta-llama/Meta-Llama-3-8B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Checkpoint ID to resume from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_from_checkpoint_id")]
        public string? ResumeFromCheckpointId { get; set; }

        /// <summary>
        /// Type of the training session. Defaults to TRAINER_AND_GENERATOR when unspecified. TRAINER_ONLY provisions only the trainer and rejects sample requests.<br/>
        /// Default Value: SESSION_TYPE_TRAINER_AND_GENERATOR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlSessionTypeJsonConverter))]
        public global::Together.RlSessionType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="RlStartTrainingSessionRequest" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// Base model to use for the training session<br/>
        /// Example: meta-llama/Meta-Llama-3-8B-Instruct
        /// </param>
        /// <param name="resumeFromCheckpointId">
        /// Checkpoint ID to resume from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="type">
        /// Type of the training session. Defaults to TRAINER_AND_GENERATOR when unspecified. TRAINER_ONLY provisions only the trainer and rejects sample requests.<br/>
        /// Default Value: SESSION_TYPE_TRAINER_AND_GENERATOR
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlStartTrainingSessionRequest(
            string baseModel,
            string? resumeFromCheckpointId,
            global::Together.RlSessionType? type,
            global::Together.RlLoraConfig? loraConfig)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.ResumeFromCheckpointId = resumeFromCheckpointId;
            this.Type = type;
            this.LoraConfig = loraConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlStartTrainingSessionRequest" /> class.
        /// </summary>
        public RlStartTrainingSessionRequest()
        {
        }
    }
}