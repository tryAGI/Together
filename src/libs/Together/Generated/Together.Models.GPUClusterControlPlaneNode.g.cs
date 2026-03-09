
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClusterControlPlaneNode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string HostName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_gib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double MemoryGib { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Network { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string NodeName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_cpu_cores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int NumCpuCores { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterControlPlaneNode" /> class.
        /// </summary>
        /// <param name="hostName"></param>
        /// <param name="memoryGib"></param>
        /// <param name="network"></param>
        /// <param name="nodeId"></param>
        /// <param name="nodeName"></param>
        /// <param name="numCpuCores"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterControlPlaneNode(
            string hostName,
            double memoryGib,
            string network,
            string nodeId,
            string nodeName,
            int numCpuCores,
            string status)
        {
            this.HostName = hostName ?? throw new global::System.ArgumentNullException(nameof(hostName));
            this.MemoryGib = memoryGib;
            this.Network = network ?? throw new global::System.ArgumentNullException(nameof(network));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NodeName = nodeName ?? throw new global::System.ArgumentNullException(nameof(nodeName));
            this.NumCpuCores = numCpuCores;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterControlPlaneNode" /> class.
        /// </summary>
        public GPUClusterControlPlaneNode()
        {
        }
    }
}