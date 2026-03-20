#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List all files<br/>
        /// List the metadata for all uploaded data files.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.files.list()<br/>
        /// for file in response.data:<br/>
        ///     print(file.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FileList> GetFilesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}