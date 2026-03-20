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
        global::System.Threading.Tasks.Task<global::Together.FileResponse> GetFilesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}