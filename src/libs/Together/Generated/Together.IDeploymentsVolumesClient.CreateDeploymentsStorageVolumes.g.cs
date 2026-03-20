#nullable enable

namespace Together
{
    public partial interface IDeploymentsVolumesClient
    {
        /// <summary>
        /// Create a new volume<br/>
        /// Create a new volume to preload files in deployments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VolumeResponseItem> CreateDeploymentsStorageVolumesAsync(

            global::Together.CreateVolumeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new volume<br/>
        /// Create a new volume to preload files in deployments
        /// </summary>
        /// <param name="content">
        /// Content specifies the content configuration for this volume
        /// </param>
        /// <param name="name">
        /// Name is the unique identifier for the volume within the project
        /// </param>
        /// <param name="type">
        /// Type is the volume type (currently only "readOnly" is supported)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VolumeResponseItem> CreateDeploymentsStorageVolumesAsync(
            global::Together.VolumeContentRequest content,
            string name,
            global::Together.VolumeType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}