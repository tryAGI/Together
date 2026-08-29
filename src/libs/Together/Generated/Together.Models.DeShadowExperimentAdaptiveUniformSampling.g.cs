
#nullable enable

namespace Together
{
    /// <summary>
    /// Adaptive random sampling that throttles toward a target QPS.
    /// </summary>
    public sealed partial class DeShadowExperimentAdaptiveUniformSampling
    {
        /// <summary>
        /// Required per-gateway-replica target QPS for adaptive sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetQps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TargetQps { get; set; }

        /// <summary>
        /// Optional sliding window for QPS observation. Defaults to 60s and must not be negative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        public string? Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveUniformSampling" /> class.
        /// </summary>
        /// <param name="targetQps">
        /// Required per-gateway-replica target QPS for adaptive sampling.
        /// </param>
        /// <param name="window">
        /// Optional sliding window for QPS observation. Defaults to 60s and must not be negative.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentAdaptiveUniformSampling(
            double targetQps,
            string? window)
        {
            this.TargetQps = targetQps;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveUniformSampling" /> class.
        /// </summary>
        public DeShadowExperimentAdaptiveUniformSampling()
        {
        }

    }
}