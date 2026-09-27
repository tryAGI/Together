#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Stop model resources<br/>
        /// Stops the model resource and releases its allocated compute. If active training sessions are attached, the request fails unless `force=true`. A forced stop also stops all attached training sessions.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource
        /// </param>
        /// <param name="force">
        /// When true, also stop all attached training sessions. When false, the request fails if any training sessions are active.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlModelResources> StopModelResourcesAsync(
            string modelResourcesId,
            bool? force = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop model resources<br/>
        /// Stops the model resource and releases its allocated compute. If active training sessions are attached, the request fails unless `force=true`. A forced stop also stops all attached training sessions.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource
        /// </param>
        /// <param name="force">
        /// When true, also stop all attached training sessions. When false, the request fails if any training sessions are active.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlModelResources>> StopModelResourcesAsResponseAsync(
            string modelResourcesId,
            bool? force = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}