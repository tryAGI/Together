#nullable enable

namespace Together
{
    public partial interface IGPUClusterServiceClient
    {
        /// <summary>
        /// Update a GPU Cluster.<br/>
        /// Update the configuration of an existing GPU cluster.
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// cluster = client.beta.clusters.update("cluster_id", cluster_type="KUBERNETES", num_gpus=24)<br/>
        /// print(cluster)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceUpdateAsync(
            string clusterId,

            global::Together.GPUClusterUpdateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a GPU Cluster.<br/>
        /// Update the configuration of an existing GPU cluster.
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to update
        /// </param>
        /// <param name="clusterType">
        /// Type of cluster to update.
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </param>
        /// <param name="reservationEndTime">
        /// Timestamp at which the cluster should be decommissioned. Only accepted for prepaid clusters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceUpdateAsync(
            string clusterId,
            global::Together.GPUClusterUpdateRequestClusterType? clusterType = default,
            int? numGpus = default,
            global::System.DateTime? reservationEndTime = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}