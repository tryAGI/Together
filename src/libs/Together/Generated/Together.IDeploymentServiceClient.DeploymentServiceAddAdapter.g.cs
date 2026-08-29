#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Add a deployment adapter<br/>
        /// Attaches a LoRA adapter to a deployment. If the deployment is at adapter capacity, force can evict the oldest adapter.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="deploymentId">
        /// Deployment identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeAdapterEntry> DeploymentServiceAddAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,

            global::Together.DeAddAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a deployment adapter<br/>
        /// Attaches a LoRA adapter to a deployment. If the deployment is at adapter capacity, force can evict the oldest adapter.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="deploymentId">
        /// Deployment identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeAdapterEntry>> DeploymentServiceAddAdapterAsResponseAsync(
            string projectId,
            string endpointId,
            string deploymentId,

            global::Together.DeAddAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a deployment adapter<br/>
        /// Attaches a LoRA adapter to a deployment. If the deployment is at adapter capacity, force can evict the oldest adapter.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="deploymentId">
        /// Deployment identifier.
        /// </param>
        /// <param name="adapterModelId">
        /// Adapter model identifier to attach.
        /// </param>
        /// <param name="adapterRevisionId">
        /// Optional adapter revision to pin. If omitted, the latest revision is resolved at request time.
        /// </param>
        /// <param name="force">
        /// Whether to evict the oldest adapter if the deployment is at adapter capacity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeAdapterEntry> DeploymentServiceAddAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string adapterModelId,
            string? adapterRevisionId = default,
            bool? force = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}