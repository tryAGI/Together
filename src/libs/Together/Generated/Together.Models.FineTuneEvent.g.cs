
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CheckpointPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Hash { get; set; } = default!;

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
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ModelPath { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `fine-tune-event`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FineTuneEventObjectJsonConverter))]
        public global::Together.FineTuneEventObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ParamCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Step { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TokenCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalSteps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TrainingOffset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.FinetuneEventType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string WandbUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent" /> class.
        /// </summary>
        /// <param name="checkpointPath"></param>
        /// <param name="createdAt"></param>
        /// <param name="hash"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="modelPath"></param>
        /// <param name="object">
        /// The object type, which is always `fine-tune-event`.
        /// </param>
        /// <param name="paramCount"></param>
        /// <param name="step"></param>
        /// <param name="tokenCount"></param>
        /// <param name="totalSteps"></param>
        /// <param name="trainingOffset"></param>
        /// <param name="type"></param>
        /// <param name="wandbUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneEvent(
            string checkpointPath,
            string createdAt,
            string hash,
            string message,
            string modelPath,
            int paramCount,
            int step,
            int tokenCount,
            int totalSteps,
            int trainingOffset,
            global::Together.FinetuneEventType type,
            string wandbUrl,
            global::Together.FinetuneEventLevels? level,
            global::Together.FineTuneEventObject @object)
        {
            this.CheckpointPath = checkpointPath ?? throw new global::System.ArgumentNullException(nameof(checkpointPath));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ModelPath = modelPath ?? throw new global::System.ArgumentNullException(nameof(modelPath));
            this.ParamCount = paramCount;
            this.Step = step;
            this.TokenCount = tokenCount;
            this.TotalSteps = totalSteps;
            this.TrainingOffset = trainingOffset;
            this.Type = type;
            this.WandbUrl = wandbUrl ?? throw new global::System.ArgumentNullException(nameof(wandbUrl));
            this.Level = level;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent" /> class.
        /// </summary>
        public FineTuneEvent()
        {
        }
    }
}