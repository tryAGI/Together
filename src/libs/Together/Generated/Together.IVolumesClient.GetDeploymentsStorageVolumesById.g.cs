#nullable enable

namespace Together
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Get a volume by ID or name<br/>
        /// Retrieve details of a specific volume by its ID or name
        /// </summary>
        /// <param name="id">
        /// Volume ID or name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VolumeResponseItem> GetDeploymentsStorageVolumesByIdAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}