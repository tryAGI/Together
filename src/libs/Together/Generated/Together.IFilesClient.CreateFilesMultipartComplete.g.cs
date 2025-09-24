#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Complete multipart upload<br/>
        /// Complete a multipart upload by providing ETags for all uploaded parts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> CreateFilesMultipartCompleteAsync(
            global::Together.MultipartCompleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete multipart upload<br/>
        /// Complete a multipart upload by providing ETags for all uploaded parts.
        /// </summary>
        /// <param name="fileId">
        /// File ID from initiate response<br/>
        /// Example: file-def456
        /// </param>
        /// <param name="parts">
        /// ETags for each successfully uploaded part
        /// </param>
        /// <param name="uploadId">
        /// Upload session ID from initiate response<br/>
        /// Example: upload-abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> CreateFilesMultipartCompleteAsync(
            string fileId,
            global::System.Collections.Generic.IList<global::Together.MultipartCompleteRequestPart> parts,
            string uploadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}