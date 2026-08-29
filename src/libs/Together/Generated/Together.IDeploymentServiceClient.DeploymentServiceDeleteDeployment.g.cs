#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Delete a deployment<br/>
        /// Permanently deletes a deployment from its endpoint. Remove the deployment from live traffic first; use `etag` to reject the request if it changed after it was read.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Deployment identifier.
        /// </param>
        /// <param name="etag">
        /// Etag for optimistic concurrency. If set, the delete is rejected if the current etag does not match.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeDeleteResponse> DeploymentServiceDeleteDeploymentAsync(
            string projectId,
            string endpointId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a deployment<br/>
        /// Permanently deletes a deployment from its endpoint. Remove the deployment from live traffic first; use `etag` to reject the request if it changed after it was read.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Deployment identifier.
        /// </param>
        /// <param name="etag">
        /// Etag for optimistic concurrency. If set, the delete is rejected if the current etag does not match.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeleteResponse>> DeploymentServiceDeleteDeploymentAsResponseAsync(
            string projectId,
            string endpointId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}