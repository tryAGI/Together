#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponse> CreateFineTunesAsync(
            global::Together.Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
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
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format `{$JOB_ID/$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional, without it the final checkpoint will be used.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponse> CreateFineTunesAsync(
            string model,
            string trainingFile,
            int? batchSize = default,
            float? dpoBeta = default,
            string? fromCheckpoint = default,
            float? learningRate = default,
            global::Together.LRScheduler? lrScheduler = default,
            float? maxGradNorm = default,
            int? nCheckpoints = default,
            int? nEpochs = default,
            int? nEvals = default,
            string? suffix = default,
            global::Together.OneOf<bool?, global::Together.RequestTrainOnInputs?>? trainOnInputs = default,
            global::Together.RequestTrainingMethod? trainingMethod = default,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType = default,
            string? validationFile = default,
            string? wandbApiKey = default,
            string? wandbBaseUrl = default,
            string? wandbName = default,
            string? wandbProjectName = default,
            float? warmupRatio = default,
            float? weightDecay = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}