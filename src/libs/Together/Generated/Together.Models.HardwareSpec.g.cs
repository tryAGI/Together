
#nullable enable

namespace Together
{
    /// <summary>
    /// Detailed specifications of a hardware configuration
    /// </summary>
    public sealed partial class HardwareSpec
    {
        /// <summary>
        /// Number of GPUs in this configuration<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GpuCount { get; set; }

        /// <summary>
        /// The GPU interconnect technology<br/>
        /// Example: sxm
        /// </summary>
        /// <example>sxm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuLink { get; set; }

        /// <summary>
        /// Amount of GPU memory in GB<br/>
        /// Example: 80F
        /// </summary>
        /// <example>80F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float GpuMemory { get; set; }

        /// <summary>
        /// The type/model of GPU<br/>
        /// Example: a100-80gb
        /// </summary>
        /// <example>a100-80gb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareSpec" /> class.
        /// </summary>
        /// <param name="gpuCount">
        /// Number of GPUs in this configuration<br/>
        /// Example: 2
        /// </param>
        /// <param name="gpuLink">
        /// The GPU interconnect technology<br/>
        /// Example: sxm
        /// </param>
        /// <param name="gpuMemory">
        /// Amount of GPU memory in GB<br/>
        /// Example: 80F
        /// </param>
        /// <param name="gpuType">
        /// The type/model of GPU<br/>
        /// Example: a100-80gb
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareSpec(
            int gpuCount,
            string gpuLink,
            float gpuMemory,
            string gpuType)
        {
            this.GpuCount = gpuCount;
            this.GpuLink = gpuLink ?? throw new global::System.ArgumentNullException(nameof(gpuLink));
            this.GpuMemory = gpuMemory;
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareSpec" /> class.
        /// </summary>
        public HardwareSpec()
        {
        }
    }
}