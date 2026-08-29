#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// Update an endpoint<br/>
        /// Updates mutable endpoint fields such as its endpoint string, visibility, or deployment traffic split. Use `updateMask` to select fields explicitly and `etag` in the request body for optimistic concurrency.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="updateMask">
        /// Fields to update. If not set, the fields populated are updated.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeEndpoint> EndpointServiceUpdateEndpointAsync(
            string projectId,
            string id,

            global::Together.DeEndpointUpdate request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an endpoint<br/>
        /// Updates mutable endpoint fields such as its endpoint string, visibility, or deployment traffic split. Use `updateMask` to select fields explicitly and `etag` in the request body for optimistic concurrency.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="updateMask">
        /// Fields to update. If not set, the fields populated are updated.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeEndpoint>> EndpointServiceUpdateEndpointAsResponseAsync(
            string projectId,
            string id,

            global::Together.DeEndpointUpdate request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an endpoint<br/>
        /// Updates mutable endpoint fields such as its endpoint string, visibility, or deployment traffic split. Use `updateMask` to select fields explicitly and `etag` in the request body for optimistic concurrency.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="updateMask">
        /// Fields to update. If not set, the fields populated are updated.
        /// </param>
        /// <param name="name">
        /// Updated endpoint string.
        /// </param>
        /// <param name="etag">
        /// Current endpoint version. The update is rejected if this value no longer matches.
        /// </param>
        /// <param name="trafficSplit">
        /// Replacement live traffic split. Use an empty list to stop routing live traffic.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeEndpoint> EndpointServiceUpdateEndpointAsync(
            string projectId,
            string id,
            string? updateMask = default,
            string? name = default,
            string? etag = default,
            global::System.Collections.Generic.IList<global::Together.DeTrafficSplitEntry>? trafficSplit = default,
            global::Together.DeEndpointUpdateVisibility? visibility = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}