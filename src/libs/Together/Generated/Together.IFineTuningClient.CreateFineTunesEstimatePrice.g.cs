#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Estimate price<br/>
        /// Estimate the price of a fine-tuning job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.CreateFineTunesEstimatePriceResponse> CreateFineTunesEstimatePriceAsync(

            global::Together.CreateFineTunesEstimatePriceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate price<br/>
        /// Estimate the price of a fine-tuning job.
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
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="trainingMethod">
        /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.
        /// </param>
        /// <param name="trainingType">
        /// The training type to use. If not provided, the job will default to LoRA training type.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fromCheckpoint">
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format is `{$JOB_ID}` or `{$OUTPUT_MODEL_NAME}` or `{$JOB_ID}:{$STEP}` or `{$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional; without it, the final checkpoint will be used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.CreateFineTunesEstimatePriceResponse> CreateFineTunesEstimatePriceAsync(
            string trainingFile,
            string? validationFile = default,
            string? model = default,
            int? nEpochs = default,
            int? nEvals = default,
            global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? trainingMethod = default,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType = default,
            string? fromCheckpoint = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}