
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
        public int? ParamCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_steps")]
        public int? TotalSteps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_url")]
        public string? WandbUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public int? Step { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        public string? CheckpointPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_path")]
        public string? ModelPath { get; set; }

        /// <summary>
        /// Storage path for the tokenized dataset archive associated with this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenized_dataset_path")]
        public string? TokenizedDatasetPath { get; set; }

        /// <summary>
        /// For early_stopped events, the selected best-checkpoint step when a finite best metric exists. If early_stopping_best_metric_value is null, this is the halt step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("early_stopping_best_step")]
        public int? EarlyStoppingBestStep { get; set; }

        /// <summary>
        /// For early_stopped events, the best validation loss observed. Null if no improving evaluation was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("early_stopping_best_metric_value")]
        public double? EarlyStoppingBestMetricValue { get; set; }

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
        /// <param name="level"></param>
        /// <param name="paramCount"></param>
        /// <param name="tokenCount"></param>
        /// <param name="totalSteps"></param>
        /// <param name="wandbUrl"></param>
        /// <param name="step"></param>
        /// <param name="checkpointPath"></param>
        /// <param name="modelPath"></param>
        /// <param name="tokenizedDatasetPath">
        /// Storage path for the tokenized dataset archive associated with this event.
        /// </param>
        /// <param name="earlyStoppingBestStep">
        /// For early_stopped events, the selected best-checkpoint step when a finite best metric exists. If early_stopping_best_metric_value is null, this is the halt step.
        /// </param>
        /// <param name="earlyStoppingBestMetricValue">
        /// For early_stopped events, the best validation loss observed. Null if no improving evaluation was recorded.
        /// </param>
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
            global::Together.FinetuneEventLevels? level,
            int? paramCount,
            int? tokenCount,
            int? totalSteps,
            string? wandbUrl,
            int? step,
            string? checkpointPath,
            string? modelPath,
            string? tokenizedDatasetPath,
            int? earlyStoppingBestStep,
            double? earlyStoppingBestMetricValue,
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
            this.WandbUrl = wandbUrl;
            this.Step = step;
            this.CheckpointPath = checkpointPath;
            this.ModelPath = modelPath;
            this.TokenizedDatasetPath = tokenizedDatasetPath;
            this.EarlyStoppingBestStep = earlyStoppingBestStep;
            this.EarlyStoppingBestMetricValue = earlyStoppingBestMetricValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent" /> class.
        /// </summary>
        public FineTuneEvent()
        {
        }

    }
}