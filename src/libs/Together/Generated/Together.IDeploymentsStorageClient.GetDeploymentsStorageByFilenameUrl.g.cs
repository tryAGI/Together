#nullable enable

namespace Together
{
    public partial interface IDeploymentsStorageClient
    {
        /// <summary>
        /// Get a file download URL<br/>
        /// Create a signed URL for downloading a deployment storage file
        /// </summary>
        /// <param name="filename">
        /// Filename
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.SignedURLResponse> GetDeploymentsStorageByFilenameUrlAsync(
            string filename,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a file download URL<br/>
        /// Create a signed URL for downloading a deployment storage file
        /// </summary>
        /// <param name="filename">
        /// Filename
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.SignedURLResponse>> GetDeploymentsStorageByFilenameUrlAsResponseAsync(
            string filename,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}