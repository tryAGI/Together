#nullable enable

namespace Together
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Delete a volume<br/>
        /// Delete an existing volume
        /// </summary>
        /// <param name="id">
        /// Volume ID or name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDeploymentsStorageVolumesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}