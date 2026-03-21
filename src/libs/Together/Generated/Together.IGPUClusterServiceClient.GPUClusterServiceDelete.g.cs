#nullable enable

namespace Together
{
    public partial interface IGPUClusterServiceClient
    {
        /// <summary>
        /// Delete GPU cluster by cluster ID<br/>
        /// Delete a GPU cluster by cluster ID.
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// cluster = client.beta.clusters.delete("cluster_id")<br/>
        /// print(cluster)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterServiceDeleteResponse> GPUClusterServiceDeleteAsync(
            string clusterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}