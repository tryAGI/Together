
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeShadowExperimentSamplingVariant4
    {
        /// <summary>
        /// Adaptive sticky-key sampling toward a target QPS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptiveKeyBased")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentAdaptiveKeyBasedSampling AdaptiveKeyBased { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingVariant4" /> class.
        /// </summary>
        /// <param name="adaptiveKeyBased">
        /// Adaptive sticky-key sampling toward a target QPS.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentSamplingVariant4(
            global::Together.DeShadowExperimentAdaptiveKeyBasedSampling adaptiveKeyBased)
        {
            this.AdaptiveKeyBased = adaptiveKeyBased ?? throw new global::System.ArgumentNullException(nameof(adaptiveKeyBased));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingVariant4" /> class.
        /// </summary>
        public DeShadowExperimentSamplingVariant4()
        {
        }

    }
}