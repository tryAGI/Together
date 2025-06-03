#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file<br/>
        /// Upload a file with specified purpose, file name, and file type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> CreateFilesUploadAsync(
            global::Together.Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file<br/>
        /// Upload a file with specified purpose, file name, and file type.
        /// </summary>
        /// <param name="file">
        /// The content of the file being uploaded
        /// </param>
        /// <param name="filename">
        /// The content of the file being uploaded
        /// </param>
        /// <param name="fileName">
        /// The name of the file being uploaded<br/>
        /// Example: dataset.csv
        /// </param>
        /// <param name="fileType">
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </param>
        /// <param name="purpose">
        /// The purpose of the file<br/>
        /// Example: fine-tune
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> CreateFilesUploadAsync(
            byte[] file,
            string filename,
            string fileName,
            global::Together.FilePurpose purpose,
            global::Together.FileType? fileType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}