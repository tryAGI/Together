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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetFilesByIdContentAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file contents<br/>
        /// Get the contents of a single uploaded data file.
        /// </summary>
        /// <param name="id">
        /// The ID of the file to get the content of
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetFilesByIdContentAsStreamAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file contents<br/>
        /// Get the contents of a single uploaded data file.
        /// </summary>
        /// <param name="id">
        /// The ID of the file to get the content of
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<byte[]>> GetFilesByIdContentAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}