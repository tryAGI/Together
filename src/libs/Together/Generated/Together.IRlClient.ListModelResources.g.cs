#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// List model resources<br/>
        /// Lists the caller's model resources.
        /// </summary>
        /// <param name="status">
        /// Status filters. When omitted, resources in any status are returned.
        /// </param>
        /// <param name="limit">
        /// Maximum number of resources to return (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for pagination
        /// </param>
        /// <param name="createdBy">
        /// Filter resources in the current project by the creator ID. Pass "me" to show resources you created.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlModelResourcesListResponse> ListModelResourcesAsync(
            global::System.Collections.Generic.IList<global::Together.ListModelResourcesStatu>? status = default,
            int? limit = default,
            string? after = default,
            string? createdBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List model resources<br/>
        /// Lists the caller's model resources.
        /// </summary>
        /// <param name="status">
        /// Status filters. When omitted, resources in any status are returned.
        /// </param>
        /// <param name="limit">
        /// Maximum number of resources to return (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for pagination
        /// </param>
        /// <param name="createdBy">
        /// Filter resources in the current project by the creator ID. Pass "me" to show resources you created.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlModelResourcesListResponse>> ListModelResourcesAsResponseAsync(
            global::System.Collections.Generic.IList<global::Together.ListModelResourcesStatu>? status = default,
            int? limit = default,
            string? after = default,
            string? createdBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}