#nullable enable

namespace Together
{
    public partial interface IDeploymentsVolumesClient
    {
        /// <summary>
        /// Get the list of project volumes<br/>
        /// Retrieve all volumes in your project
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volumes = client.beta.jig.storage.volumes.list()<br/>
        /// print(volumes)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ListVolumesResponse> GetDeploymentsStorageVolumesAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}