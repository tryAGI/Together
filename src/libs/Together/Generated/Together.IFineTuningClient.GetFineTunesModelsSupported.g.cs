#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List supported models<br/>
        /// List models supported for fine-tuning.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// curl "https://api.together.ai/v1/fine-tunes/models/supported" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GetFineTunesModelsSupportedResponse> GetFineTunesModelsSupportedAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}