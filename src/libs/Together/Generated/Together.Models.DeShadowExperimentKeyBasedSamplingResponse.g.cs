
#nullable enable

namespace Together
{
    /// <summary>
    /// Fixed-rate sticky-key sampling returned by the API. A zero rate may be omitted by JSON serialization.
    /// </summary>
    public sealed partial class DeShadowExperimentKeyBasedSamplingResponse
    {
        /// <summary>
        /// Fraction of distinct key values sampled, from 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Request-body field used as the sticky sampling key.
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
        /// Initializes a new instance of the <see cref="DeShadowExperimentKeyBasedSamplingResponse" /> class.
        /// </summary>
        /// <param name="key">
        /// Request-body field used as the sticky sampling key.
        /// </param>
        /// <param name="rate">
        /// Fraction of distinct key values sampled, from 0.0 to 1.0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentKeyBasedSamplingResponse(
            string key,
            double? rate)
        {
            this.Rate = rate;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentKeyBasedSamplingResponse" /> class.
        /// </summary>
        public DeShadowExperimentKeyBasedSamplingResponse()
        {
        }

    }
}