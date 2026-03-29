
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneEvent
    {
        /// <summary>
        /// The object type, which is always `fine-tune-event`.
        /// </summary>
        /// <default>"fine-tune-event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "fine-tune-event";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneEventLevelsJsonConverter))]
        public global::Together.FinetuneEventLevels? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FinetuneEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WandbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Step { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrainingOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="paramCount"></param>
        /// <param name="tokenCount"></param>
        /// <param name="totalSteps"></param>
        /// <param name="wandbUrl"></param>
        /// <param name="step"></param>
        /// <param name="checkpointPath"></param>
        /// <param name="modelPath"></param>
        /// <param name="trainingOffset"></param>
        /// <param name="hash"></param>
        /// <param name="level"></param>
        /// <param name="object">
        /// The object type, which is always `fine-tune-event`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneEvent(
            string createdAt,
            string message,
            global::Together.FinetuneEventType type,
            int paramCount,
            int tokenCount,
            int totalSteps,
            string wandbUrl,
            int step,
            string checkpointPath,
            string modelPath,
            int trainingOffset,
            string hash,
            global::Together.FinetuneEventLevels? level,
            string @object = "fine-tune-event")
        {
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Level = level;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
            this.ParamCount = paramCount;
            this.TokenCount = tokenCount;
            this.TotalSteps = totalSteps;
            this.WandbUrl = wandbUrl ?? throw new global::System.ArgumentNullException(nameof(wandbUrl));
            this.Step = step;
            this.CheckpointPath = checkpointPath ?? throw new global::System.ArgumentNullException(nameof(checkpointPath));
            this.ModelPath = modelPath ?? throw new global::System.ArgumentNullException(nameof(modelPath));
            this.TrainingOffset = trainingOffset;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent" /> class.
        /// </summary>
        public FineTuneEvent()
        {
        }
    }
}