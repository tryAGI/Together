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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolumeDeleteResponse> SharedVolumeServiceDeleteAsync(
            string volumeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}