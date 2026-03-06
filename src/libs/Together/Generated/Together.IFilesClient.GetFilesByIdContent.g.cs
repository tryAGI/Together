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
        global::System.Threading.Tasks.Task<byte[]> GetFilesByIdContentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}