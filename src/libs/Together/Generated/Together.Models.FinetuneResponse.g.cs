
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo_beta")]
        public float? DpoBeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epochs_completed")]
        public int? EpochsCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_steps")]
        public int? EvalSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_checkpoint")]
        public string? FromCheckpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler")]
        public global::Together.LRScheduler? LrScheduler { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_grad_norm")]
        public float? MaxGradNorm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_output_name")]
        public string? ModelOutputName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_output_path")]
        public string? ModelOutputPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_count")]
        public int? ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_depth")]
        public int? QueueDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FinetuneJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_price")]
        public int? TotalPrice { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_on_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.FinetuneResponseTrainOnInputs?>))]
        public global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>? TrainOnInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        public string? TrainingFile { get; set; }

        /// <summary>
        /// Default Value: sft
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneResponseTrainingMethodJsonConverter))]
        public global::Together.FinetuneResponseTrainingMethod? TrainingMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>))]
        public global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingfile_numlines")]
        public int? TrainingfileNumlines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingfile_size")]
        public int? TrainingfileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_project_name")]
        public string? WandbProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_url")]
        public string? WandbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_ratio")]
        public double? WarmupRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public float? WeightDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponse" /> class.
        /// </summary>
        /// <param name="batchSize"></param>
        /// <param name="createdAt"></param>
        /// <param name="dpoBeta">
        /// Default Value: 0.1F
        /// </param>
        /// <param name="epochsCompleted"></param>
        /// <param name="evalSteps"></param>
        /// <param name="events"></param>
        /// <param name="fromCheckpoint"></param>
        /// <param name="id"></param>
        /// <param name="jobId"></param>
        /// <param name="learningRate"></param>
        /// <param name="lrScheduler"></param>
        /// <param name="maxGradNorm"></param>
        /// <param name="model"></param>
        /// <param name="modelOutputName"></param>
        /// <param name="modelOutputPath"></param>
        /// <param name="nCheckpoints"></param>
        /// <param name="nEpochs"></param>
        /// <param name="nEvals"></param>
        /// <param name="paramCount"></param>
        /// <param name="queueDepth"></param>
        /// <param name="status"></param>
        /// <param name="tokenCount"></param>
        /// <param name="totalPrice"></param>
        /// <param name="trainOnInputs">
        /// Default Value: auto
        /// </param>
        /// <param name="trainingFile"></param>
        /// <param name="trainingMethod">
        /// Default Value: sft
        /// </param>
        /// <param name="trainingType"></param>
        /// <param name="trainingfileNumlines"></param>
        /// <param name="trainingfileSize"></param>
        /// <param name="updatedAt"></param>
        /// <param name="validationFile"></param>
        /// <param name="wandbProjectName"></param>
        /// <param name="wandbUrl"></param>
        /// <param name="warmupRatio"></param>
        /// <param name="weightDecay"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuneResponse(
            global::System.Guid id,
            global::Together.FinetuneJobStatus status,
            int? batchSize,
            string? createdAt,
            float? dpoBeta,
            int? epochsCompleted,
            int? evalSteps,
            global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? events,
            string? fromCheckpoint,
            string? jobId,
            double? learningRate,
            global::Together.LRScheduler? lrScheduler,
            float? maxGradNorm,
            string? model,
            string? modelOutputName,
            string? modelOutputPath,
            int? nCheckpoints,
            int? nEpochs,
            int? nEvals,
            int? paramCount,
            int? queueDepth,
            int? tokenCount,
            int? totalPrice,
            global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>? trainOnInputs,
            string? trainingFile,
            global::Together.FinetuneResponseTrainingMethod? trainingMethod,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType,
            int? trainingfileNumlines,
            int? trainingfileSize,
            string? updatedAt,
            string? validationFile,
            string? wandbProjectName,
            string? wandbUrl,
            double? warmupRatio,
            float? weightDecay)
        {
            this.Id = id;
            this.Status = status;
            this.BatchSize = batchSize;
            this.CreatedAt = createdAt;
            this.DpoBeta = dpoBeta;
            this.EpochsCompleted = epochsCompleted;
            this.EvalSteps = evalSteps;
            this.Events = events;
            this.FromCheckpoint = fromCheckpoint;
            this.JobId = jobId;
            this.LearningRate = learningRate;
            this.LrScheduler = lrScheduler;
            this.MaxGradNorm = maxGradNorm;
            this.Model = model;
            this.ModelOutputName = modelOutputName;
            this.ModelOutputPath = modelOutputPath;
            this.NCheckpoints = nCheckpoints;
            this.NEpochs = nEpochs;
            this.NEvals = nEvals;
            this.ParamCount = paramCount;
            this.QueueDepth = queueDepth;
            this.TokenCount = tokenCount;
            this.TotalPrice = totalPrice;
            this.TrainOnInputs = trainOnInputs;
            this.TrainingFile = trainingFile;
            this.TrainingMethod = trainingMethod;
            this.TrainingType = trainingType;
            this.TrainingfileNumlines = trainingfileNumlines;
            this.TrainingfileSize = trainingfileSize;
            this.UpdatedAt = updatedAt;
            this.ValidationFile = validationFile;
            this.WandbProjectName = wandbProjectName;
            this.WandbUrl = wandbUrl;
            this.WarmupRatio = warmupRatio;
            this.WeightDecay = weightDecay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponse" /> class.
        /// </summary>
        public FinetuneResponse()
        {
        }
    }
}