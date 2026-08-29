
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeShadowExperimentSamplingVariant2
    {
        /// <summary>
        /// Fixed sampling by a sticky request key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyBased")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentKeyBasedSampling KeyBased { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingVariant2" /> class.
        /// </summary>
        /// <param name="keyBased">
        /// Fixed sampling by a sticky request key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentSamplingVariant2(
            global::Together.DeShadowExperimentKeyBasedSampling keyBased)
        {
            this.KeyBased = keyBased ?? throw new global::System.ArgumentNullException(nameof(keyBased));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSamplingVariant2" /> class.
        /// </summary>
        public DeShadowExperimentSamplingVariant2()
        {
        }

    }
}