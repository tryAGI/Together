#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {

        /// <summary>
        /// Retrieve file metadata<br/>
        /// Retrieve the metadata for a single uploaded data file.
        /// </summary>
        /// <param name="id">
        /// The ID of the file to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// file = client.files.retrieve(id="file-id")<br/>
        /// print(file)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> GetFilesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}