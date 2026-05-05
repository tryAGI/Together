
#nullable enable

namespace Together
{
    /// <summary>
    /// GPU Cluster create request
    /// </summary>
    public sealed partial class GPUClusterCreateRequest
    {
        /// <summary>
        /// Type of cluster to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeJsonConverter))]
        public global::Together.GPUClusterCreateRequestClusterType? ClusterType { get; set; }

        /// <summary>
        /// Region to create the GPU cluster in. Usable regions can be found from `client.clusters.list_regions()`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Type of GPU to use in the cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GPUClusterCreateRequestGpuType GpuType { get; set; }

        /// <summary>
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumGpus { get; set; }

        /// <summary>
        /// Name of the GPU cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterName { get; set; }

        /// <summary>
        /// Duration in days to keep the cluster running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_days")]
        public int? DurationDays { get; set; }

        /// <summary>
        /// Inline configuration to create a shared volume with the cluster creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_volume")]
        public global::Together.GPUClustersSharedVolumeCreateRequest? SharedVolume { get; set; }

        /// <summary>
        /// ID of an existing volume to use with the cluster creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_id")]
        public string? VolumeId { get; set; }

        /// <summary>
        /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
        /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.<br/>
        /// SCHEDULED_CAPACITY billing types allow you to reserve capacity for a scheduled time window. You must specify the reservation_start_time and reservation_end_time with this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GPUClusterCreateRequestBillingType BillingType { get; set; }

        /// <summary>
        /// Whether automated GPU node failover should be enabled for this cluster. By default, it is disabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_node_failover_enabled")]
        public bool? GpuNodeFailoverEnabled { get; set; }

        /// <summary>
        /// Whether GPU cluster should be auto-scaled based on the workload. By default, it is not auto-scaled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_scaled")]
        public bool? AutoScaled { get; set; }

        /// <summary>
        /// Maximum number of GPUs to which the cluster can be auto-scaled up. This field is required if auto_scaled is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_scale_max_gpus")]
        public int? AutoScaleMaxGpus { get; set; }

        /// <summary>
        /// Shared memory size in GiB for Slurm cluster. This field is required if cluster_type is SLURM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_shm_size_gib")]
        public int? SlurmShmSizeGib { get; set; }

        /// <summary>
        /// ID of the capacity pool to use for the cluster. This field is optional and only applicable if the cluster is created from a capacity pool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity_pool_id")]
        public string? CapacityPoolId { get; set; }

        /// <summary>
        /// Reservation start time of the cluster. This field is required for SCHEDULED billing to specify the reservation start time for the cluster. If not provided, the cluster will be provisioned immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_start_time")]
        public global::System.DateTime? ReservationStartTime { get; set; }

        /// <summary>
        /// Reservation end time of the cluster. This field is required for SCHEDULED billing to specify the reservation end time for the cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_end_time")]
        public global::System.DateTime? ReservationEndTime { get; set; }

        /// <summary>
        /// Whether to install Traefik ingress controller in the cluster. This field is only applicable for Kubernetes clusters and is false by default.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("install_traefik")]
        public bool? InstallTraefik { get; set; }

        /// <summary>
        /// CUDA version for this cluster. For example, 12.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuda_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CudaVersion { get; set; }

        /// <summary>
        /// Nvidia driver version for this cluster. For example, 550. Only some combination of cuda_version and nvidia_driver_version are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvidia_driver_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NvidiaDriverVersion { get; set; }

        /// <summary>
        /// Custom Slurm image for Slurm clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_image")]
        public string? SlurmImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterCreateRequest" /> class.
        /// </summary>
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
        /// <param name="billingType">
        /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
        /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.<br/>
        /// SCHEDULED_CAPACITY billing types allow you to reserve capacity for a scheduled time window. You must specify the reservation_start_time and reservation_end_time with this request.
        /// </param>
        /// <param name="cudaVersion">
        /// CUDA version for this cluster. For example, 12.5
        /// </param>
        /// <param name="nvidiaDriverVersion">
        /// Nvidia driver version for this cluster. For example, 550. Only some combination of cuda_version and nvidia_driver_version are supported.
        /// </param>
        /// <param name="clusterType">
        /// Type of cluster to create.
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
        /// <param name="slurmImage">
        /// Custom Slurm image for Slurm clusters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterCreateRequest(
            string region,
            global::Together.GPUClusterCreateRequestGpuType gpuType,
            int numGpus,
            string clusterName,
            global::Together.GPUClusterCreateRequestBillingType billingType,
            string cudaVersion,
            string nvidiaDriverVersion,
            global::Together.GPUClusterCreateRequestClusterType? clusterType,
            int? durationDays,
            global::Together.GPUClustersSharedVolumeCreateRequest? sharedVolume,
            string? volumeId,
            bool? gpuNodeFailoverEnabled,
            bool? autoScaled,
            int? autoScaleMaxGpus,
            int? slurmShmSizeGib,
            string? capacityPoolId,
            global::System.DateTime? reservationStartTime,
            global::System.DateTime? reservationEndTime,
            bool? installTraefik,
            string? slurmImage)
        {
            this.ClusterType = clusterType;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.GpuType = gpuType;
            this.NumGpus = numGpus;
            this.ClusterName = clusterName ?? throw new global::System.ArgumentNullException(nameof(clusterName));
            this.DurationDays = durationDays;
            this.SharedVolume = sharedVolume;
            this.VolumeId = volumeId;
            this.BillingType = billingType;
            this.GpuNodeFailoverEnabled = gpuNodeFailoverEnabled;
            this.AutoScaled = autoScaled;
            this.AutoScaleMaxGpus = autoScaleMaxGpus;
            this.SlurmShmSizeGib = slurmShmSizeGib;
            this.CapacityPoolId = capacityPoolId;
            this.ReservationStartTime = reservationStartTime;
            this.ReservationEndTime = reservationEndTime;
            this.InstallTraefik = installTraefik;
            this.CudaVersion = cudaVersion ?? throw new global::System.ArgumentNullException(nameof(cudaVersion));
            this.NvidiaDriverVersion = nvidiaDriverVersion ?? throw new global::System.ArgumentNullException(nameof(nvidiaDriverVersion));
            this.SlurmImage = slurmImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterCreateRequest" /> class.
        /// </summary>
        public GPUClusterCreateRequest()
        {
        }
    }
}