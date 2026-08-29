
#nullable enable

namespace Together
{
    /// <summary>
    /// Fixed-rate random sampling of endpoint requests.
    /// </summary>
    public sealed partial class DeShadowExperimentUniformSampling
    {
        /// <summary>
        /// Required fraction of requests to sample, from 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentUniformSampling" /> class.
        /// </summary>
        /// <param name="rate">
        /// Required fraction of requests to sample, from 0.0 to 1.0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentUniformSampling(
            double rate)
        {
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentUniformSampling" /> class.
        /// </summary>
        public DeShadowExperimentUniformSampling()
        {
        }

    }
}