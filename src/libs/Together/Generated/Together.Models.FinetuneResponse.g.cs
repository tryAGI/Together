
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        public string? TrainingFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// Default Value: max
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.FinetuneResponseBatchSize?>))]
        public global::Together.OneOf<int?, global::Together.FinetuneResponseBatchSize?>? BatchSize { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_ratio")]
        public double? WarmupRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_grad_norm")]
        public float? MaxGradNorm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public float? WeightDecay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_steps")]
        public int? EvalSteps { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_on_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.FinetuneResponseTrainOnInputs?>))]
        public global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>? TrainOnInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>))]
        public global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? TrainingMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>))]
        public global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multimodal_params")]
        public global::Together.MultimodalParams? MultimodalParams { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_count")]
        public int? ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_price")]
        public int? TotalPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epochs_completed")]
        public int? EpochsCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_depth")]
        public int? QueueDepth { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("from_checkpoint")]
        public string? FromCheckpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_hf_model")]
        public string? FromHfModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_model_revision")]
        public string? HfModelRevision { get; set; }

        /// <summary>
        /// Progress information for a fine-tuning job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::Together.FineTuneProgress? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trainingFile"></param>
        /// <param name="validationFile"></param>
        /// <param name="model"></param>
        /// <param name="modelOutputName"></param>
        /// <param name="modelOutputPath"></param>
        /// <param name="trainingfileNumlines"></param>
        /// <param name="trainingfileSize"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="nEpochs"></param>
        /// <param name="nCheckpoints"></param>
        /// <param name="nEvals"></param>
        /// <param name="batchSize">
        /// Default Value: max
        /// </param>
        /// <param name="learningRate"></param>
        /// <param name="lrScheduler"></param>
        /// <param name="warmupRatio"></param>
        /// <param name="maxGradNorm"></param>
        /// <param name="weightDecay"></param>
        /// <param name="evalSteps"></param>
        /// <param name="trainOnInputs">
        /// Default Value: auto
        /// </param>
        /// <param name="trainingMethod"></param>
        /// <param name="trainingType"></param>
        /// <param name="multimodalParams"></param>
        /// <param name="status"></param>
        /// <param name="jobId"></param>
        /// <param name="events"></param>
        /// <param name="tokenCount"></param>
        /// <param name="paramCount"></param>
        /// <param name="totalPrice"></param>
        /// <param name="epochsCompleted"></param>
        /// <param name="queueDepth"></param>
        /// <param name="wandbProjectName"></param>
        /// <param name="wandbUrl"></param>
        /// <param name="fromCheckpoint"></param>
        /// <param name="fromHfModel"></param>
        /// <param name="hfModelRevision"></param>
        /// <param name="progress">
        /// Progress information for a fine-tuning job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuneResponse(
            global::System.Guid id,
            global::Together.FinetuneJobStatus status,
            string? trainingFile,
            string? validationFile,
            string? model,
            string? modelOutputName,
            string? modelOutputPath,
            int? trainingfileNumlines,
            int? trainingfileSize,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? startedAt,
            int? nEpochs,
            int? nCheckpoints,
            int? nEvals,
            global::Together.OneOf<int?, global::Together.FinetuneResponseBatchSize?>? batchSize,
            double? learningRate,
            global::Together.LRScheduler? lrScheduler,
            double? warmupRatio,
            float? maxGradNorm,
            float? weightDecay,
            int? evalSteps,
            global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>? trainOnInputs,
            global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? trainingMethod,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType,
            global::Together.MultimodalParams? multimodalParams,
            string? jobId,
            global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? events,
            int? tokenCount,
            int? paramCount,
            int? totalPrice,
            int? epochsCompleted,
            int? queueDepth,
            string? wandbProjectName,
            string? wandbUrl,
            string? fromCheckpoint,
            string? fromHfModel,
            string? hfModelRevision,
            global::Together.FineTuneProgress? progress)
        {
            this.Id = id;
            this.Status = status;
            this.TrainingFile = trainingFile;
            this.ValidationFile = validationFile;
            this.Model = model;
            this.ModelOutputName = modelOutputName;
            this.ModelOutputPath = modelOutputPath;
            this.TrainingfileNumlines = trainingfileNumlines;
            this.TrainingfileSize = trainingfileSize;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.NEpochs = nEpochs;
            this.NCheckpoints = nCheckpoints;
            this.NEvals = nEvals;
            this.BatchSize = batchSize;
            this.LearningRate = learningRate;
            this.LrScheduler = lrScheduler;
            this.WarmupRatio = warmupRatio;
            this.MaxGradNorm = maxGradNorm;
            this.WeightDecay = weightDecay;
            this.EvalSteps = evalSteps;
            this.TrainOnInputs = trainOnInputs;
            this.TrainingMethod = trainingMethod;
            this.TrainingType = trainingType;
            this.MultimodalParams = multimodalParams;
            this.JobId = jobId;
            this.Events = events;
            this.TokenCount = tokenCount;
            this.ParamCount = paramCount;
            this.TotalPrice = totalPrice;
            this.EpochsCompleted = epochsCompleted;
            this.QueueDepth = queueDepth;
            this.WandbProjectName = wandbProjectName;
            this.WandbUrl = wandbUrl;
            this.FromCheckpoint = fromCheckpoint;
            this.FromHfModel = fromHfModel;
            this.HfModelRevision = hfModelRevision;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponse" /> class.
        /// </summary>
        public FinetuneResponse()
        {
        }
    }
}