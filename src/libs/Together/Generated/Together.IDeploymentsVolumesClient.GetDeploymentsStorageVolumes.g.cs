#nullable enable

namespace Together
{
    public partial interface IDeploymentsVolumesClient
    {
        /// <summary>
        /// Get the list of project volumes<br/>
        /// Retrieve all volumes in your project
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListVolumesResponse> GetDeploymentsStorageVolumesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}