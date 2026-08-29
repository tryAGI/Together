
#nullable enable

namespace Together
{
    /// <summary>
    /// Fixed-rate sampling of distinct key values with sticky decisions.
    /// </summary>
    public sealed partial class DeShadowExperimentKeyBasedSampling
    {
        /// <summary>
        /// Required fraction of distinct key values to sample, from 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// Required request-body field used as the sticky sampling key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentKeyBasedSampling" /> class.
        /// </summary>
        /// <param name="rate">
        /// Required fraction of distinct key values to sample, from 0.0 to 1.0.
        /// </param>
        /// <param name="key">
        /// Required request-body field used as the sticky sampling key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentKeyBasedSampling(
            double rate,
            string key)
        {
            this.Rate = rate;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentKeyBasedSampling" /> class.
        /// </summary>
        public DeShadowExperimentKeyBasedSampling()
        {
        }

    }
}