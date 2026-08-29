
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeShadowExperimentSamplingVariant3
    {
        /// <summary>
        /// Adaptive random sampling toward a target QPS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptiveUniform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentAdaptiveUniformSampling AdaptiveUniform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingVariant3" /> class.
        /// </summary>
        /// <param name="adaptiveUniform">
        /// Adaptive random sampling toward a target QPS.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentSamplingVariant3(
            global::Together.DeShadowExperimentAdaptiveUniformSampling adaptiveUniform)
        {
            this.AdaptiveUniform = adaptiveUniform ?? throw new global::System.ArgumentNullException(nameof(adaptiveUniform));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingVariant3" /> class.
        /// </summary>
        public DeShadowExperimentSamplingVariant3()
        {
        }

    }
}