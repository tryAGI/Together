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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task GetDeploymentsStorageByFilenameAsync(
            string filename,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}