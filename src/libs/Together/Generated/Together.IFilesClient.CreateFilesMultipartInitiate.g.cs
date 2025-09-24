#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Initiate multipart upload<br/>
        /// Initiate a multipart upload for large files (&gt;5GB) with presigned URLs for each part.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.MultipartInitiateResponse> CreateFilesMultipartInitiateAsync(
            global::Together.MultipartInitiateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiate multipart upload<br/>
        /// Initiate a multipart upload for large files (&gt;5GB) with presigned URLs for each part.
        /// </summary>
        /// <param name="fileSize">
        /// Total size of the file in bytes<br/>
        /// Example: 7516192768L
        /// </param>
        /// <param name="fileType">
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </param>
        /// <param name="filename">
        /// The name of the file being uploaded<br/>
        /// Example: large_dataset.jsonl
        /// </param>
        /// <param name="numParts">
        /// Number of parts to split the file into (1-250)<br/>
        /// Example: 75
        /// </param>
        /// <param name="purpose">
        /// The purpose of the file<br/>
        /// Example: fine-tune
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.MultipartInitiateResponse> CreateFilesMultipartInitiateAsync(
            long fileSize,
            global::Together.FileType fileType,
            string filename,
            int numParts,
            global::Together.FilePurpose purpose,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}