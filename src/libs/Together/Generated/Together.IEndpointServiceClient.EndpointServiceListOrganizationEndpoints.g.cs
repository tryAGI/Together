#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// List organization endpoints<br/>
        /// Lists endpoints shared with every project in the specified organization. Project-private and public endpoints are not included.
        /// </summary>
        /// <param name="organizationId">
        /// Organization identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous list response.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for the results. Supports `created_at` or `updated_at`, optionally followed by `asc` or `desc`.
        /// </param>
        /// <param name="filter">
        /// Filter expression using `name`, `created_at`, or `updated_at` with comparison operators and AND/OR/NOT; timestamps must be RFC 3339 strings. `name` supports substring matching with `:` and prefix/suffix wildcards with `*`, and must be a bare endpoint name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListEndpointsResponse> EndpointServiceListOrganizationEndpointsAsync(
            string organizationId,
            int? limit = default,
            string? after = default,
            string? orderBy = default,
            string? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization endpoints<br/>
        /// Lists endpoints shared with every project in the specified organization. Project-private and public endpoints are not included.
        /// </summary>
        /// <param name="organizationId">
        /// Organization identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous list response.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for the results. Supports `created_at` or `updated_at`, optionally followed by `asc` or `desc`.
        /// </param>
        /// <param name="filter">
        /// Filter expression using `name`, `created_at`, or `updated_at` with comparison operators and AND/OR/NOT; timestamps must be RFC 3339 strings. `name` supports substring matching with `:` and prefix/suffix wildcards with `*`, and must be a bare endpoint name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListEndpointsResponse>> EndpointServiceListOrganizationEndpointsAsResponseAsync(
            string organizationId,
            int? limit = default,
            string? after = default,
            string? orderBy = default,
            string? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}