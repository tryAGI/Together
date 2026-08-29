#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Stop model resources<br/>
        /// Stops every session attached to the resource and tears down its GPU pods.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource
        /// </param>
        /// <param name="force">
        /// Stop the resource even if active training sessions are attached<br/>
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
        /// Stops every session attached to the resource and tears down its GPU pods.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource
        /// </param>
        /// <param name="force">
        /// Stop the resource even if active training sessions are attached<br/>
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