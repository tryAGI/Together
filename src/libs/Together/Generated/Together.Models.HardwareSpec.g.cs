
#nullable enable

namespace Together
{
    /// <summary>
    /// Detailed specifications of a hardware configuration
    /// </summary>
    public sealed partial class HardwareSpec
    {
        /// <summary>
        /// The type/model of GPU
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// The GPU interconnect technology
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuLink { get; set; }

        /// <summary>
        /// Amount of GPU memory in GB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float GpuMemory { get; set; }

        /// <summary>
        /// Number of GPUs in this configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GpuCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareSpec" /> class.
        /// </summary>
        /// <param name="gpuType">
        /// The type/model of GPU
        /// </param>
        /// <param name="gpuLink">
        /// The GPU interconnect technology
        /// </param>
        /// <param name="gpuMemory">
        /// Amount of GPU memory in GB
        /// </param>
        /// <param name="gpuCount">
        /// Number of GPUs in this configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareSpec(
            string gpuType,
            string gpuLink,
            float gpuMemory,
            int gpuCount)
        {
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.GpuLink = gpuLink ?? throw new global::System.ArgumentNullException(nameof(gpuLink));
            this.GpuMemory = gpuMemory;
            this.GpuCount = gpuCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareSpec" /> class.
        /// </summary>
        public HardwareSpec()
        {
        }
    }
}