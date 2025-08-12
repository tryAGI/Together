
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// A truncated version of the fine-tune response, used for POST /fine-tunes, GET /fine-tunes and POST /fine-tunes/{id}/cancel endpoints
    /// </summary>
    public sealed partial class FinetuneResponseTruncated
    {
        /// <summary>
        /// Batch size used for training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Creation timestamp of the fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Events related to this fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? Events { get; set; }

        /// <summary>
        /// Checkpoint used to continue training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_checkpoint")]
        public string? FromCheckpoint { get; set; }

        /// <summary>
        /// Hugging Face Hub repo to start training from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_hf_model")]
        public string? FromHfModel { get; set; }

        /// <summary>
        /// The revision of the Hugging Face Hub model to continue training from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_model_revision")]
        public string? HfModelRevision { get; set; }

        /// <summary>
        /// Unique identifier for the fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Learning rate used for training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler")]
        public global::Together.LRScheduler? LrScheduler { get; set; }

        /// <summary>
        /// Maximum gradient norm for clipping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_grad_norm")]
        public float? MaxGradNorm { get; set; }

        /// <summary>
        /// Base model used for fine-tuning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_output_name")]
        public string? ModelOutputName { get; set; }

        /// <summary>
        /// Number of checkpoints saved during training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// Number of training epochs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// Number of evaluations during training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// Owner address information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_address")]
        public string? OwnerAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FinetuneJobStatus Status { get; set; }

        /// <summary>
        /// Suffix added to the fine-tuned model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// Count of tokens processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Total price for the fine-tuning job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_price")]
        public int? TotalPrice { get; set; }

        /// <summary>
        /// File-ID of the training file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        public string? TrainingFile { get; set; }

        /// <summary>
        /// Method of training used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>))]
        public global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? TrainingMethod { get; set; }

        /// <summary>
        /// Type of training used (full or LoRA)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>))]
        public global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// Last update timestamp of the fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Identifier for the user who created the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// File-ID of the validation file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// Weights &amp; Biases run name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_name")]
        public string? WandbName { get; set; }

        /// <summary>
        /// Weights &amp; Biases project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_project_name")]
        public string? WandbProjectName { get; set; }

        /// <summary>
        /// Ratio of warmup steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_ratio")]
        public float? WarmupRatio { get; set; }

        /// <summary>
        /// Weight decay value used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public float? WeightDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponseTruncated" /> class.
        /// </summary>
        /// <param name="batchSize">
        /// Batch size used for training
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp of the fine-tune job
        /// </param>
        /// <param name="events">
        /// Events related to this fine-tune job
        /// </param>
        /// <param name="fromCheckpoint">
        /// Checkpoint used to continue training
        /// </param>
        /// <param name="fromHfModel">
        /// Hugging Face Hub repo to start training from
        /// </param>
        /// <param name="hfModelRevision">
        /// The revision of the Hugging Face Hub model to continue training from
        /// </param>
        /// <param name="id">
        /// Unique identifier for the fine-tune job
        /// </param>
        /// <param name="learningRate">
        /// Learning rate used for training
        /// </param>
        /// <param name="lrScheduler"></param>
        /// <param name="maxGradNorm">
        /// Maximum gradient norm for clipping
        /// </param>
        /// <param name="model">
        /// Base model used for fine-tuning
        /// </param>
        /// <param name="modelOutputName"></param>
        /// <param name="nCheckpoints">
        /// Number of checkpoints saved during training
        /// </param>
        /// <param name="nEpochs">
        /// Number of training epochs
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations during training
        /// </param>
        /// <param name="ownerAddress">
        /// Owner address information
        /// </param>
        /// <param name="status"></param>
        /// <param name="suffix">
        /// Suffix added to the fine-tuned model name
        /// </param>
        /// <param name="tokenCount">
        /// Count of tokens processed
        /// </param>
        /// <param name="totalPrice">
        /// Total price for the fine-tuning job
        /// </param>
        /// <param name="trainingFile">
        /// File-ID of the training file
        /// </param>
        /// <param name="trainingMethod">
        /// Method of training used
        /// </param>
        /// <param name="trainingType">
        /// Type of training used (full or LoRA)
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp of the fine-tune job
        /// </param>
        /// <param name="userId">
        /// Identifier for the user who created the job
        /// </param>
        /// <param name="validationFile">
        /// File-ID of the validation file
        /// </param>
        /// <param name="wandbName">
        /// Weights &amp; Biases run name
        /// </param>
        /// <param name="wandbProjectName">
        /// Weights &amp; Biases project name
        /// </param>
        /// <param name="warmupRatio">
        /// Ratio of warmup steps
        /// </param>
        /// <param name="weightDecay">
        /// Weight decay value used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuneResponseTruncated(
            global::System.DateTime createdAt,
            string id,
            global::Together.FinetuneJobStatus status,
            global::System.DateTime updatedAt,
            int? batchSize,
            global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? events,
            string? fromCheckpoint,
            string? fromHfModel,
            string? hfModelRevision,
            float? learningRate,
            global::Together.LRScheduler? lrScheduler,
            float? maxGradNorm,
            string? model,
            string? modelOutputName,
            int? nCheckpoints,
            int? nEpochs,
            int? nEvals,
            string? ownerAddress,
            string? suffix,
            int? tokenCount,
            int? totalPrice,
            string? trainingFile,
            global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? trainingMethod,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType,
            string? userId,
            string? validationFile,
            string? wandbName,
            string? wandbProjectName,
            float? warmupRatio,
            float? weightDecay)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.BatchSize = batchSize;
            this.Events = events;
            this.FromCheckpoint = fromCheckpoint;
            this.FromHfModel = fromHfModel;
            this.HfModelRevision = hfModelRevision;
            this.LearningRate = learningRate;
            this.LrScheduler = lrScheduler;
            this.MaxGradNorm = maxGradNorm;
            this.Model = model;
            this.ModelOutputName = modelOutputName;
            this.NCheckpoints = nCheckpoints;
            this.NEpochs = nEpochs;
            this.NEvals = nEvals;
            this.OwnerAddress = ownerAddress;
            this.Suffix = suffix;
            this.TokenCount = tokenCount;
            this.TotalPrice = totalPrice;
            this.TrainingFile = trainingFile;
            this.TrainingMethod = trainingMethod;
            this.TrainingType = trainingType;
            this.UserId = userId;
            this.ValidationFile = validationFile;
            this.WandbName = wandbName;
            this.WandbProjectName = wandbProjectName;
            this.WarmupRatio = warmupRatio;
            this.WeightDecay = weightDecay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponseTruncated" /> class.
        /// </summary>
        public FinetuneResponseTruncated()
        {
        }
    }
}