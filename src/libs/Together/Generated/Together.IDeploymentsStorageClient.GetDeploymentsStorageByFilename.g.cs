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
        /// <remarks>
        /// import httpx<br/>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper. The API redirects to a signed URL,<br/>
        /// # which the client follows, so the response body is the file itself.<br/>
        /// response = client.get("/v1/deployments/storage/model.tar.gz", cast_to=httpx.Response)<br/>
        /// with open("model.tar.gz", "wb") as f:<br/>
        ///     f.write(response.content)
        /// </remarks>
        global::System.Threading.Tasks.Task GetDeploymentsStorageByFilenameAsync(
            string filename,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <remarks>
        /// import httpx<br/>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper. The API redirects to a signed URL,<br/>
        /// # which the client follows, so the response body is the file itself.<br/>
        /// response = client.get("/v1/deployments/storage/model.tar.gz", cast_to=httpx.Response)<br/>
        /// with open("model.tar.gz", "wb") as f:<br/>
        ///     f.write(response.content)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse> GetDeploymentsStorageByFilenameAsResponseAsync(
            string filename,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}