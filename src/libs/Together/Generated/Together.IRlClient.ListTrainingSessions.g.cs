#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// List training sessions<br/>
        /// Lists all training sessions.
        /// </summary>
        /// <param name="status">
        /// Status filters. When omitted, sessions in any status are returned.
        /// </param>
        /// <param name="limit">
        /// Maximum number of sessions to return (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for pagination (ID of the last session from the previous page)
        /// </param>
        /// <param name="modelResourcesId">
        /// Filter sessions by the model resource they are attached to
        /// </param>
        /// <param name="createdBy">
        /// Filter sessions in the current project by the creator ID. Pass "me" to show sessions you created.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSessionsListResponse> ListTrainingSessionsAsync(
            global::System.Collections.Generic.IList<global::Together.ListTrainingSessionsStatu>? status = default,
            int? limit = default,
            string? after = default,
            string? modelResourcesId = default,
            string? createdBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List training sessions<br/>
        /// Lists all training sessions.
        /// </summary>
        /// <param name="status">
        /// Status filters. When omitted, sessions in any status are returned.
        /// </param>
        /// <param name="limit">
        /// Maximum number of sessions to return (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for pagination (ID of the last session from the previous page)
        /// </param>
        /// <param name="modelResourcesId">
        /// Filter sessions by the model resource they are attached to
        /// </param>
        /// <param name="createdBy">
        /// Filter sessions in the current project by the creator ID. Pass "me" to show sessions you created.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlTrainingSessionsListResponse>> ListTrainingSessionsAsResponseAsync(
            global::System.Collections.Generic.IList<global::Together.ListTrainingSessionsStatu>? status = default,
            int? limit = default,
            string? after = default,
            string? modelResourcesId = default,
            string? createdBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}