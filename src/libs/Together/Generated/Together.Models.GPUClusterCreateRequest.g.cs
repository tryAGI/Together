
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// Whether GPU cluster should be auto-scaled based on the workload. By default, it is not auto-scaled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_scaled")]
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// Reservation start time of the cluster. This field is required for SCHEDULED billing to specify the reservation start time for the cluster. If not provided, the cluster provisions immediately.
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
        /// Legacy CUDA selector for this cluster. Bare semantic values such as 12.5 select ubuntu-22.04; existing OS-suffixed values remain accepted for compatibility. Must be paired with nvidia_driver_version. Prefer nvidia_version_id for new integrations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuda_version")]
        public string? CudaVersion { get; set; }

        /// <summary>
        /// Legacy NVIDIA driver selector for this cluster. For example, 550. Must be paired with cuda_version. Prefer nvidia_version_id for new integrations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvidia_driver_version")]
        public string? NvidiaDriverVersion { get; set; }

        /// <summary>
        /// Canonical region-specific NVIDIA version ID. If cuda_version and nvidia_driver_version are also set, they must resolve to the same catalog entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvidia_version_id")]
        public string? NvidiaVersionId { get; set; }

        /// <summary>
        /// Custom Slurm image for Slurm clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_image")]
        public string? SlurmImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidc_config")]
        public global::Together.OIDCConfig? OidcConfig { get; set; }

        /// <summary>
        /// Project ID for the cluster. If not set, the project from the request context is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// AcceptanceTestsParams groups all GPU acceptance test options when enabled is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptance_tests_params")]
        public global::Together.AcceptanceTestsParams? AcceptanceTestsParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_config")]
        public global::Together.InstanceClusterConfig? ClusterConfig { get; set; }

        /// <summary>
        /// Number of GPUs to allocate from the capacity pool. Must be a multiple of 8 and not exceed num_gpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_capacity_pool_gpus")]
        public int? NumCapacityPoolGpus { get; set; }

        /// <summary>
        /// Whether to enable auto-scaling for the cluster. If true, the cluster will automatically scale the number of GPU worker nodes between num_gpus and auto_scale_max_gpus based on the workload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_scale")]
        public bool? AutoScale { get; set; }

        /// <summary>
        /// Number of preemptible GPUs to request alongside on-demand capacity. Must be a multiple of 8. Preemptible nodes are cheaper but may be reclaimed when on-demand capacity is needed elsewhere; the system fulfills this asynchronously and surfaces the actual count in allocated_preemptible_gpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_preemptible_gpus")]
        public int? NumPreemptibleGpus { get; set; }

        /// <summary>
        /// Number of prepaid (PLG) reserved GPUs for this cluster. When omitted for RESERVED billing on create, the server defaults this to num_gpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_reserved_gpus")]
        public int? NumReservedGpus { get; set; }

        /// <summary>
        /// Add-ons to enable on the cluster at creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_ons")]
        public global::System.Collections.Generic.IList<global::Together.AddOnCreateRequest>? AddOns { get; set; }

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
        /// Reservation start time of the cluster. This field is required for SCHEDULED billing to specify the reservation start time for the cluster. If not provided, the cluster provisions immediately.
        /// </param>
        /// <param name="reservationEndTime">
        /// Reservation end time of the cluster. This field is required for SCHEDULED billing to specify the reservation end time for the cluster.
        /// </param>
        /// <param name="installTraefik">
        /// Whether to install Traefik ingress controller in the cluster. This field is only applicable for Kubernetes clusters and is false by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cudaVersion">
        /// Legacy CUDA selector for this cluster. Bare semantic values such as 12.5 select ubuntu-22.04; existing OS-suffixed values remain accepted for compatibility. Must be paired with nvidia_driver_version. Prefer nvidia_version_id for new integrations.
        /// </param>
        /// <param name="nvidiaDriverVersion">
        /// Legacy NVIDIA driver selector for this cluster. For example, 550. Must be paired with cuda_version. Prefer nvidia_version_id for new integrations.
        /// </param>
        /// <param name="nvidiaVersionId">
        /// Canonical region-specific NVIDIA version ID. If cuda_version and nvidia_driver_version are also set, they must resolve to the same catalog entry.
        /// </param>
        /// <param name="slurmImage">
        /// Custom Slurm image for Slurm clusters.
        /// </param>
        /// <param name="oidcConfig"></param>
        /// <param name="projectId">
        /// Project ID for the cluster. If not set, the project from the request context is used.
        /// </param>
        /// <param name="acceptanceTestsParams">
        /// AcceptanceTestsParams groups all GPU acceptance test options when enabled is true.
        /// </param>
        /// <param name="clusterConfig"></param>
        /// <param name="numCapacityPoolGpus">
        /// Number of GPUs to allocate from the capacity pool. Must be a multiple of 8 and not exceed num_gpus.
        /// </param>
        /// <param name="autoScale">
        /// Whether to enable auto-scaling for the cluster. If true, the cluster will automatically scale the number of GPU worker nodes between num_gpus and auto_scale_max_gpus based on the workload.
        /// </param>
        /// <param name="numPreemptibleGpus">
        /// Number of preemptible GPUs to request alongside on-demand capacity. Must be a multiple of 8. Preemptible nodes are cheaper but may be reclaimed when on-demand capacity is needed elsewhere; the system fulfills this asynchronously and surfaces the actual count in allocated_preemptible_gpus.
        /// </param>
        /// <param name="numReservedGpus">
        /// Number of prepaid (PLG) reserved GPUs for this cluster. When omitted for RESERVED billing on create, the server defaults this to num_gpus.
        /// </param>
        /// <param name="addOns">
        /// Add-ons to enable on the cluster at creation time.
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
            global::Together.GPUClusterCreateRequestClusterType? clusterType,
            int? durationDays,
            global::Together.GPUClustersSharedVolumeCreateRequest? sharedVolume,
            string? volumeId,
            int? autoScaleMaxGpus,
            int? slurmShmSizeGib,
            string? capacityPoolId,
            global::System.DateTime? reservationStartTime,
            global::System.DateTime? reservationEndTime,
            bool? installTraefik,
            string? cudaVersion,
            string? nvidiaDriverVersion,
            string? nvidiaVersionId,
            string? slurmImage,
            global::Together.OIDCConfig? oidcConfig,
            string? projectId,
            global::Together.AcceptanceTestsParams? acceptanceTestsParams,
            global::Together.InstanceClusterConfig? clusterConfig,
            int? numCapacityPoolGpus,
            bool? autoScale,
            int? numPreemptibleGpus,
            int? numReservedGpus,
            global::System.Collections.Generic.IList<global::Together.AddOnCreateRequest>? addOns)
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
            this.AutoScaleMaxGpus = autoScaleMaxGpus;
            this.SlurmShmSizeGib = slurmShmSizeGib;
            this.CapacityPoolId = capacityPoolId;
            this.ReservationStartTime = reservationStartTime;
            this.ReservationEndTime = reservationEndTime;
            this.InstallTraefik = installTraefik;
            this.CudaVersion = cudaVersion;
            this.NvidiaDriverVersion = nvidiaDriverVersion;
            this.NvidiaVersionId = nvidiaVersionId;
            this.SlurmImage = slurmImage;
            this.OidcConfig = oidcConfig;
            this.ProjectId = projectId;
            this.AcceptanceTestsParams = acceptanceTestsParams;
            this.ClusterConfig = clusterConfig;
            this.NumCapacityPoolGpus = numCapacityPoolGpus;
            this.AutoScale = autoScale;
            this.NumPreemptibleGpus = numPreemptibleGpus;
            this.NumReservedGpus = numReservedGpus;
            this.AddOns = addOns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterCreateRequest" /> class.
        /// </summary>
        public GPUClusterCreateRequest()
        {
        }

    }
}