
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GPUClusterGPUWorkerNode
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HostName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_cpu_cores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumCpuCores { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumGpus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_gib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MemoryGib { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Networks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        public string? InstanceId { get; set; }

        /// <summary>
        /// Remediation represents a node remediation request for an instance.<br/>
        /// An instance can have multiple remediations over time (e.g., failed attempts followed by retries).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_remediation")]
        public global::Together.Remediation? LatestRemediation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_worker_hostname")]
        public string? SlurmWorkerHostname { get; set; }

        /// <summary>
        /// Phase transition history for this GPU worker node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase_transitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.NodePhaseTransition> PhaseTransitions { get; set; }

        /// <summary>
        /// Whether this node is marked for deletion by the operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marked_for_deletion")]
        public bool? MarkedForDeletion { get; set; }

        /// <summary>
        /// Public IPv4 address of the GPU worker node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_ipv4")]
        public string? PublicIpv4 { get; set; }

        /// <summary>
        /// InfiniBand HCA type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ib_hca_type")]
        public string? IbHcaType { get; set; }

        /// <summary>
        /// Number of InfiniBand HCAs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ib_hca_count")]
        public int? IbHcaCount { get; set; }

        /// <summary>
        /// Number of NVSwitches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvswitch_count")]
        public int? NvswitchCount { get; set; }

        /// <summary>
        /// NVSwitch type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvswitch_type")]
        public string? NvswitchType { get; set; }

        /// <summary>
        /// Ephemeral storage size, such as 1Ti.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_storage")]
        public string? EphemeralStorage { get; set; }

        /// <summary>
        /// Whether auto-remediation is enabled for this node's instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_remediation_enabled")]
        public bool? AutoRemediationEnabled { get; set; }

        /// <summary>
        /// Timestamp when the node left the live data plane. Only set for deleted_gpu_worker_nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterGPUWorkerNode" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="status"></param>
        /// <param name="hostName"></param>
        /// <param name="numCpuCores"></param>
        /// <param name="numGpus"></param>
        /// <param name="memoryGib"></param>
        /// <param name="networks"></param>
        /// <param name="phaseTransitions">
        /// Phase transition history for this GPU worker node.
        /// </param>
        /// <param name="instanceId"></param>
        /// <param name="latestRemediation">
        /// Remediation represents a node remediation request for an instance.<br/>
        /// An instance can have multiple remediations over time (e.g., failed attempts followed by retries).
        /// </param>
        /// <param name="slurmWorkerHostname"></param>
        /// <param name="markedForDeletion">
        /// Whether this node is marked for deletion by the operator.
        /// </param>
        /// <param name="publicIpv4">
        /// Public IPv4 address of the GPU worker node.
        /// </param>
        /// <param name="ibHcaType">
        /// InfiniBand HCA type.
        /// </param>
        /// <param name="ibHcaCount">
        /// Number of InfiniBand HCAs.
        /// </param>
        /// <param name="nvswitchCount">
        /// Number of NVSwitches.
        /// </param>
        /// <param name="nvswitchType">
        /// NVSwitch type.
        /// </param>
        /// <param name="ephemeralStorage">
        /// Ephemeral storage size, such as 1Ti.
        /// </param>
        /// <param name="autoRemediationEnabled">
        /// Whether auto-remediation is enabled for this node's instance.
        /// </param>
        /// <param name="deletedAt">
        /// Timestamp when the node left the live data plane. Only set for deleted_gpu_worker_nodes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterGPUWorkerNode(
            string nodeId,
            string status,
            string hostName,
            int numCpuCores,
            int numGpus,
            double memoryGib,
            global::System.Collections.Generic.IList<string> networks,
            global::System.Collections.Generic.IList<global::Together.NodePhaseTransition> phaseTransitions,
            string? instanceId,
            global::Together.Remediation? latestRemediation,
            string? slurmWorkerHostname,
            bool? markedForDeletion,
            string? publicIpv4,
            string? ibHcaType,
            int? ibHcaCount,
            int? nvswitchCount,
            string? nvswitchType,
            string? ephemeralStorage,
            bool? autoRemediationEnabled,
            global::System.DateTime? deletedAt)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.HostName = hostName ?? throw new global::System.ArgumentNullException(nameof(hostName));
            this.NumCpuCores = numCpuCores;
            this.NumGpus = numGpus;
            this.MemoryGib = memoryGib;
            this.Networks = networks ?? throw new global::System.ArgumentNullException(nameof(networks));
            this.InstanceId = instanceId;
            this.LatestRemediation = latestRemediation;
            this.SlurmWorkerHostname = slurmWorkerHostname;
            this.PhaseTransitions = phaseTransitions ?? throw new global::System.ArgumentNullException(nameof(phaseTransitions));
            this.MarkedForDeletion = markedForDeletion;
            this.PublicIpv4 = publicIpv4;
            this.IbHcaType = ibHcaType;
            this.IbHcaCount = ibHcaCount;
            this.NvswitchCount = nvswitchCount;
            this.NvswitchType = nvswitchType;
            this.EphemeralStorage = ephemeralStorage;
            this.AutoRemediationEnabled = autoRemediationEnabled;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterGPUWorkerNode" /> class.
        /// </summary>
        public GPUClusterGPUWorkerNode()
        {
        }

    }
}