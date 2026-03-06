#nullable enable

namespace Together
{
    public partial interface IGPUClusterServiceClient
    {
        /// <summary>
        /// Create GPU Cluster<br/>
        /// Create an Instant Cluster on Together's high-performance GPU clusters.<br/>
        /// With features like on-demand scaling, long-lived resizable high-bandwidth shared DC-local storage,<br/>
        /// Kubernetes and Slurm cluster flavors, a REST API, and Terraform support,<br/>
        /// you can run workloads flexibly without complex infrastructure management.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceCreateAsync(

            global::Together.GPUClusterCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create GPU Cluster<br/>
        /// Create an Instant Cluster on Together's high-performance GPU clusters.<br/>
        /// With features like on-demand scaling, long-lived resizable high-bandwidth shared DC-local storage,<br/>
        /// Kubernetes and Slurm cluster flavors, a REST API, and Terraform support,<br/>
        /// you can run workloads flexibly without complex infrastructure management.
        /// </summary>
        /// <param name="billingType">
        /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
        /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.
        /// </param>
        /// <param name="clusterName">
        /// Name of the GPU cluster.
        /// </param>
        /// <param name="clusterType">
        /// Type of cluster to create.
        /// </param>
        /// <param name="driverVersion">
        /// NVIDIA driver version to use in the cluster.
        /// </param>
        /// <param name="durationDays">
        /// Duration in days to keep the cluster running.
        /// </param>
        /// <param name="gpuType">
        /// Type of GPU to use in the cluster
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </param>
        /// <param name="region">
        /// Region to create the GPU cluster in. Usable regions can be found from `client.clusters.list_regions()`
        /// </param>
        /// <param name="sharedVolume"></param>
        /// <param name="volumeId">
        /// ID of an existing volume to use with the cluster creation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceCreateAsync(
            global::Together.GPUClusterCreateRequestBillingType billingType,
            string clusterName,
            global::Together.GPUClusterCreateRequestDriverVersion driverVersion,
            global::Together.GPUClusterCreateRequestGpuType gpuType,
            int numGpus,
            string region,
            global::Together.GPUClusterCreateRequestClusterType? clusterType = default,
            int? durationDays = default,
            global::Together.GPUClustersSharedVolumeCreateRequest? sharedVolume = default,
            string? volumeId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}