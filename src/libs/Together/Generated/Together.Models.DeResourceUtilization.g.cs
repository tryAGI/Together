
#nullable enable

namespace Together
{
    /// <summary>
    /// Average compute, memory, and network utilization for replicas over a time range.
    /// </summary>
    public sealed partial class DeResourceUtilization
    {
        /// <summary>
        /// Average CPU utilization across replicas, as a percentage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuUtilization")]
        public double? CpuUtilization { get; set; }

        /// <summary>
        /// Average GPU compute utilization across replicas, as a percentage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuUtilization")]
        public double? GpuUtilization { get; set; }

        /// <summary>
        /// Average system memory utilization across replicas, as a percentage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryUtilization")]
        public double? MemoryUtilization { get; set; }

        /// <summary>
        /// Average GPU memory utilization across replicas, as a percentage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuMemoryUtilization")]
        public double? GpuMemoryUtilization { get; set; }

        /// <summary>
        /// Average network throughput across replicas, in megabits per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkBandwidthMbps")]
        public double? NetworkBandwidthMbps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeResourceUtilization" /> class.
        /// </summary>
        /// <param name="cpuUtilization">
        /// Average CPU utilization across replicas, as a percentage.
        /// </param>
        /// <param name="gpuUtilization">
        /// Average GPU compute utilization across replicas, as a percentage.
        /// </param>
        /// <param name="memoryUtilization">
        /// Average system memory utilization across replicas, as a percentage.
        /// </param>
        /// <param name="gpuMemoryUtilization">
        /// Average GPU memory utilization across replicas, as a percentage.
        /// </param>
        /// <param name="networkBandwidthMbps">
        /// Average network throughput across replicas, in megabits per second.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeResourceUtilization(
            double? cpuUtilization,
            double? gpuUtilization,
            double? memoryUtilization,
            double? gpuMemoryUtilization,
            double? networkBandwidthMbps)
        {
            this.CpuUtilization = cpuUtilization;
            this.GpuUtilization = gpuUtilization;
            this.MemoryUtilization = memoryUtilization;
            this.GpuMemoryUtilization = gpuMemoryUtilization;
            this.NetworkBandwidthMbps = networkBandwidthMbps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeResourceUtilization" /> class.
        /// </summary>
        public DeResourceUtilization()
        {
        }

    }
}