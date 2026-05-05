
#nullable enable

namespace Together
{
    /// <summary>
    /// A truncated version of the fine-tune response, used for POST /fine-tunes, GET /fine-tunes and POST /fine-tunes/{id}/cancel endpoints<br/>
    /// Example: {"id":"ft-01234567890123456789","status":"completed","created_at":"2023-05-17T17:35:45.123Z","updated_at":"2023-05-17T18:46:23.456Z","user_id":"user_01234567890123456789","owner_address":"user@example.com","total_price":1500,"token_count":850000,"events":[],"model":"meta-llama/Llama-2-7b-hf","model_output_name":"mynamespace/meta-llama/Llama-2-7b-hf-32162631","n_epochs":3,"training_file":"file-01234567890123456789","wandb_project_name":"my-finetune-project"}
    /// </summary>
    public sealed partial class FinetuneResponseTruncated
    {
        /// <summary>
        /// Unique identifier for the fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FinetuneJobStatus Status { get; set; }

        /// <summary>
        /// Creation timestamp of the fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp of the fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Start timestamp of the current stage of the fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Identifier for the user who created the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Owner address information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_address")]
        public string? OwnerAddress { get; set; }

        /// <summary>
        /// Total price for the fine-tuning job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_price")]
        public int? TotalPrice { get; set; }

        /// <summary>
        /// Count of tokens processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Events related to this fine-tune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? Events { get; set; }

        /// <summary>
        /// File-ID of the training file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        public string? TrainingFile { get; set; }

        /// <summary>
        /// File-ID of the validation file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// Whether sequence packing is being used for training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packing")]
        public bool? Packing { get; set; }

        /// <summary>
        /// Maximum sequence length to use for training. If not specified, the maximum allowed for the model and training method will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_length")]
        public int? MaxSeqLength { get; set; }

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
        /// Suffix added to the fine-tuned model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

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
        /// Number of checkpoints saved during training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// Batch size used for training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Type of training used (full or LoRA)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>))]
        public global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// Method of training used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>))]
        public global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? TrainingMethod { get; set; }

        /// <summary>
        /// Learning rate used for training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// Learning rate scheduler configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler")]
        public global::Together.LRScheduler? LrScheduler { get; set; }

        /// <summary>
        /// Ratio of warmup steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_ratio")]
        public float? WarmupRatio { get; set; }

        /// <summary>
        /// Maximum gradient norm for clipping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_grad_norm")]
        public float? MaxGradNorm { get; set; }

        /// <summary>
        /// Weight decay value used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public float? WeightDecay { get; set; }

        /// <summary>
        /// Random seed used for training. Integer when set; null if not stored (e.g. legacy jobs) or no explicit seed was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// Weights &amp; Biases project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_project_name")]
        public string? WandbProjectName { get; set; }

