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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # Point the volume at a new version of its files. The CLI's<br/>
        /// # `tg beta jig volumes update` uploads the files and makes this call for you.<br/>
        /// volume = client.beta.jig.volumes.update(<br/>
        ///     "my-volume",<br/>
        ///     content={"type": "files", "source_prefix": "my-volume/1"},<br/>
        /// )<br/>
        /// print(volume.current_version)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.VolumeResponseItem> EditDeploymentsStorageVolumesByIdAsync(
            string id,

            global::Together.UpdateVolumeRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a volume<br/>
        /// Update an existing volume's configuration or contents
        /// </summary>
        /// <param name="id">
        /// Volume ID or name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # Point the volume at a new version of its files. The CLI's<br/>
        /// # `tg beta jig volumes update` uploads the files and makes this call for you.<br/>
        /// volume = client.beta.jig.volumes.update(<br/>
        ///     "my-volume",<br/>
        ///     content={"type": "files", "source_prefix": "my-volume/1"},<br/>
        /// )<br/>
        /// print(volume.current_version)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.VolumeResponseItem>> EditDeploymentsStorageVolumesByIdAsResponseAsync(
            string id,

            global::Together.UpdateVolumeRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a volume<br/>
        /// Update an existing volume's configuration or contents
        /// </summary>
        /// <param name="id">
        /// Volume ID or name.
        /// </param>
        /// <param name="content">
        /// Content specifies the new content to preload to this volume.
        /// </param>
        /// <param name="name">
        /// Name is the new unique identifier for the volume within the project
        /// </param>
        /// <param name="type">
        /// Type is the new volume type (currently only "readOnly" is supported)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VolumeResponseItem> EditDeploymentsStorageVolumesByIdAsync(
            string id,
            global::Together.VolumeContentRequest? content = default,
            string? name = default,
            global::Together.VolumeType? type = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}