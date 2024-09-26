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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponse> CreateFineTunesAsync(
            global::Together.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="trainingFile">
        /// File-ID of a training file uploaded to the Together API
        /// </param>
        /// <param name="validationFile">
        /// File-ID of a validation file uploaded to the Together API
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nEpochs">
        /// Number of epochs for fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of checkpoints to save during fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="batchSize">
        /// Batch size for fine-tuning<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="learningRate">
        /// Learning rate multiplier to use for training<br/>
        /// Default Value: 1E-05F
        /// </param>
        /// <param name="suffix">
        /// Suffix that will be added to your fine-tuned model name
        /// </param>
        /// <param name="wandbApiKey">
        /// API key for Weights &amp; Biases integration
        /// </param>
        /// <param name="lora">
        /// Whether to enable LoRA training. If not provided, full fine-tuning will be applied.
        /// </param>
        /// <param name="loraR">
        /// Rank for LoRA adapter weights<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="loraAlpha">
        /// The alpha value for LoRA adapter training.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="loraDropout">
        /// The dropout probability for Lora layers.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="loraTrainableModules">
        /// A list of LoRA trainable modules, separated by a comma<br/>
        /// Default Value: all-linear
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponse> CreateFineTunesAsync(
            string trainingFile,
            string model,
            string? validationFile = default,
            int? nEpochs = 1,
            int? nCheckpoints = 1,
            int? nEvals = 0,
            int? batchSize = 32,
            float? learningRate = 1E-05F,
            string? suffix = default,
            string? wandbApiKey = default,
            bool? lora = default,
            int? loraR = 8,
            int? loraAlpha = 8,
            float? loraDropout = 0F,
            string? loraTrainableModules = "all-linear",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}