
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
        [global::System.Text.Json.Serialization.JsonPropertyName("node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeName { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterGPUWorkerNode" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="nodeName"></param>
        /// <param name="status"></param>
        /// <param name="hostName"></param>
        /// <param name="numCpuCores"></param>
        /// <param name="numGpus"></param>
        /// <param name="memoryGib"></param>
        /// <param name="networks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterGPUWorkerNode(
            string nodeId,
            string nodeName,
            string status,
            string hostName,
            int numCpuCores,
            int numGpus,
            double memoryGib,
            global::System.Collections.Generic.IList<string> networks)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NodeName = nodeName ?? throw new global::System.ArgumentNullException(nameof(nodeName));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.HostName = hostName ?? throw new global::System.ArgumentNullException(nameof(hostName));
            this.NumCpuCores = numCpuCores;
            this.NumGpus = numGpus;
            this.MemoryGib = memoryGib;
            this.Networks = networks ?? throw new global::System.ArgumentNullException(nameof(networks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterGPUWorkerNode" /> class.
        /// </summary>
        public GPUClusterGPUWorkerNode()
        {
        }
    }
}