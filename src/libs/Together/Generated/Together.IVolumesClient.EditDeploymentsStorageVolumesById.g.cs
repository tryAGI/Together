#nullable enable

namespace Together
{
    public partial interface IVolumesClient
    {

        /// <summary>
        /// Update a volume<br/>
        /// Update an existing volume's configuration or contents
        /// </summary>
        /// <param name="id">
        /// Volume ID or name.
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VolumeResponseItem> EditDeploymentsStorageVolumesByIdAsync(
            string id,

            global::Together.UpdateVolumeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a volume<br/>
        /// Update an existing volume's configuration or contents
        /// </summary>
        /// <param name="id">
        /// Volume ID or name.
        /// </param>
        /// <param name="content">
        /// Content specifies the new content that will be preloaded to this volume
        /// </param>
        /// <param name="name">
        /// Name is the new unique identifier for the volume within the project
        /// </param>
        /// <param name="type">
        /// Type is the new volume type (currently only "readOnly" is supported)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VolumeResponseItem> EditDeploymentsStorageVolumesByIdAsync(
            string id,
            global::Together.VolumeContentRequest? content = default,
            string? name = default,
            global::Together.VolumeType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}