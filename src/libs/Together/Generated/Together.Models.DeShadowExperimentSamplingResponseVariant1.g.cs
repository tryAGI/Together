
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeShadowExperimentSamplingResponseVariant1
    {
        /// <summary>
        /// Fixed random request sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentUniformSamplingResponse Uniform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingResponseVariant1" /> class.
        /// </summary>
        /// <param name="uniform">
        /// Fixed random request sampling.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentSamplingResponseVariant1(
            global::Together.DeShadowExperimentUniformSamplingResponse uniform)
        {
            this.Uniform = uniform ?? throw new global::System.ArgumentNullException(nameof(uniform));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingResponseVariant1" /> class.
        /// </summary>
        public DeShadowExperimentSamplingResponseVariant1()
        {
        }

    }
}