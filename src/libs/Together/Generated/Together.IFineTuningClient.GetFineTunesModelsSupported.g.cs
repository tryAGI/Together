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
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// models = client.get("/fine-tunes/models/supported", cast_to=object)<br/>
        /// print(models)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GetFineTunesModelsSupportedResponse> GetFineTunesModelsSupportedAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List supported models<br/>
        /// List models supported for fine-tuning.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// models = client.get("/fine-tunes/models/supported", cast_to=object)<br/>
        /// print(models)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.GetFineTunesModelsSupportedResponse>> GetFineTunesModelsSupportedAsResponseAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}