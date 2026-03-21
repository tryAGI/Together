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
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// current_dir = os.path.dirname(os.path.abspath(__file__))<br/>
        /// file_path = os.path.join(current_dir, "data.jsonl")<br/>
        /// file = client.files.upload(file=file_path)<br/>
        /// print(file.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> CreateFilesUploadAsync(

            global::Together.CreateFilesUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Upload a file with specified purpose, file name, and file type.
        /// </summary>
        /// <param name="purpose">
        /// The purpose of the file<br/>
        /// Example: fine-tune
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
        /// <param name="file">
        /// The content of the file being uploaded
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> CreateFilesUploadAsync(
            global::Together.FilePurpose purpose,
            string fileName,
            byte[] file,
            global::Together.FileType? fileType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}