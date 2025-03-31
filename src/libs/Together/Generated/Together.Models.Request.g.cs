
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request
    {
        /// <summary>
        /// Number of training examples processed together (larger batches use more memory but may train faster)<br/>
        /// Default Value: 32
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// The beta parameter for DPO training. Only applicable when training_method is 'dpo'.<br/>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo_beta")]
        public float? DpoBeta { get; set; }

        /// <summary>
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format `{$JOB_ID}:{$STEP}` or `{$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional, without it the final checkpoint will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_checkpoint")]
        public string? FromCheckpoint { get; set; }

        /// <summary>
        /// Controls how quickly the model adapts to new information (too high may cause instability, too low may slow convergence)<br/>
        /// Default Value: 1E-05F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler")]
        public global::Together.LRScheduler? LrScheduler { get; set; }

        /// <summary>
        /// Max gradient norm to be used for gradient clipping. Set to 0 to disable.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_grad_norm")]
        public float? MaxGradNorm { get; set; }

        /// <summary>
        /// Name of the base model to run fine-tune job on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Number of intermediate model versions saved during training for evaluation<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// Suffix that will be added to your fine-tuned model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// Whether to mask the user messages in conversational data or prompts in instruction data.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_on_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.RequestTrainOnInputs?>))]
        public global::Together.OneOf<bool?, global::Together.RequestTrainOnInputs?>? TrainOnInputs { get; set; }

        /// <summary>
        /// File-ID of a training file uploaded to the Together API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.<br/>
        /// Default Value: sft
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RequestTrainingMethodJsonConverter))]
        public global::Together.RequestTrainingMethod? TrainingMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>))]
        public global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// File-ID of a validation file uploaded to the Together API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

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
        /// The Weights &amp; Biases name for your run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_name")]
        public string? WandbName { get; set; }

        /// <summary>
        /// The Weights &amp; Biases project for your run. If not specified, will use `together` as the project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_project_name")]
        public string? WandbProjectName { get; set; }

        /// <summary>
        /// The percent of steps at the start of training to linearly increase the learning rate.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_ratio")]
        public float? WarmupRatio { get; set; }

        /// <summary>
        /// Weight decay<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public float? WeightDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="batchSize">
        /// Number of training examples processed together (larger batches use more memory but may train faster)<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="dpoBeta">
        /// The beta parameter for DPO training. Only applicable when training_method is 'dpo'.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="fromCheckpoint">
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format `{$JOB_ID}:{$STEP}` or `{$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional, without it the final checkpoint will be used.
        /// </param>
        /// <param name="learningRate">
        /// Controls how quickly the model adapts to new information (too high may cause instability, too low may slow convergence)<br/>
        /// Default Value: 1E-05F
        /// </param>
        /// <param name="lrScheduler"></param>
        /// <param name="maxGradNorm">
        /// Max gradient norm to be used for gradient clipping. Set to 0 to disable.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of intermediate model versions saved during training for evaluation<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEpochs">
        /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="suffix">
        /// Suffix that will be added to your fine-tuned model name
        /// </param>
        /// <param name="trainOnInputs">
        /// Whether to mask the user messages in conversational data or prompts in instruction data.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="trainingFile">
        /// File-ID of a training file uploaded to the Together API
        /// </param>
        /// <param name="trainingMethod">
        /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.<br/>
        /// Default Value: sft
        /// </param>
        /// <param name="trainingType"></param>
        /// <param name="validationFile">
        /// File-ID of a validation file uploaded to the Together API
        /// </param>
        /// <param name="wandbApiKey">
        /// Integration key for tracking experiments and model metrics on W&amp;B platform
        /// </param>
        /// <param name="wandbBaseUrl">
        /// The base URL of a dedicated Weights &amp; Biases instance.
        /// </param>
        /// <param name="wandbName">
        /// The Weights &amp; Biases name for your run.
        /// </param>
        /// <param name="wandbProjectName">
        /// The Weights &amp; Biases project for your run. If not specified, will use `together` as the project name.
        /// </param>
        /// <param name="warmupRatio">
        /// The percent of steps at the start of training to linearly increase the learning rate.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="weightDecay">
        /// Weight decay<br/>
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request(
            string model,
            string trainingFile,
            int? batchSize,
            float? dpoBeta,
            string? fromCheckpoint,
            float? learningRate,
            global::Together.LRScheduler? lrScheduler,
            float? maxGradNorm,
            int? nCheckpoints,
            int? nEpochs,
            int? nEvals,
            string? suffix,
            global::Together.OneOf<bool?, global::Together.RequestTrainOnInputs?>? trainOnInputs,
            global::Together.RequestTrainingMethod? trainingMethod,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType,
            string? validationFile,
            string? wandbApiKey,
            string? wandbBaseUrl,
            string? wandbName,
            string? wandbProjectName,
            float? warmupRatio,
            float? weightDecay)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.BatchSize = batchSize;
            this.DpoBeta = dpoBeta;
            this.FromCheckpoint = fromCheckpoint;
            this.LearningRate = learningRate;
            this.LrScheduler = lrScheduler;
            this.MaxGradNorm = maxGradNorm;
            this.NCheckpoints = nCheckpoints;
            this.NEpochs = nEpochs;
            this.NEvals = nEvals;
            this.Suffix = suffix;
            this.TrainOnInputs = trainOnInputs;
            this.TrainingMethod = trainingMethod;
            this.TrainingType = trainingType;
            this.ValidationFile = validationFile;
            this.WandbApiKey = wandbApiKey;
            this.WandbBaseUrl = wandbBaseUrl;
            this.WandbName = wandbName;
            this.WandbProjectName = wandbProjectName;
            this.WarmupRatio = warmupRatio;
            this.WeightDecay = weightDecay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
        }
    }
}