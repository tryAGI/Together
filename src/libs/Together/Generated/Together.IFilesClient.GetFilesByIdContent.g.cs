#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get file contents<br/>
        /// Get the contents of a single uploaded data file.
        /// </summary>
        /// <param name="id">
        /// The ID of the file to get the content of
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
        /// with client.files.with_streaming_response.content(id="file-id") as response:<br/>
        ///   for line in response.iter_lines():<br/>
        ///     print(line)
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> GetFilesByIdContentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}