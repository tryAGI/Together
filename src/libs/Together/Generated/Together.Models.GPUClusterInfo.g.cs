
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
        public int? DurationHours { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_shm_size_gib")]
        public int? SlurmShmSizeGib { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity_pool_id")]
        public string? CapacityPoolId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_start_time")]
        public global::System.DateTime? ReservationStartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_end_time")]
        public global::System.DateTime? ReservationEndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("install_traefik")]
        public bool? InstallTraefik { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuda_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CudaVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvidia_driver_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NvidiaDriverVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidc_config")]
        public global::Together.OIDCConfig? OidcConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_config")]
        public global::Together.InstanceClusterConfig? ClusterConfig { get; set; }

        /// <summary>
        /// Number of CPU-only worker nodes in the cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_cpu_workers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumCpuWorkers { get; set; }

        /// <summary>
        /// Cluster-level phase transition history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase_transitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.ClusterPhaseTransition> PhaseTransitions { get; set; }

        /// <summary>
        /// Customer's requested number of preemptible GPUs. Set on cluster create or update; persists until changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_preemptible_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DesiredPreemptibleGpus { get; set; }

        /// <summary>
        /// Actual number of preemptible GPUs currently allocated to the cluster. Updated asynchronously by the fulfillment and reclamation workers; may be less than desired_preemptible_gpus when capacity is constrained.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocated_preemptible_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AllocatedPreemptibleGpus { get; set; }

        /// <summary>
        /// Billing type for the cluster (RESERVED, ON_DEMAND, or SCHEDULED_CAPACITY).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterInfoBillingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GPUClusterInfoBillingType BillingType { get; set; }

        /// <summary>
        /// Enabled add-ons on this cluster. Only add-ons with enabled=true in their config are returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_ons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.AddOnInfo> AddOns { get; set; }

        /// <summary>
        /// ID of the machine cluster backing this GPU cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_cluster_id")]
        public string? MachineClusterId { get; set; }

        /// <summary>
        /// Timestamp when the cluster first reached the Ready phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_ready_at")]
        public global::System.DateTime? FirstReadyAt { get; set; }

        /// <summary>
        /// Whether the cluster is managed inside a substrate environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_in_substrate")]
        public bool? IsInSubstrate { get; set; }

        /// <summary>
        /// Whether the control plane is currently ready.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_plane_ready")]
        public bool? ControlPlaneReady { get; set; }

        /// <summary>
        /// UMS project ID associated with this cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ums_project_id")]
        public string? UmsProjectId { get; set; }

        /// <summary>
        /// UMS organization ID associated with this cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ums_org_id")]
        public string? UmsOrgId { get; set; }

        /// <summary>
        /// Data-volume image name for GPU worker nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os_image")]
        public string? OsImage { get; set; }

        /// <summary>
        /// Internal NVIDIA version ID for this cluster's driver and CUDA combination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvidia_driver_version_id")]
        public string? NvidiaDriverVersionId { get; set; }

        /// <summary>
        /// Number of GPUs to draw from a capacity pool. A component of the overall num_gpus, alongside num_reserved_gpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_capacity_pool_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumCapacityPoolGpus { get; set; }

        /// <summary>
        /// Number of prepaid reserved GPUs for this cluster. A component of the overall num_gpus, alongside num_capacity_pool_gpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_reserved_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumReservedGpus { get; set; }

        /// <summary>
        /// GPU worker nodes retained after they left the live data plane. These are separate from gpu_worker_nodes and must not be counted as live capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_gpu_worker_nodes")]
        public global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode>? DeletedGpuWorkerNodes { get; set; }

        /// <summary>
        /// Recent node lifecycle events such as scale-up, scale-down, and preemption. Combine these with live and deleted node lists to render the cluster timeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_lifecycle_events")]
        public global::System.Collections.Generic.IList<global::Together.GPUClusterNodeLifecycleEvent>? NodeLifecycleEvents { get; set; }

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
        /// <param name="volumes"></param>
        /// <param name="status">
        /// Current status of the GPU cluster.
        /// </param>
        /// <param name="controlPlaneNodes"></param>
        /// <param name="gpuWorkerNodes"></param>
        /// <param name="kubeConfig"></param>
        /// <param name="numGpus"></param>
        /// <param name="cudaVersion"></param>
        /// <param name="nvidiaDriverVersion"></param>
        /// <param name="projectId"></param>
        /// <param name="numCpuWorkers">
        /// Number of CPU-only worker nodes in the cluster.
        /// </param>
        /// <param name="phaseTransitions">
        /// Cluster-level phase transition history.
        /// </param>
        /// <param name="desiredPreemptibleGpus">
        /// Customer's requested number of preemptible GPUs. Set on cluster create or update; persists until changed.
        /// </param>
        /// <param name="allocatedPreemptibleGpus">
        /// Actual number of preemptible GPUs currently allocated to the cluster. Updated asynchronously by the fulfillment and reclamation workers; may be less than desired_preemptible_gpus when capacity is constrained.
        /// </param>
        /// <param name="billingType">
        /// Billing type for the cluster (RESERVED, ON_DEMAND, or SCHEDULED_CAPACITY).
        /// </param>
        /// <param name="addOns">
        /// Enabled add-ons on this cluster. Only add-ons with enabled=true in their config are returned.
        /// </param>
        /// <param name="numCapacityPoolGpus">
        /// Number of GPUs to draw from a capacity pool. A component of the overall num_gpus, alongside num_reserved_gpus.
        /// </param>
        /// <param name="numReservedGpus">
        /// Number of prepaid reserved GPUs for this cluster. A component of the overall num_gpus, alongside num_capacity_pool_gpus.
        /// </param>
        /// <param name="durationHours"></param>
        /// <param name="slurmShmSizeGib"></param>
        /// <param name="capacityPoolId"></param>
        /// <param name="reservationStartTime"></param>
        /// <param name="reservationEndTime"></param>
        /// <param name="installTraefik"></param>
        /// <param name="createdAt"></param>
        /// <param name="oidcConfig"></param>
        /// <param name="clusterConfig"></param>
        /// <param name="machineClusterId">
        /// ID of the machine cluster backing this GPU cluster.
        /// </param>
        /// <param name="firstReadyAt">
        /// Timestamp when the cluster first reached the Ready phase.
        /// </param>
        /// <param name="isInSubstrate">
        /// Whether the cluster is managed inside a substrate environment.
        /// </param>
        /// <param name="controlPlaneReady">
        /// Whether the control plane is currently ready.
        /// </param>
        /// <param name="umsProjectId">
        /// UMS project ID associated with this cluster.
        /// </param>
        /// <param name="umsOrgId">
        /// UMS organization ID associated with this cluster.
        /// </param>
        /// <param name="osImage">
        /// Data-volume image name for GPU worker nodes.
        /// </param>
        /// <param name="nvidiaDriverVersionId">
        /// Internal NVIDIA version ID for this cluster's driver and CUDA combination.
        /// </param>
        /// <param name="deletedGpuWorkerNodes">
        /// GPU worker nodes retained after they left the live data plane. These are separate from gpu_worker_nodes and must not be counted as live capacity.
        /// </param>
        /// <param name="nodeLifecycleEvents">
        /// Recent node lifecycle events such as scale-up, scale-down, and preemption. Combine these with live and deleted node lists to render the cluster timeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterInfo(
            string clusterId,
            global::Together.GPUClusterInfoClusterType clusterType,
            string region,
            global::Together.GPUClusterInfoGpuType gpuType,
            string clusterName,
            global::System.Collections.Generic.IList<global::Together.GPUClusterVolume> volumes,
            global::Together.GPUClusterInfoStatus status,
            global::System.Collections.Generic.IList<global::Together.GPUClusterControlPlaneNode> controlPlaneNodes,
            global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode> gpuWorkerNodes,
            string kubeConfig,
            int numGpus,
            string cudaVersion,
            string nvidiaDriverVersion,
            string projectId,
            int numCpuWorkers,
            global::System.Collections.Generic.IList<global::Together.ClusterPhaseTransition> phaseTransitions,
            int desiredPreemptibleGpus,
            int allocatedPreemptibleGpus,
            global::Together.GPUClusterInfoBillingType billingType,
            global::System.Collections.Generic.IList<global::Together.AddOnInfo> addOns,
            int numCapacityPoolGpus,
            int numReservedGpus,
            int? durationHours,
            int? slurmShmSizeGib,
            string? capacityPoolId,
            global::System.DateTime? reservationStartTime,
            global::System.DateTime? reservationEndTime,
            bool? installTraefik,
            global::System.DateTime? createdAt,
            global::Together.OIDCConfig? oidcConfig,
            global::Together.InstanceClusterConfig? clusterConfig,
            string? machineClusterId,
            global::System.DateTime? firstReadyAt,
            bool? isInSubstrate,
            bool? controlPlaneReady,
            string? umsProjectId,
            string? umsOrgId,
            string? osImage,
            string? nvidiaDriverVersionId,
            global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode>? deletedGpuWorkerNodes,
            global::System.Collections.Generic.IList<global::Together.GPUClusterNodeLifecycleEvent>? nodeLifecycleEvents)
        {
            this.ClusterId = clusterId ?? throw new global::System.ArgumentNullException(nameof(clusterId));
            this.ClusterType = clusterType;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.GpuType = gpuType;
            this.ClusterName = clusterName ?? throw new global::System.ArgumentNullException(nameof(clusterName));
            this.DurationHours = durationHours;
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
            this.Status = status;
            this.ControlPlaneNodes = controlPlaneNodes ?? throw new global::System.ArgumentNullException(nameof(controlPlaneNodes));
            this.GpuWorkerNodes = gpuWorkerNodes ?? throw new global::System.ArgumentNullException(nameof(gpuWorkerNodes));
            this.KubeConfig = kubeConfig ?? throw new global::System.ArgumentNullException(nameof(kubeConfig));
            this.NumGpus = numGpus;
            this.SlurmShmSizeGib = slurmShmSizeGib;
            this.CapacityPoolId = capacityPoolId;
            this.ReservationStartTime = reservationStartTime;
            this.ReservationEndTime = reservationEndTime;
            this.InstallTraefik = installTraefik;
            this.CudaVersion = cudaVersion ?? throw new global::System.ArgumentNullException(nameof(cudaVersion));
            this.NvidiaDriverVersion = nvidiaDriverVersion ?? throw new global::System.ArgumentNullException(nameof(nvidiaDriverVersion));
            this.CreatedAt = createdAt;
            this.OidcConfig = oidcConfig;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ClusterConfig = clusterConfig;
            this.NumCpuWorkers = numCpuWorkers;
            this.PhaseTransitions = phaseTransitions ?? throw new global::System.ArgumentNullException(nameof(phaseTransitions));
            this.DesiredPreemptibleGpus = desiredPreemptibleGpus;
            this.AllocatedPreemptibleGpus = allocatedPreemptibleGpus;
            this.BillingType = billingType;
            this.AddOns = addOns ?? throw new global::System.ArgumentNullException(nameof(addOns));
            this.MachineClusterId = machineClusterId;
            this.FirstReadyAt = firstReadyAt;
            this.IsInSubstrate = isInSubstrate;
            this.ControlPlaneReady = controlPlaneReady;
            this.UmsProjectId = umsProjectId;
            this.UmsOrgId = umsOrgId;
            this.OsImage = osImage;
            this.NvidiaDriverVersionId = nvidiaDriverVersionId;
            this.NumCapacityPoolGpus = numCapacityPoolGpus;
            this.NumReservedGpus = numReservedGpus;
            this.DeletedGpuWorkerNodes = deletedGpuWorkerNodes;
            this.NodeLifecycleEvents = nodeLifecycleEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterInfo" /> class.
        /// </summary>
        public GPUClusterInfo()
        {
        }

    }
}