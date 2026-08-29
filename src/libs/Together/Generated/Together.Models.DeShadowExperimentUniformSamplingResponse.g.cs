
#nullable enable

namespace Together
{
    /// <summary>
    /// Fixed-rate random sampling returned by the API. A zero rate may be omitted by JSON serialization.
    /// </summary>
    public sealed partial class DeShadowExperimentUniformSamplingResponse
    {
        /// <summary>
        /// Fraction of requests sampled, from 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentUniformSamplingResponse" /> class.
        /// </summary>
        /// <param name="rate">
        /// Fraction of requests sampled, from 0.0 to 1.0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentUniformSamplingResponse(
            double? rate)
        {
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentUniformSamplingResponse" /> class.
        /// </summary>
        public DeShadowExperimentUniformSamplingResponse()
        {
        }

    }
}