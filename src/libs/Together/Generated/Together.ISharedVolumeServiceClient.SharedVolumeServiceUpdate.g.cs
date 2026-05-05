#nullable enable

namespace Together
{
    public partial interface ISharedVolumeServiceClient
    {
        /// <summary>
        /// Update a shared volume.<br/>
        /// Update the configuration of an existing shared volume.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volume = client.beta.clusters.storage.update(<br/>
        ///   volume_id="12345-67890-12345-67890",<br/>
        ///   size_tib=3<br/>
        /// )<br/>
        /// print(volume)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolume> SharedVolumeServiceUpdateAsync(

            global::Together.GPUClustersSharedVolumeUpdateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a shared volume.<br/>
        /// Update the configuration of an existing shared volume.
        /// </summary>
        /// <param name="volumeId">
        /// ID of the volume to update.
        /// </param>
        /// <param name="sizeTib">
        /// Size of the volume in whole tebibytes (TiB).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolume> SharedVolumeServiceUpdateAsync(
            string? volumeId = default,
            long? sizeTib = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}