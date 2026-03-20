#nullable enable

namespace Together
{
    public partial interface ISharedVolumeServiceClient
    {
        /// <summary>
        /// List all shared volumes.<br/>
        /// List all shared volumes.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volumes = client.beta.clusters.storage.list()<br/>
        /// print(volumes)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolumes> SharedVolumeServiceListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}