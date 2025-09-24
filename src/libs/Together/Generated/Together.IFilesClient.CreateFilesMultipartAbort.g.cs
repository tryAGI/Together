#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Abort multipart upload<br/>
        /// Abort a multipart upload and clean up any uploaded parts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Response2> CreateFilesMultipartAbortAsync(
            global::Together.MultipartAbortRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Abort multipart upload<br/>
        /// Abort a multipart upload and clean up any uploaded parts.
        /// </summary>
        /// <param name="fileId">
        /// File ID from initiate response<br/>
        /// Example: file-def456
        /// </param>
        /// <param name="uploadId">
        /// Upload session ID from initiate response<br/>
        /// Example: upload-abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Response2> CreateFilesMultipartAbortAsync(
            string fileId,
            string uploadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}