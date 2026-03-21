#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Create job<br/>
        /// Create a fine-tuning job with the provided model and training data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.fine_tuning.create(<br/>
        ///     model="meta-llama/Meta-Llama-3.1-8B-Instruct-Reference",<br/>
        ///     training_file="file-id"<br/>
        /// )<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponseTruncated> CreateFineTunesAsync(

            global::Together.CreateFineTunesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create job<br/>
        /// Create a fine-tuning job with the provided model and training data.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponseTruncated> CreateFineTunesAsync(
            string trainingFile,
            string model,
            string? validationFile = default,
            int? nEpochs = default,
            int? nCheckpoints = default,
            int? nEvals = default,
            global::Together.OneOf<int?, global::Together.CreateFineTunesRequestBatchSize?>? batchSize = default,
            float? learningRate = default,
            global::Together.LRScheduler? lrScheduler = default,
            float? warmupRatio = default,
            float? maxGradNorm = default,
            float? weightDecay = default,
            int? randomSeed = default,
            string? suffix = default,
            string? wandbApiKey = default,
            string? wandbBaseUrl = default,
            string? wandbProjectName = default,
            string? wandbName = default,
            string? wandbEntity = default,
            global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? trainingMethod = default,
            global::Together.AnyOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType = default,
            global::Together.MultimodalParams? multimodalParams = default,
            string? fromCheckpoint = default,
            string? fromHfModel = default,
            string? hfModelRevision = default,
            string? hfApiToken = default,
            string? hfOutputRepoName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}