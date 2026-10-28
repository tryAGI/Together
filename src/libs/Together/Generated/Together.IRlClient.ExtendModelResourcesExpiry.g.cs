#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Extend model resources expiry<br/>
        /// Keeps a ready model resource from stopping for inactivity for at least the given number of seconds from now. It moves the resource's `expires_at` to at least that time, and never earlier. Every operation on the resource's sessions already keeps it up for `inactive_timeout` seconds, so use this only to stay up longer without operations, for example while you compute rewards. Fails if the resource is not ready.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// resource = client.post_training.model_resources.extend_expiry(<br/>
        ///     "&lt;MODEL_RESOURCES_ID&gt;",<br/>
        ///     seconds=7200,<br/>
        /// )<br/>
        /// print(resource.status, resource.expires_at)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RlModelResources> ExtendModelResourcesExpiryAsync(

            global::Together.RlExtendModelResourcesExpiryRequest request,
            string modelResourcesId = "false",
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extend model resources expiry<br/>
        /// Keeps a ready model resource from stopping for inactivity for at least the given number of seconds from now. It moves the resource's `expires_at` to at least that time, and never earlier. Every operation on the resource's sessions already keeps it up for `inactive_timeout` seconds, so use this only to stay up longer without operations, for example while you compute rewards. Fails if the resource is not ready.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// resource = client.post_training.model_resources.extend_expiry(<br/>
        ///     "&lt;MODEL_RESOURCES_ID&gt;",<br/>
        ///     seconds=7200,<br/>
        /// )<br/>
        /// print(resource.status, resource.expires_at)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlModelResources>> ExtendModelResourcesExpiryAsResponseAsync(

            global::Together.RlExtendModelResourcesExpiryRequest request,
            string modelResourcesId = "false",
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extend model resources expiry<br/>
        /// Keeps a ready model resource from stopping for inactivity for at least the given number of seconds from now. It moves the resource's `expires_at` to at least that time, and never earlier. Every operation on the resource's sessions already keeps it up for `inactive_timeout` seconds, so use this only to stay up longer without operations, for example while you compute rewards. Fails if the resource is not ready.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seconds">
        /// Seconds from now the resource must not stop for inactivity.<br/>
        /// Example: 7200
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlModelResources> ExtendModelResourcesExpiryAsync(
            int seconds,
            string modelResourcesId = "false",
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}