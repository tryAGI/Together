#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// Delete an endpoint<br/>
        /// Permanently deletes an endpoint. Delete its deployments first; use `etag` to reject the request if the endpoint changed after it was read.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="etag">
        /// Etag for optimistic concurrency. If set, the delete is rejected if the current etag does not match.
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
        /// client.endpoints.delete("ep_abc123", project_id=project_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeDeleteResponse> EndpointServiceDeleteEndpointAsync(
            string projectId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an endpoint<br/>
        /// Permanently deletes an endpoint. Delete its deployments first; use `etag` to reject the request if the endpoint changed after it was read.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="etag">
        /// Etag for optimistic concurrency. If set, the delete is rejected if the current etag does not match.
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
        /// client.endpoints.delete("ep_abc123", project_id=project_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeleteResponse>> EndpointServiceDeleteEndpointAsResponseAsync(
            string projectId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}