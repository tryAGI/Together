
#nullable enable

namespace Together
{
    /// <summary>
    /// AcceptanceTestsParams groups all GPU acceptance test options when enabled is true.
    /// </summary>
    public sealed partial class AcceptanceTestsParams
    {
        /// <summary>
        /// Whether to run GPU acceptance tests during cluster bring-up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// DCGM diagnostic depth. SHORT = readiness; MEDIUM = default; LONG = system validation; EXTENDED = memtest. An omitted value selects MEDIUM when enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dcgm_diag_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AcceptanceTestsParamsDcgmDiagLevelJsonConverter))]
        public global::Together.AcceptanceTestsParamsDcgmDiagLevel? DcgmDiagLevel { get; set; }

        /// <summary>
        /// GPU burn duration in seconds; 0 means use the default when enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_burn_duration")]
        public int? GpuBurnDuration { get; set; }

        /// <summary>
        /// Skip NCCL single-node acceptance test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nccl_single_node_skipped")]
        public bool? NcclSingleNodeSkipped { get; set; }

        /// <summary>
        /// Skip GPU burn acceptance test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_burn_skipped")]
        public bool? GpuBurnSkipped { get; set; }

        /// <summary>
        /// Skip DCGM diagnostics acceptance test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dcgm_diag_skipped")]
        public bool? DcgmDiagSkipped { get; set; }

        /// <summary>
        /// Skip NCCL multi-node acceptance test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nccl_multi_node_skipped")]
        public bool? NcclMultiNodeSkipped { get; set; }

        /// <summary>
        /// Skip storage-performance acceptance test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_skipped")]
        public bool? StorageSkipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptanceTestsParams" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to run GPU acceptance tests during cluster bring-up.
        /// </param>
        /// <param name="dcgmDiagLevel">
        /// DCGM diagnostic depth. SHORT = readiness; MEDIUM = default; LONG = system validation; EXTENDED = memtest. An omitted value selects MEDIUM when enabled.
        /// </param>
        /// <param name="gpuBurnDuration">
        /// GPU burn duration in seconds; 0 means use the default when enabled.
        /// </param>
        /// <param name="ncclSingleNodeSkipped">
        /// Skip NCCL single-node acceptance test.
        /// </param>
        /// <param name="gpuBurnSkipped">
        /// Skip GPU burn acceptance test.
        /// </param>
        /// <param name="dcgmDiagSkipped">
        /// Skip DCGM diagnostics acceptance test.
        /// </param>
        /// <param name="ncclMultiNodeSkipped">
        /// Skip NCCL multi-node acceptance test.
        /// </param>
        /// <param name="storageSkipped">
        /// Skip storage-performance acceptance test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptanceTestsParams(
            bool? enabled,
            global::Together.AcceptanceTestsParamsDcgmDiagLevel? dcgmDiagLevel,
            int? gpuBurnDuration,
            bool? ncclSingleNodeSkipped,
            bool? gpuBurnSkipped,
            bool? dcgmDiagSkipped,
            bool? ncclMultiNodeSkipped,
            bool? storageSkipped)
        {
            this.Enabled = enabled;
            this.DcgmDiagLevel = dcgmDiagLevel;
            this.GpuBurnDuration = gpuBurnDuration;
            this.NcclSingleNodeSkipped = ncclSingleNodeSkipped;
            this.GpuBurnSkipped = gpuBurnSkipped;
            this.DcgmDiagSkipped = dcgmDiagSkipped;
            this.NcclMultiNodeSkipped = ncclMultiNodeSkipped;
            this.StorageSkipped = storageSkipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptanceTestsParams" /> class.
        /// </summary>
        public AcceptanceTestsParams()
        {
        }

    }
}