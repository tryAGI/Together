#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// List deployments<br/>
        /// Lists the deployments attached to an endpoint, including their model, configuration, scaling settings, placement, and current status.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project that owns the endpoint.
        /// </param>
        /// <param name="endpointId">
        /// ID of the endpoint whose deployments are listed.
        /// </param>
        /// <param name="limit">
        /// Maximum number of deployments to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous deployment list response.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for the results. Supports `created_at` or `updated_at`, optionally followed by `asc` or `desc`.
        /// </param>
        /// <param name="filter">
        /// Filter expression using `name`, `state`, `model`, `created_at`, or `updated_at` with comparison operators and AND/OR/NOT; `state` takes a DeploymentState enum name and `model` takes a model resource name. `name` supports substring matching with `:` and prefix/suffix wildcards with `*`, and accepts a bare deployment name or `&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListDeploymentsResponse> DeploymentServiceListDeploymentsAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            string? orderBy = default,
            string? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List deployments<br/>
        /// Lists the deployments attached to an endpoint, including their model, configuration, scaling settings, placement, and current status.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project that owns the endpoint.
        /// </param>
        /// <param name="endpointId">
        /// ID of the endpoint whose deployments are listed.
        /// </param>
        /// <param name="limit">
        /// Maximum number of deployments to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous deployment list response.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for the results. Supports `created_at` or `updated_at`, optionally followed by `asc` or `desc`.
        /// </param>
        /// <param name="filter">
        /// Filter expression using `name`, `state`, `model`, `created_at`, or `updated_at` with comparison operators and AND/OR/NOT; `state` takes a DeploymentState enum name and `model` takes a model resource name. `name` supports substring matching with `:` and prefix/suffix wildcards with `*`, and accepts a bare deployment name or `&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListDeploymentsResponse>> DeploymentServiceListDeploymentsAsResponseAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            string? orderBy = default,
            string? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}