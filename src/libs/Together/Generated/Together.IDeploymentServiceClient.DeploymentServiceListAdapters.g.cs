#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// List deployment adapters<br/>
        /// Lists LoRA adapters attached to a deployment with per-cluster load state.
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
        /// <param name="limit">
        /// Maximum number of adapters to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous adapter list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// adapters = client.endpoints.adapters.list(<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// for adapter in adapters:<br/>
        ///     print(adapter.id, adapter.adapter_model_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeListAdaptersResponse> DeploymentServiceListAdaptersAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List deployment adapters<br/>
        /// Lists LoRA adapters attached to a deployment with per-cluster load state.
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
        /// <param name="limit">
        /// Maximum number of adapters to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous adapter list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// adapters = client.endpoints.adapters.list(<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// for adapter in adapters:<br/>
        ///     print(adapter.id, adapter.adapter_model_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListAdaptersResponse>> DeploymentServiceListAdaptersAsResponseAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}