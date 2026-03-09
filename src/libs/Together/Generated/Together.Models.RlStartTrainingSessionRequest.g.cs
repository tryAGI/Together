
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
        public string BaseModel { get; set; } = default!;

        /// <summary>
        /// Checkpoint ID to use for the training session<br/>
        /// Example: checkpoint-123
        /// </summary>
        /// <example>checkpoint-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_id")]
        public string? CheckpointId { get; set; }

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
        /// <param name="checkpointId">
        /// Checkpoint ID to use for the training session<br/>
        /// Example: checkpoint-123
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlStartTrainingSessionRequest(
            string baseModel,
            string? checkpointId,
            global::Together.RlLoraConfig? loraConfig)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.CheckpointId = checkpointId;
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