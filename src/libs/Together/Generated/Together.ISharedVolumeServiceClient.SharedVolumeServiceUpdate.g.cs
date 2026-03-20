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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolume> SharedVolumeServiceUpdateAsync(

            global::Together.GPUClustersSharedVolumeUpdateRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolume> SharedVolumeServiceUpdateAsync(
            string? volumeId = default,
            long? sizeTib = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}