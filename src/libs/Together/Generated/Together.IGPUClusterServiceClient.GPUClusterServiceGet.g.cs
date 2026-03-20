#nullable enable

namespace Together
{
    public partial interface IGPUClusterServiceClient
    {
        /// <summary>
        /// Get GPU cluster by cluster ID<br/>
        /// Retrieve information about a specific GPU cluster.
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceGetAsync(
            string clusterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}