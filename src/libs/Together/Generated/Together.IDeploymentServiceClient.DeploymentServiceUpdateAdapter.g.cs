#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Update a deployment adapter<br/>
        /// Updates the pinned revision of an adapter attachment by its `dad_` id using its row-level etag for optimistic concurrency.
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
        /// <param name="id">
        /// Adapter attachment `dad_` id from a prior add, update, get, or list response.
        /// </param>
        /// <param name="request"></param>
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
        /// # Read the attachment first: updating it requires its current etag.<br/>
        /// adapter = client.endpoints.adapters.retrieve(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        /// )<br/>
        /// updated = client.endpoints.adapters.update(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        ///     adapter_revision_id="rv_abc123",<br/>
        ///     etag=adapter.etag,<br/>
        /// )<br/>
        /// print(updated)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeAdapterEntry> DeploymentServiceUpdateAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,

            global::Together.DeUpdateAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a deployment adapter<br/>
        /// Updates the pinned revision of an adapter attachment by its `dad_` id using its row-level etag for optimistic concurrency.
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
        /// <param name="id">
        /// Adapter attachment `dad_` id from a prior add, update, get, or list response.
        /// </param>
        /// <param name="request"></param>
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
        /// # Read the attachment first: updating it requires its current etag.<br/>
        /// adapter = client.endpoints.adapters.retrieve(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        /// )<br/>
        /// updated = client.endpoints.adapters.update(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        ///     adapter_revision_id="rv_abc123",<br/>
        ///     etag=adapter.etag,<br/>
        /// )<br/>
        /// print(updated)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeAdapterEntry>> DeploymentServiceUpdateAdapterAsResponseAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,

            global::Together.DeUpdateAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a deployment adapter<br/>
        /// Updates the pinned revision of an adapter attachment by its `dad_` id using its row-level etag for optimistic concurrency.
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
        /// <param name="id">
        /// Adapter attachment `dad_` id from a prior add, update, get, or list response.
        /// </param>
        /// <param name="adapterRevisionId">
        /// New adapter revision to pin.
        /// </param>
        /// <param name="etag">
        /// Row-level etag from a prior AddAdapter, UpdateAdapter, GetAdapter, or ListAdapters response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeAdapterEntry> DeploymentServiceUpdateAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,
            string adapterRevisionId,
            string etag,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}