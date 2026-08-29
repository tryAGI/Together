#nullable enable

namespace Together
{
    public partial interface IPlacementProfileServiceClient
    {
        /// <summary>
        /// List placement profiles<br/>
        /// Lists reusable, project-visible placement policies that control the regions where deployments may be scheduled.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of profiles to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous placement profile list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListPlacementProfilesResponse> PlacementProfileServiceListPlacementProfilesAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List placement profiles<br/>
        /// Lists reusable, project-visible placement policies that control the regions where deployments may be scheduled.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of profiles to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous placement profile list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListPlacementProfilesResponse>> PlacementProfileServiceListPlacementProfilesAsResponseAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}