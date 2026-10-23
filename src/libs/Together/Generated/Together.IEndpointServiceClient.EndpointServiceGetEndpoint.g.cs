#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// Get an endpoint<br/>
        /// Retrieves an endpoint and lightweight summaries of the deployments attached to it.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
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
        /// endpoint = client.endpoints.retrieve(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(endpoint.name, endpoint.traffic_split)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeEndpoint> EndpointServiceGetEndpointAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an endpoint<br/>
        /// Retrieves an endpoint and lightweight summaries of the deployments attached to it.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
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
        /// endpoint = client.endpoints.retrieve(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(endpoint.name, endpoint.traffic_split)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeEndpoint>> EndpointServiceGetEndpointAsResponseAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}