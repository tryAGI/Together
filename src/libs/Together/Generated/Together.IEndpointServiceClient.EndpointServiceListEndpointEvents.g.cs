#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// List endpoint events<br/>
        /// Lists an endpoint's audit and lifecycle events newest first. The feed combines endpoint changes with provisioning, scaling, readiness, rollout, and other events from deployments under the endpoint.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return. Max 10000, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous endpoint event list response.
        /// </param>
        /// <param name="types">
        /// Event types to include, such as `deployment.scaled` or `condition.set`. Combined with other filters using AND.
        /// </param>
        /// <param name="minLevel">
        /// Minimum severity. Omit to disable severity filtering.
        /// </param>
        /// <param name="since">
        /// Return only events at or after this time.
        /// </param>
        /// <param name="until">
        /// Return only events strictly before this time.
        /// </param>
        /// <param name="deploymentIds">
        /// Deployment IDs whose events should be included. Every ID must belong to the endpoint. Supplying this filter excludes endpoint-scoped events unless `SOURCE_KIND_ENDPOINT` is also included in `sourceKinds`.
        /// </param>
        /// <param name="sourceKinds">
        /// Resource kinds whose events should be included. Omit to include both endpoint- and deployment-scoped events.
        /// </param>
        /// <param name="subjectId">
        /// ID of a subject associated with the event, such as a rollout. Combined with other filters using AND.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListEndpointEventsResponse> EndpointServiceListEndpointEventsAsync(
            string projectId,
            string id,
            int? limit = default,
            string? after = default,
            global::System.Collections.Generic.IList<string>? types = default,
            global::Together.EndpointServiceListEndpointEventsMinLevel? minLevel = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>? sourceKinds = default,
            string? subjectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List endpoint events<br/>
        /// Lists an endpoint's audit and lifecycle events newest first. The feed combines endpoint changes with provisioning, scaling, readiness, rollout, and other events from deployments under the endpoint.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return. Max 10000, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous endpoint event list response.
        /// </param>
        /// <param name="types">
        /// Event types to include, such as `deployment.scaled` or `condition.set`. Combined with other filters using AND.
        /// </param>
        /// <param name="minLevel">
        /// Minimum severity. Omit to disable severity filtering.
        /// </param>
        /// <param name="since">
        /// Return only events at or after this time.
        /// </param>
        /// <param name="until">
        /// Return only events strictly before this time.
        /// </param>
        /// <param name="deploymentIds">
        /// Deployment IDs whose events should be included. Every ID must belong to the endpoint. Supplying this filter excludes endpoint-scoped events unless `SOURCE_KIND_ENDPOINT` is also included in `sourceKinds`.
        /// </param>
        /// <param name="sourceKinds">
        /// Resource kinds whose events should be included. Omit to include both endpoint- and deployment-scoped events.
        /// </param>
        /// <param name="subjectId">
        /// ID of a subject associated with the event, such as a rollout. Combined with other filters using AND.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListEndpointEventsResponse>> EndpointServiceListEndpointEventsAsResponseAsync(
            string projectId,
            string id,
            int? limit = default,
            string? after = default,
            global::System.Collections.Generic.IList<string>? types = default,
            global::Together.EndpointServiceListEndpointEventsMinLevel? minLevel = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>? sourceKinds = default,
            string? subjectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}