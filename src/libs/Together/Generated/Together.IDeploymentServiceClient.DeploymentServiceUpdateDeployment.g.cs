#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Update a deployment<br/>
        /// Updates mutable deployment fields such as its model, configuration, autoscaling bounds, or LoRA support. Changes that affect serving may trigger asynchronous reprovisioning.
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
        /// <param name="updateMask">
        /// Fields to update. If not set, the fields populated on `deployment` are updated.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeDeployment> DeploymentServiceUpdateDeploymentAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeUpdateDeploymentRequest request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a deployment<br/>
        /// Updates mutable deployment fields such as its model, configuration, autoscaling bounds, or LoRA support. Changes that affect serving may trigger asynchronous reprovisioning.
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
        /// <param name="updateMask">
        /// Fields to update. If not set, the fields populated on `deployment` are updated.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeployment>> DeploymentServiceUpdateDeploymentAsResponseAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeUpdateDeploymentRequest request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a deployment<br/>
        /// Updates mutable deployment fields such as its model, configuration, autoscaling bounds, or LoRA support. Changes that affect serving may trigger asynchronous reprovisioning.
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
        /// <param name="updateMask">
        /// Fields to update. If not set, the fields populated on `deployment` are updated.
        /// </param>
        /// <param name="name">
        /// Updated endpoint string.
        /// </param>
        /// <param name="autoscaling">
        /// Updated autoscaling configuration.
        /// </param>
        /// <param name="etag">
        /// Current deployment version. The update is rejected if this value no longer matches.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeDeployment> DeploymentServiceUpdateDeploymentAsync(
            string projectId,
            string endpointId,
            string id,
            string? updateMask = default,
            string? name = default,
            global::Together.DeAutoscaling? autoscaling = default,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}