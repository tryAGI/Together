#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// List remote model uploads<br/>
        /// Lists asynchronous jobs that import model files from Hugging Face or a presigned remote URL.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of uploads to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous remote upload list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListRemoteUploadsResponse> VolumeServiceListRemoteModelUploadsAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List remote model uploads<br/>
        /// Lists asynchronous jobs that import model files from Hugging Face or a presigned remote URL.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of uploads to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous remote upload list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListRemoteUploadsResponse>> VolumeServiceListRemoteModelUploadsAsResponseAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}