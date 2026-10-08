#nullable enable

namespace Together
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List available projects<br/>
        /// Retrieve a list of accessible projects.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of user projects in the page.
        /// </param>
        /// <param name="after">
        /// Paginate the response utilizing a responses next_cursor field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListProjectsResponse> ListProjectsAsync(
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List available projects<br/>
        /// Retrieve a list of accessible projects.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of user projects in the page.
        /// </param>
        /// <param name="after">
        /// Paginate the response utilizing a responses next_cursor field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ListProjectsResponse>> ListProjectsAsResponseAsync(
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}