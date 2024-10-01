#nullable enable

namespace Together
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List file<br/>
        /// List the metadata for a single uploaded data file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FileResponse> GetFilesIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}