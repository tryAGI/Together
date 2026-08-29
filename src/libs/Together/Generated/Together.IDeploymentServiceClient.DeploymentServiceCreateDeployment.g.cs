#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Create a deployment<br/>
        /// Creates a model deployment under an endpoint. The deployment provisions asynchronously; monitor its status before routing live traffic to it.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project that owns the endpoint.
        /// </param>
        /// <param name="endpointId">
        /// ID of the endpoint that will contain the deployment.
        /// </param>
        /// <param name="validateOnly">
        /// When true, validates the request without creating or provisioning a deployment.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeDeployment> DeploymentServiceCreateDeploymentAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateDeploymentRequest request,
            bool? validateOnly = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a deployment<br/>
        /// Creates a model deployment under an endpoint. The deployment provisions asynchronously; monitor its status before routing live traffic to it.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project that owns the endpoint.
        /// </param>
        /// <param name="endpointId">
        /// ID of the endpoint that will contain the deployment.
        /// </param>
        /// <param name="validateOnly">
        /// When true, validates the request without creating or provisioning a deployment.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeployment>> DeploymentServiceCreateDeploymentAsResponseAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateDeploymentRequest request,
            bool? validateOnly = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a deployment<br/>
        /// Creates a model deployment under an endpoint. The deployment provisions asynchronously; monitor its status before routing live traffic to it.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project that owns the endpoint.
        /// </param>
        /// <param name="endpointId">
        /// ID of the endpoint that will contain the deployment.
        /// </param>
        /// <param name="validateOnly">
        /// When true, validates the request without creating or provisioning a deployment.
        /// </param>
        /// <param name="name">
        /// Name for the deployment within its endpoint. Returned as a fully-qualified endpoint string.
        /// </param>
        /// <param name="modelId">
        /// Deprecated. Use `model`. Model identifier to serve, accepted when `model` is unset.
        /// </param>
        /// <param name="modelRevisionId">
        /// Deprecated. Use `model` with a /revisions/{revisionId} segment. If omitted, the latest revision is resolved at creation.
        /// </param>
        /// <param name="configId">
        /// Deprecated. Use `config`. Config revision identifier to deploy, accepted when `config` is unset.
        /// </param>
        /// <param name="model">
        /// Model resource name in the form `projects/{projectId}/models/{modelId}[/revisions/{revisionId}]`. Omit the revision segment to pin the latest revision at creation time.
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration for the deployment.
        /// </param>
        /// <param name="config">
        /// Immutable config revision in the form `projects/{projectId}/configs/{configRevisionId}`. The config must be compatible with the model.
        /// </param>
        /// <param name="enableLora">
        /// Enables dynamic loading of LoRA adapters on the deployment.
        /// </param>
        /// <param name="placement">
        /// Placement policy to use when scheduling the deployment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeDeployment> DeploymentServiceCreateDeploymentAsync(
            string projectId,
            string endpointId,
            string name,
            global::Together.DeAutoscaling autoscaling,
            bool? validateOnly = default,
            string? modelId = default,
            string? modelRevisionId = default,
            string? configId = default,
            string? model = default,
            string? config = default,
            bool? enableLora = default,
            global::Together.DePlacement? placement = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}