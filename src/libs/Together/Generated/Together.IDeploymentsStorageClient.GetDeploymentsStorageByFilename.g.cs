#nullable enable

namespace Together
{
    public partial interface IDeploymentsStorageClient
    {
        /// <summary>
        /// Download a file<br/>
        /// Download a file by redirecting to a signed URL
        /// </summary>
        /// <param name="filename">
        /// Filename
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task GetDeploymentsStorageByFilenameAsync(
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}