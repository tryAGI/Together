#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get model limits<br/>
        /// Get model limits for a specific fine-tuning model.
        /// </summary>
        /// <param name="modelName">
        /// The model name to get limits for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// curl "https://api.together.ai/v1/fine-tunes/models/limits?model_name=meta-llama/Meta-Llama-3.1-8B-Instruct-Reference" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FineTuneModelLimits> GetFineTunesModelsLimitsAsync(
            string modelName,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}