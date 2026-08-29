#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// List endpoints<br/>
        /// Lists the dedicated inference endpoints owned by the specified project.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of endpoints to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="after">
        /// Cursor from a previous response.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for the results. Supports `created_at` or `updated_at`, optionally followed by `asc` or `desc`.
        /// </param>
        /// <param name="filter">
        /// Filter expression using `name`, `created_at`, or `updated_at` with comparison operators and AND/OR/NOT; timestamps must be RFC 3339 strings. `name` supports substring matching with `:` and prefix/suffix wildcards with `*`, and accepts a bare endpoint name or `&lt;project_slug&gt;/&lt;endpoint_name&gt;`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListEndpointsResponse> EndpointServiceListEndpointsAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            string? orderBy = default,
            string? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List endpoints<br/>
        /// Lists the dedicated inference endpoints owned by the specified project.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of endpoints to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="after">
        /// Cursor from a previous response.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for the results. Supports `created_at` or `updated_at`, optionally followed by `asc` or `desc`.
        /// </param>
        /// <param name="filter">
        /// Filter expression using `name`, `created_at`, or `updated_at` with comparison operators and AND/OR/NOT; timestamps must be RFC 3339 strings. `name` supports substring matching with `:` and prefix/suffix wildcards with `*`, and accepts a bare endpoint name or `&lt;project_slug&gt;/&lt;endpoint_name&gt;`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListEndpointsResponse>> EndpointServiceListEndpointsAsResponseAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            string? orderBy = default,
            string? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}