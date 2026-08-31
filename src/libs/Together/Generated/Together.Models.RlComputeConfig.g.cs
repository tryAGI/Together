
#nullable enable

namespace Together
{
    /// <summary>
    /// Compute layout for a model resource
    /// </summary>
    public sealed partial class RlComputeConfig
    {
        /// <summary>
        /// Number of generator replicas. 0 means the resource runs the trainer only, with no generator.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_generator_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumGeneratorReplicas { get; set; }

        /// <summary>
        /// GPU type selected for this resource.<br/>
        /// Example: H100-80GB
        /// </summary>
        /// <example>H100-80GB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlComputeConfigGpuTypeJsonConverter))]
        public global::Together.RlComputeConfigGpuType? GpuType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlComputeConfig" /> class.
        /// </summary>
        /// <param name="numGeneratorReplicas">
        /// Number of generator replicas. 0 means the resource runs the trainer only, with no generator.<br/>
        /// Example: 1
        /// </param>
        /// <param name="gpuType">
        /// GPU type selected for this resource.<br/>
        /// Example: H100-80GB
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlComputeConfig(
            int numGeneratorReplicas,
            global::Together.RlComputeConfigGpuType? gpuType)
        {
            this.NumGeneratorReplicas = numGeneratorReplicas;
            this.GpuType = gpuType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlComputeConfig" /> class.
        /// </summary>
        public RlComputeConfig()
        {
        }

    }
}