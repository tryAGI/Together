
#nullable enable

namespace Together
{
    /// <summary>
    /// Inference capabilities and limits for a model on one GPU type. If present, the model can be provisioned with one or more generator replicas.
    /// </summary>
    public sealed partial class RlModelGeneratorConfig
    {
        /// <summary>
        /// Maximum tokens in a single inference request (prompt + completion)<br/>
        /// Example: 40960
        /// </summary>
        /// <example>40960</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Default sampling parameters used for sample requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_defaults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlModelSamplingDefaults SamplingDefaults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelGeneratorConfig" /> class.
        /// </summary>
        /// <param name="contextLength">
        /// Maximum tokens in a single inference request (prompt + completion)<br/>
        /// Example: 40960
        /// </param>
        /// <param name="samplingDefaults">
        /// Default sampling parameters used for sample requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelGeneratorConfig(
            int contextLength,
            global::Together.RlModelSamplingDefaults samplingDefaults)
        {
            this.ContextLength = contextLength;
            this.SamplingDefaults = samplingDefaults ?? throw new global::System.ArgumentNullException(nameof(samplingDefaults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelGeneratorConfig" /> class.
        /// </summary>
        public RlModelGeneratorConfig()
        {
        }

    }
}