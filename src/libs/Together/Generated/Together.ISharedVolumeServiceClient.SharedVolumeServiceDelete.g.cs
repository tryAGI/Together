#nullable enable

namespace Together
{
    public partial interface ISharedVolumeServiceClient
    {
        /// <summary>
        /// Delete shared volume by volume id.<br/>
        /// Delete a shared volume. Note that if this volume is attached to a cluster, deleting will fail.
        /// </summary>
        /// <param name="volumeId">
        /// The ID of the volume to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volume = client.beta.clusters.storage.delete("volume_id")<br/>
        /// print(volume)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolumeDeleteResponse> SharedVolumeServiceDeleteAsync(
            string volumeId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}