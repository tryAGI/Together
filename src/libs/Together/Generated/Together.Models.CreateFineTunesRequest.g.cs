
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTunesRequest
    {
        /// <summary>
        /// File-ID of a training file uploaded to the Together API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// File-ID of a validation file uploaded to the Together API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// Whether to use sequence packing for training.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packing")]
        public bool? Packing { get; set; }

        /// <summary>
        /// Name of the base model to run fine-tune job on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// Number of intermediate model versions saved during training for evaluation<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// Number of training examples processed together (larger batches use more memory but may train faster). Defaults to "max". We use training optimizations like packing, so the effective batch size may be different than the value you set.<br/>
        /// Default Value: max
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.CreateFineTunesRequestBatchSize?>))]
        public global::Together.OneOf<int?, global::Together.CreateFineTunesRequestBatchSize?>? BatchSize { get; set; }

        /// <summary>
        /// Controls how quickly the model adapts to new information (too high may cause instability, too low may slow convergence)<br/>
        /// Default Value: 0.00001
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// The learning rate scheduler to use. It specifies how the learning rate is adjusted during training.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler")]
        public global::Together.LRScheduler? LrScheduler { get; set; }

        /// <summary>
        /// The percent of steps at the start of training to linearly increase the learning rate.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_ratio")]
        public float? WarmupRatio { get; set; }

        /// <summary>
        /// Max gradient norm to be used for gradient clipping. Set to 0 to disable.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_grad_norm")]
        public float? MaxGradNorm { get; set; }

        /// <summary>
        /// Weight decay. Regularization parameter for the optimizer.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public float? WeightDecay { get; set; }

        /// <summary>
        /// Random seed for reproducible training. When set, the same seed produces the same run (e.g. data shuffle, init). If omitted or null, the server applies its default seed (e.g. 42).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// Suffix that will be added to your fine-tuned model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// Integration key for tracking experiments and model metrics on W&amp;B platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_api_key")]
        public string? WandbApiKey { get; set; }

        /// <summary>
        /// The base URL of a dedicated Weights &amp; Biases instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_base_url")]
        public string? WandbBaseUrl { get; set; }

        /// <summary>
        /// The Weights &amp; Biases project for your run. If not specified, will use `together` as the project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_project_name")]
        public string? WandbProjectName { get; set; }

        /// <summary>
        /// The Weights &amp; Biases name for your run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_name")]
        public string? WandbName { get; set; }

        /// <summary>
        /// The Weights &amp; Biases entity for your run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_entity")]
        public string? WandbEntity { get; set; }

        /// <summary>
        /// Whether to mask the user messages in conversational data or prompts in instruction data.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_on_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>))]
        public global::Together.OneOf<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>? TrainOnInputs { get; set; }

        /// <summary>
        /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>))]
        public global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? TrainingMethod { get; set; }

        /// <summary>
        /// The training type to use. If not provided, the job will default to LoRA training type.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>))]
        public global::Together.AnyOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multimodal_params")]
        public global::Together.MultimodalParams? MultimodalParams { get; set; }

        /// <summary>
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format is `{$JOB_ID}` or `{$OUTPUT_MODEL_NAME}` or `{$JOB_ID}:{$STEP}` or `{$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional; without it, the final checkpoint will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_checkpoint")]
        public string? FromCheckpoint { get; set; }

        /// <summary>
        /// The Hugging Face Hub repo to start training from. Should be as close as possible to the base model (specified by the `model` argument) in terms of architecture and size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_hf_model")]
        public string? FromHfModel { get; set; }

        /// <summary>
        /// The revision of the Hugging Face Hub model to continue training from. E.g., hf_model_revision=main (default, used if the argument is not provided) or hf_model_revision='607a30d783dfa663caf39e06633721c8d4cfcd7e' (specific commit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_model_revision")]
        public string? HfModelRevision { get; set; }

        /// <summary>
        /// The API token for the Hugging Face Hub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_api_token")]
        public string? HfApiToken { get; set; }

        /// <summary>
        /// The name of the Hugging Face repository to upload the fine-tuned model to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_output_repo_name")]
        public string? HfOutputRepoName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTunesRequest" /> class.
        /// </summary>
        /// <param name="trainingFile">
        /// File-ID of a training file uploaded to the Together API
        /// </param>
        /// <param name="validationFile">
        /// File-ID of a validation file uploaded to the Together API
        /// </param>
        /// <param name="packing">
        /// Whether to use sequence packing for training.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nEpochs">
        /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of intermediate model versions saved during training for evaluation<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="batchSize">
        /// Number of training examples processed together (larger batches use more memory but may train faster). Defaults to "max". We use training optimizations like packing, so the effective batch size may be different than the value you set.<br/>
        /// Default Value: max
        /// </param>
        /// <param name="learningRate">
        /// Controls how quickly the model adapts to new information (too high may cause instability, too low may slow convergence)<br/>
        /// Default Value: 0.00001
        /// </param>
        /// <param name="lrScheduler">
        /// The learning rate scheduler to use. It specifies how the learning rate is adjusted during training.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="warmupRatio">
        /// The percent of steps at the start of training to linearly increase the learning rate.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="maxGradNorm">
        /// Max gradient norm to be used for gradient clipping. Set to 0 to disable.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="weightDecay">
        /// Weight decay. Regularization parameter for the optimizer.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="randomSeed">
        /// Random seed for reproducible training. When set, the same seed produces the same run (e.g. data shuffle, init). If omitted or null, the server applies its default seed (e.g. 42).
        /// </param>
        /// <param name="suffix">
        /// Suffix that will be added to your fine-tuned model name
        /// </param>
        /// <param name="wandbApiKey">
        /// Integration key for tracking experiments and model metrics on W&amp;B platform
        /// </param>
        /// <param name="wandbBaseUrl">
        /// The base URL of a dedicated Weights &amp; Biases instance.
        /// </param>
        /// <param name="wandbProjectName">
        /// The Weights &amp; Biases project for your run. If not specified, will use `together` as the project name.
        /// </param>
        /// <param name="wandbName">
        /// The Weights &amp; Biases name for your run.
        /// </param>
        /// <param name="wandbEntity">
        /// The Weights &amp; Biases entity for your run.
        /// </param>
        /// <param name="trainingMethod">
        /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.
        /// </param>
        /// <param name="trainingType">
        /// The training type to use. If not provided, the job will default to LoRA training type.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="multimodalParams"></param>
        /// <param name="fromCheckpoint">
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format is `{$JOB_ID}` or `{$OUTPUT_MODEL_NAME}` or `{$JOB_ID}:{$STEP}` or `{$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional; without it, the final checkpoint will be used.
        /// </param>
        /// <param name="fromHfModel">
        /// The Hugging Face Hub repo to start training from. Should be as close as possible to the base model (specified by the `model` argument) in terms of architecture and size.
        /// </param>
        /// <param name="hfModelRevision">
        /// The revision of the Hugging Face Hub model to continue training from. E.g., hf_model_revision=main (default, used if the argument is not provided) or hf_model_revision='607a30d783dfa663caf39e06633721c8d4cfcd7e' (specific commit).
        /// </param>
        /// <param name="hfApiToken">
        /// The API token for the Hugging Face Hub.
        /// </param>
        /// <param name="hfOutputRepoName">
        /// The name of the Hugging Face repository to upload the fine-tuned model to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFineTunesRequest(
            string trainingFile,
            string model,
            string? validationFile,
            bool? packing,
            int? nEpochs,
            int? nCheckpoints,
            int? nEvals,
            global::Together.OneOf<int?, global::Together.CreateFineTunesRequestBatchSize?>? batchSize,
            float? learningRate,
            global::Together.LRScheduler? lrScheduler,
            float? warmupRatio,
            float? maxGradNorm,
            float? weightDecay,
            int? randomSeed,
            string? suffix,
            string? wandbApiKey,
            string? wandbBaseUrl,
            string? wandbProjectName,
            string? wandbName,
            string? wandbEntity,
            global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? trainingMethod,
            global::Together.AnyOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType,
            global::Together.MultimodalParams? multimodalParams,
            string? fromCheckpoint,
            string? fromHfModel,
            string? hfModelRevision,
            string? hfApiToken,
            string? hfOutputRepoName)
        {
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ValidationFile = validationFile;
            this.Packing = packing;
            this.NEpochs = nEpochs;
            this.NCheckpoints = nCheckpoints;
            this.NEvals = nEvals;
            this.BatchSize = batchSize;
            this.LearningRate = learningRate;
            this.LrScheduler = lrScheduler;
            this.WarmupRatio = warmupRatio;
            this.MaxGradNorm = maxGradNorm;
            this.WeightDecay = weightDecay;
            this.RandomSeed = randomSeed;
            this.Suffix = suffix;
            this.WandbApiKey = wandbApiKey;
            this.WandbBaseUrl = wandbBaseUrl;
            this.WandbProjectName = wandbProjectName;
            this.WandbName = wandbName;
            this.WandbEntity = wandbEntity;
            this.TrainingMethod = trainingMethod;
            this.TrainingType = trainingType;
            this.MultimodalParams = multimodalParams;
            this.FromCheckpoint = fromCheckpoint;
            this.FromHfModel = fromHfModel;
            this.HfModelRevision = hfModelRevision;
            this.HfApiToken = hfApiToken;
            this.HfOutputRepoName = hfOutputRepoName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTunesRequest" /> class.
        /// </summary>
        public CreateFineTunesRequest()
        {
        }
    }
}