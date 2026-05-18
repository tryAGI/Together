#nullable enable

namespace Together
{
    public partial interface IGPUClusterServiceClient
    {
        /// <summary>
        /// Update a GPU cluster<br/>
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
        /// Update a GPU cluster<br/>
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
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.GPUClusterInfo>> GPUClusterServiceUpdateAsResponseAsync(
            string clusterId,

            global::Together.GPUClusterUpdateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a GPU cluster<br/>
        /// Update the configuration of an existing GPU cluster.
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to update
        /// </param>
        /// <param name="clusterType">
        /// Type of cluster to update.
        /// </param>
        /// <param name="numGpus">
        /// Target GPU count for the cluster. When omitted, the server keeps the current GPU count from cluster metadata (use for config-only or decommission-time-only updates).
        /// </param>
        /// <param name="reservationEndTime">
        /// Timestamp at which the cluster should be decommissioned. Only accepted for prepaid clusters.
        /// </param>
        /// <param name="clusterConfig"></param>
        /// <param name="numReservedGpus">
        /// Number of reserved GPUs to update to. This field is only applicable for clusters with RESERVED billing type.
        /// </param>
        /// <param name="numPreemptibleGpus">
        /// Updated desired number of preemptible GPUs for the cluster. When omitted, the current value is preserved. Must be a multiple of 8.
        /// </param>
        /// <param name="addOns">
        /// Add-ons to update on the cluster. Each entry identifies an existing add-on by name and provides the new external config to merge.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceUpdateAsync(
            string clusterId,
            global::Together.GPUClusterUpdateRequestClusterType? clusterType = default,
            int? numGpus = default,
            global::System.DateTime? reservationEndTime = default,
            global::Together.InstanceClusterConfig? clusterConfig = default,
            int? numReservedGpus = default,
            int? numPreemptibleGpus = default,
            global::System.Collections.Generic.IList<global::Together.AddOnUpdateRequest>? addOns = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}