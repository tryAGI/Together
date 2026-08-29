
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlStartTrainingSessionRequest
    {
        /// <summary>
        /// Checkpoint ID to resume from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_from_checkpoint_id")]
        public string? ResumeFromCheckpointId { get; set; }

        /// <summary>
        /// HuggingFace repo (or hf://) to resume model weights from. Accepts either a full model or a PEFT adapter directory. Mutually exclusive with resume_from_checkpoint_id.<br/>
        /// Example: your-org/llama-3-8b-finetuned
        /// </summary>
        /// <example>your-org/llama-3-8b-finetuned</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_from_hf_checkpoint")]
        public string? ResumeFromHfCheckpoint { get; set; }

        /// <summary>
        /// LoRA adapter configuration for the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_config")]
        public global::Together.RlLoraConfig? LoraConfig { get; set; }

        /// <summary>
        /// Model resource to attach the session to. The session runs on that resource's GPU pods.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_resources_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelResourcesId { get; set; }

        /// <summary>
        /// Optional display name used to identify the training session<br/>
        /// Example: gsm8k-experiment-2
        /// </summary>
        /// <example>gsm8k-experiment-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional auxiliary metadata to associate with the training session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Together.RlTrainingSessionMetadata? Metadata { get; set; }

        /// <summary>
        /// Whether to restore optimizer state and step from a training checkpoint. Omitted or true restores them; false loads weights only with a fresh optimizer and step 0. Not valid for inference or HuggingFace checkpoints, which have no optimizer state.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("load_optimizer")]
        public bool? LoadOptimizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlStartTrainingSessionRequest" /> class.
        /// </summary>
        /// <param name="modelResourcesId">
        /// Model resource to attach the session to. The session runs on that resource's GPU pods.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="resumeFromCheckpointId">
        /// Checkpoint ID to resume from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="resumeFromHfCheckpoint">
        /// HuggingFace repo (or hf://) to resume model weights from. Accepts either a full model or a PEFT adapter directory. Mutually exclusive with resume_from_checkpoint_id.<br/>
        /// Example: your-org/llama-3-8b-finetuned
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration for the session
        /// </param>
        /// <param name="displayName">
        /// Optional display name used to identify the training session<br/>
        /// Example: gsm8k-experiment-2
        /// </param>
        /// <param name="metadata">
        /// Optional auxiliary metadata to associate with the training session
        /// </param>
        /// <param name="loadOptimizer">
        /// Whether to restore optimizer state and step from a training checkpoint. Omitted or true restores them; false loads weights only with a fresh optimizer and step 0. Not valid for inference or HuggingFace checkpoints, which have no optimizer state.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlStartTrainingSessionRequest(
            string modelResourcesId,
            string? resumeFromCheckpointId,
            string? resumeFromHfCheckpoint,
            global::Together.RlLoraConfig? loraConfig,
            string? displayName,
            global::Together.RlTrainingSessionMetadata? metadata,
            bool? loadOptimizer)
        {
            this.ResumeFromCheckpointId = resumeFromCheckpointId;
            this.ResumeFromHfCheckpoint = resumeFromHfCheckpoint;
            this.LoraConfig = loraConfig;
            this.ModelResourcesId = modelResourcesId ?? throw new global::System.ArgumentNullException(nameof(modelResourcesId));
            this.DisplayName = displayName;
            this.Metadata = metadata;
            this.LoadOptimizer = loadOptimizer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlStartTrainingSessionRequest" /> class.
        /// </summary>
        public RlStartTrainingSessionRequest()
        {
        }

    }
}