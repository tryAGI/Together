#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Get model resources<br/>
        /// Gets a model resource by its ID and returns its details.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// resource = client.post_training.model_resources.retrieve(<br/>
        ///     "&lt;MODEL_RESOURCES_ID&gt;",<br/>
        /// )<br/>
        /// print(resource.status, resource.compute_config)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RlModelResources> GetModelResourcesAsync(
            string modelResourcesId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get model resources<br/>
        /// Gets a model resource by its ID and returns its details.
        /// </summary>
        /// <param name="modelResourcesId">
        /// ID of the model resource
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// resource = client.post_training.model_resources.retrieve(<br/>
        ///     "&lt;MODEL_RESOURCES_ID&gt;",<br/>
        /// )<br/>
        /// print(resource.status, resource.compute_config)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlModelResources>> GetModelResourcesAsResponseAsync(
            string modelResourcesId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}