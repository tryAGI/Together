
#nullable enable

namespace Together
{
    /// <summary>
    /// GPU Cluster create request
    /// </summary>
    public sealed partial class GPUClusterCreateRequest
    {
        /// <summary>
        /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
        /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.GPUClusterCreateRequestBillingType BillingType { get; set; } = default!;

        /// <summary>
        /// Name of the GPU cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ClusterName { get; set; } = default!;

        /// <summary>
        /// Type of cluster to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeJsonConverter))]
        public global::Together.GPUClusterCreateRequestClusterType? ClusterType { get; set; }

        /// <summary>
        /// NVIDIA driver version to use in the cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterCreateRequestDriverVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.GPUClusterCreateRequestDriverVersion DriverVersion { get; set; } = default!;

        /// <summary>
        /// Duration in days to keep the cluster running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_days")]
        public int? DurationDays { get; set; }

        /// <summary>
        /// Type of GPU to use in the cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.GPUClusterCreateRequestGpuType GpuType { get; set; } = default!;

        /// <summary>
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int NumGpus { get; set; } = default!;

        /// <summary>
        /// Region to create the GPU cluster in. Usable regions can be found from `client.clusters.list_regions()`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Region { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_volume")]
        public global::Together.GPUClustersSharedVolumeCreateRequest? SharedVolume { get; set; }

        /// <summary>
        /// ID of an existing volume to use with the cluster creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_id")]
        public string? VolumeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterCreateRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterCreateRequest(
            global::Together.GPUClusterCreateRequestBillingType billingType,
            string clusterName,
            global::Together.GPUClusterCreateRequestDriverVersion driverVersion,
            global::Together.GPUClusterCreateRequestGpuType gpuType,
            int numGpus,
            string region,
            global::Together.GPUClusterCreateRequestClusterType? clusterType,
            int? durationDays,
            global::Together.GPUClustersSharedVolumeCreateRequest? sharedVolume,
            string? volumeId)
        {
            this.BillingType = billingType;
            this.ClusterName = clusterName ?? throw new global::System.ArgumentNullException(nameof(clusterName));
            this.DriverVersion = driverVersion;
            this.GpuType = gpuType;
            this.NumGpus = numGpus;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ClusterType = clusterType;
            this.DurationDays = durationDays;
            this.SharedVolume = sharedVolume;
            this.VolumeId = volumeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterCreateRequest" /> class.
        /// </summary>
        public GPUClusterCreateRequest()
        {
        }
    }
}