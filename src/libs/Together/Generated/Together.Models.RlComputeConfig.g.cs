
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlComputeConfig(
            int numGeneratorReplicas)
        {
            this.NumGeneratorReplicas = numGeneratorReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlComputeConfig" /> class.
        /// </summary>
        public RlComputeConfig()
        {
        }

    }
}