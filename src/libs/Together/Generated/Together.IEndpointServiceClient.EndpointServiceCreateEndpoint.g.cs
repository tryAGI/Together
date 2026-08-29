#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// Create an endpoint<br/>
        /// Creates a stable, inference-addressable endpoint. Add one or more deployments and configure its traffic split before sending inference requests to the endpoint name.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeEndpoint> EndpointServiceCreateEndpointAsync(
            string projectId,

            global::Together.DeCreateEndpointRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an endpoint<br/>
        /// Creates a stable, inference-addressable endpoint. Add one or more deployments and configure its traffic split before sending inference requests to the endpoint name.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeEndpoint>> EndpointServiceCreateEndpointAsResponseAsync(
            string projectId,

            global::Together.DeCreateEndpointRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an endpoint<br/>
        /// Creates a stable, inference-addressable endpoint. Add one or more deployments and configure its traffic split before sending inference requests to the endpoint name.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="name">
        /// Inference-addressable endpoint name to create.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeEndpoint> EndpointServiceCreateEndpointAsync(
            string projectId,
            string name,
            global::Together.DeCreateEndpointRequestVisibility? visibility = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}