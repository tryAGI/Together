#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// List remote model upload events<br/>
        /// Lists progress and diagnostic events for a remote model import job.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Remote upload identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous remote upload event list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListRemoteUploadEventsResponse> VolumeServiceListRemoteModelUploadEventsAsync(
            string projectId,
            string id,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List remote model upload events<br/>
        /// Lists progress and diagnostic events for a remote model import job.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Remote upload identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous remote upload event list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListRemoteUploadEventsResponse>> VolumeServiceListRemoteModelUploadEventsAsResponseAsync(
            string projectId,
            string id,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}