        /// <summary>
        /// Weights &amp; Biases run name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_name")]
        public string? WandbName { get; set; }

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
        /// Progress information for the fine-tuning job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::Together.FineTuneProgress? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponseTruncated" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the fine-tune job
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAt">
        /// Creation timestamp of the fine-tune job
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp of the fine-tune job
        /// </param>
        /// <param name="startedAt">
        /// Start timestamp of the current stage of the fine-tune job
        /// </param>
        /// <param name="userId">
        /// Identifier for the user who created the job
        /// </param>
        /// <param name="ownerAddress">
        /// Owner address information
        /// </param>
        /// <param name="totalPrice">
        /// Total price for the fine-tuning job
        /// </param>
        /// <param name="tokenCount">
        /// Count of tokens processed
        /// </param>
        /// <param name="events">
        /// Events related to this fine-tune job
        /// </param>
        /// <param name="trainingFile">
        /// File-ID of the training file
        /// </param>
        /// <param name="validationFile">
        /// File-ID of the validation file
        /// </param>
        /// <param name="packing">
        /// Whether sequence packing is being used for training.
        /// </param>
        /// <param name="maxSeqLength">
        /// Maximum sequence length to use for training. If not specified, the maximum allowed for the model and training method will be used.
        /// </param>
        /// <param name="model">
        /// Base model used for fine-tuning
        /// </param>
        /// <param name="modelOutputName"></param>
        /// <param name="suffix">
        /// Suffix added to the fine-tuned model name
        /// </param>
        /// <param name="nEpochs">
        /// Number of training epochs
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations during training
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of checkpoints saved during training
        /// </param>
        /// <param name="batchSize">
        /// Batch size used for training
        /// </param>
        /// <param name="trainingType">
        /// Type of training used (full or LoRA)
        /// </param>
        /// <param name="trainingMethod">
        /// Method of training used
        /// </param>
        /// <param name="learningRate">
        /// Learning rate used for training
        /// </param>
        /// <param name="lrScheduler">
        /// Learning rate scheduler configuration
        /// </param>
        /// <param name="warmupRatio">
        /// Ratio of warmup steps
        /// </param>
        /// <param name="maxGradNorm">
        /// Maximum gradient norm for clipping
        /// </param>
        /// <param name="weightDecay">
        /// Weight decay value used
        /// </param>
        /// <param name="randomSeed">
        /// Random seed used for training. Integer when set; null if not stored (e.g. legacy jobs) or no explicit seed was recorded.
        /// </param>
        /// <param name="wandbProjectName">
        /// Weights &amp; Biases project name
        /// </param>
        /// <param name="wandbName">
        /// Weights &amp; Biases run name
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
        /// <param name="progress">
        /// Progress information for the fine-tuning job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuneResponseTruncated(
            string id,
            global::Together.FinetuneJobStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? startedAt,
            string? userId,
            string? ownerAddress,
            int? totalPrice,
            int? tokenCount,
            global::System.Collections.Generic.IList<global::Together.FineTuneEvent>? events,
            string? trainingFile,
            string? validationFile,
            bool? packing,
            int? maxSeqLength,
            string? model,
            string? modelOutputName,
            string? suffix,
            int? nEpochs,
            int? nEvals,
            int? nCheckpoints,
            int? batchSize,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType,
            global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? trainingMethod,
            float? learningRate,
            global::Together.LRScheduler? lrScheduler,
            float? warmupRatio,
            float? maxGradNorm,
            float? weightDecay,
            int? randomSeed,
            string? wandbProjectName,
            string? wandbName,
            string? fromCheckpoint,
            string? fromHfModel,
            string? hfModelRevision,
            global::Together.FineTuneProgress? progress)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.UserId = userId;
            this.OwnerAddress = ownerAddress;
            this.TotalPrice = totalPrice;
            this.TokenCount = tokenCount;
            this.Events = events;
            this.TrainingFile = trainingFile;
            this.ValidationFile = validationFile;
            this.Packing = packing;
            this.MaxSeqLength = maxSeqLength;
            this.Model = model;
            this.ModelOutputName = modelOutputName;
            this.Suffix = suffix;
            this.NEpochs = nEpochs;
            this.NEvals = nEvals;
            this.NCheckpoints = nCheckpoints;
            this.BatchSize = batchSize;
            this.TrainingType = trainingType;
            this.TrainingMethod = trainingMethod;
            this.LearningRate = learningRate;
            this.LrScheduler = lrScheduler;
            this.WarmupRatio = warmupRatio;
            this.MaxGradNorm = maxGradNorm;
            this.WeightDecay = weightDecay;
            this.RandomSeed = randomSeed;
            this.WandbProjectName = wandbProjectName;
            this.WandbName = wandbName;
            this.FromCheckpoint = fromCheckpoint;
            this.FromHfModel = fromHfModel;
            this.HfModelRevision = hfModelRevision;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponseTruncated" /> class.
        /// </summary>
        public FinetuneResponseTruncated()
        {
        }
    }
}