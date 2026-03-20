#nullable enable

namespace Together
{
    public partial interface ISharedVolumeServiceClient
    {

        /// <summary>
        /// Get shared volume by volume Id.<br/>
        /// Retrieve information about a specific shared volume.
        /// </summary>
        /// <param name="volumeId">
        /// The ID of the volume to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volume = client.beta.clusters.storage.retrieve("volume_id")<br/>
        /// print(volume)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolume> SharedVolumeServiceGetAsync(
            string volumeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}