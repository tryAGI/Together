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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// response = client.beta.clusters.create(<br/>
        ///   cluster_name="my-gpu-cluster",<br/>
        ///   region="us-central-8",<br/>
        ///   gpu_type="H100_SXM",<br/>
        ///   num_gpus=8,<br/>
        ///   driver_version="CUDA_12_6_560",<br/>
        ///   billint_type="ON_DEMAND",<br/>
        /// )<br/>
        /// print(response.cluster_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceCreateAsync(

            global::Together.GPUClusterCreateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create GPU Cluster<br/>
        /// Create an Instant Cluster on Together's high-performance GPU clusters.<br/>
        /// With features like on-demand scaling, long-lived resizable high-bandwidth shared DC-local storage,<br/>
        /// Kubernetes and Slurm cluster flavors, a REST API, and Terraform support,<br/>
        /// you can run workloads flexibly without complex infrastructure management.
        /// </summary>
        /// <param name="clusterType">
        /// Type of cluster to create.
        /// </param>
        /// <param name="region">
        /// Region to create the GPU cluster in. Usable regions can be found from `client.clusters.list_regions()`
        /// </param>
        /// <param name="gpuType">
        /// Type of GPU to use in the cluster
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </param>
        /// <param name="clusterName">
        /// Name of the GPU cluster.
        /// </param>
        /// <param name="durationDays">
        /// Duration in days to keep the cluster running.
        /// </param>
        /// <param name="sharedVolume">
        /// Inline configuration to create a shared volume with the cluster creation.
        /// </param>
        /// <param name="volumeId">
        /// ID of an existing volume to use with the cluster creation.
        /// </param>
        /// <param name="billingType">
        /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
        /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.<br/>
        /// SCHEDULED_CAPACITY billing types allow you to reserve capacity for a scheduled time window. You must specify the reservation_start_time and reservation_end_time with this request.
        /// </param>
        /// <param name="gpuNodeFailoverEnabled">
        /// Whether automated GPU node failover should be enabled for this cluster. By default, it is disabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoScaled">
        /// Whether GPU cluster should be auto-scaled based on the workload. By default, it is not auto-scaled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoScaleMaxGpus">
        /// Maximum number of GPUs to which the cluster can be auto-scaled up. This field is required if auto_scaled is true.
        /// </param>
        /// <param name="slurmShmSizeGib">
        /// Shared memory size in GiB for Slurm cluster. This field is required if cluster_type is SLURM.
        /// </param>
        /// <param name="capacityPoolId">
        /// ID of the capacity pool to use for the cluster. This field is optional and only applicable if the cluster is created from a capacity pool.
        /// </param>
        /// <param name="reservationStartTime">
        /// Reservation start time of the cluster. This field is required for SCHEDULED billing to specify the reservation start time for the cluster. If not provided, the cluster will be provisioned immediately.
        /// </param>
        /// <param name="reservationEndTime">
        /// Reservation end time of the cluster. This field is required for SCHEDULED billing to specify the reservation end time for the cluster.
        /// </param>
        /// <param name="installTraefik">
        /// Whether to install Traefik ingress controller in the cluster. This field is only applicable for Kubernetes clusters and is false by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cudaVersion">
        /// CUDA version for this cluster. For example, 12.5
        /// </param>
        /// <param name="nvidiaDriverVersion">
        /// Nvidia driver version for this cluster. For example, 550. Only some combination of cuda_version and nvidia_driver_version are supported.
        /// </param>
        /// <param name="slurmImage">
        /// Custom Slurm image for Slurm clusters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceCreateAsync(
            string region,
            global::Together.GPUClusterCreateRequestGpuType gpuType,
            int numGpus,
            string clusterName,
            global::Together.GPUClusterCreateRequestBillingType billingType,
            string cudaVersion,
            string nvidiaDriverVersion,
            global::Together.GPUClusterCreateRequestClusterType? clusterType = default,
            int? durationDays = default,
            global::Together.GPUClustersSharedVolumeCreateRequest? sharedVolume = default,
            string? volumeId = default,
            bool? gpuNodeFailoverEnabled = default,
            bool? autoScaled = default,
            int? autoScaleMaxGpus = default,
            int? slurmShmSizeGib = default,
            string? capacityPoolId = default,
            global::System.DateTime? reservationStartTime = default,
            global::System.DateTime? reservationEndTime = default,
            bool? installTraefik = default,
            string? slurmImage = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}