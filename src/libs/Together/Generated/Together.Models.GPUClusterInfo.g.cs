
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClusterInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterId { get; set; }

        /// <summary>
        /// Type of cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterInfoClusterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GPUClusterInfoClusterType ClusterType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterInfoGpuTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GPUClusterInfoGpuType GpuType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterInfoDriverVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GPUClusterInfoDriverVersion DriverVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.GPUClusterVolume> Volumes { get; set; }

        /// <summary>
        /// Current status of the GPU cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterInfoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GPUClusterInfoStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_plane_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.GPUClusterControlPlaneNode> ControlPlaneNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_worker_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode> GpuWorkerNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kube_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KubeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumGpus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterInfo" /> class.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="clusterType">
        /// Type of cluster.
        /// </param>
        /// <param name="region"></param>
        /// <param name="gpuType"></param>
        /// <param name="clusterName"></param>
        /// <param name="durationHours"></param>
        /// <param name="driverVersion"></param>
        /// <param name="volumes"></param>
        /// <param name="status">
        /// Current status of the GPU cluster.
        /// </param>
        /// <param name="controlPlaneNodes"></param>
        /// <param name="gpuWorkerNodes"></param>
        /// <param name="kubeConfig"></param>
        /// <param name="numGpus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterInfo(
            string clusterId,
            global::Together.GPUClusterInfoClusterType clusterType,
            string region,
            global::Together.GPUClusterInfoGpuType gpuType,
            string clusterName,
            int durationHours,
            global::Together.GPUClusterInfoDriverVersion driverVersion,
            global::System.Collections.Generic.IList<global::Together.GPUClusterVolume> volumes,
            global::Together.GPUClusterInfoStatus status,
            global::System.Collections.Generic.IList<global::Together.GPUClusterControlPlaneNode> controlPlaneNodes,
            global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode> gpuWorkerNodes,
            string kubeConfig,
            int numGpus)
        {
            this.ClusterId = clusterId ?? throw new global::System.ArgumentNullException(nameof(clusterId));
            this.ClusterType = clusterType;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.GpuType = gpuType;
            this.ClusterName = clusterName ?? throw new global::System.ArgumentNullException(nameof(clusterName));
            this.DurationHours = durationHours;
            this.DriverVersion = driverVersion;
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
            this.Status = status;
            this.ControlPlaneNodes = controlPlaneNodes ?? throw new global::System.ArgumentNullException(nameof(controlPlaneNodes));
            this.GpuWorkerNodes = gpuWorkerNodes ?? throw new global::System.ArgumentNullException(nameof(gpuWorkerNodes));
            this.KubeConfig = kubeConfig ?? throw new global::System.ArgumentNullException(nameof(kubeConfig));
            this.NumGpus = numGpus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterInfo" /> class.
        /// </summary>
        public GPUClusterInfo()
        {
        }
    }
}