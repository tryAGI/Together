#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete a file<br/>
        /// Delete a previously uploaded data file.
        /// </summary>
        /// <param name="id">
        /// The ID of the file to delete
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
        /// response = client.files.delete(id="file-id")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FileDeleteResponse> DeleteFilesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}