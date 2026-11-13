
#nullable enable

namespace Together
{
    /// <summary>
    /// Compute layout to provision for a model resource
    /// </summary>
    public sealed partial class RlComputeConfigCreateRequest
    {
        /// <summary>
        /// Number of generator replicas. 0 runs the trainer only, with no generator.<br/>
        /// Default Value: 1<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_generator_replicas")]
        public int? NumGeneratorReplicas { get; set; }

        /// <summary>
        /// GPU type to provision. Omit to use the model's default GPU type.<br/>
        /// Example: B200-SXM
        /// </summary>
        /// <example>B200-SXM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlComputeConfigCreateRequestGpuTypeJsonConverter))]
        public global::Together.RlComputeConfigCreateRequestGpuType? GpuType { get; set; }

        /// <summary>
        /// Number of trainers: 0 or 1. Omit to use 1. Each trainer can use multiple GPUs. With 0, at least one generator replica is required, optimizer_config is not allowed, and sessions must resume from an inference checkpoint for sampling only.<br/>
        /// Default Value: 1<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_trainer_replicas")]
        public int? NumTrainerReplicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlComputeConfigCreateRequest" /> class.
        /// </summary>
        /// <param name="numGeneratorReplicas">
        /// Number of generator replicas. 0 runs the trainer only, with no generator.<br/>
        /// Default Value: 1<br/>
        /// Example: 2
        /// </param>
        /// <param name="gpuType">
        /// GPU type to provision. Omit to use the model's default GPU type.<br/>
        /// Example: B200-SXM
        /// </param>
        /// <param name="numTrainerReplicas">
        /// Number of trainers: 0 or 1. Omit to use 1. Each trainer can use multiple GPUs. With 0, at least one generator replica is required, optimizer_config is not allowed, and sessions must resume from an inference checkpoint for sampling only.<br/>
        /// Default Value: 1<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlComputeConfigCreateRequest(
            int? numGeneratorReplicas,
            global::Together.RlComputeConfigCreateRequestGpuType? gpuType,
            int? numTrainerReplicas)
        {
            this.NumGeneratorReplicas = numGeneratorReplicas;
            this.GpuType = gpuType;
            this.NumTrainerReplicas = numTrainerReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlComputeConfigCreateRequest" /> class.
        /// </summary>
        public RlComputeConfigCreateRequest()
        {
        }

    }
}