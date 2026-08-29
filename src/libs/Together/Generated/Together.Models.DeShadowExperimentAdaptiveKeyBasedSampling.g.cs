
#nullable enable

namespace Together
{
    /// <summary>
    /// Adaptive sticky-key sampling that throttles toward a target QPS.
    /// </summary>
    public sealed partial class DeShadowExperimentAdaptiveKeyBasedSampling
    {
        /// <summary>
        /// Required per-gateway-replica target QPS for adaptive sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetQps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TargetQps { get; set; }

        /// <summary>
        /// Required request-body field used as the sticky sampling key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

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
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveKeyBasedSampling" /> class.
        /// </summary>
        /// <param name="targetQps">
        /// Required per-gateway-replica target QPS for adaptive sampling.
        /// </param>
        /// <param name="key">
        /// Required request-body field used as the sticky sampling key.
        /// </param>
        /// <param name="window">
        /// Optional sliding window for QPS observation. Defaults to 60s and must not be negative.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentAdaptiveKeyBasedSampling(
            double targetQps,
            string key,
            string? window)
        {
            this.TargetQps = targetQps;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveKeyBasedSampling" /> class.
        /// </summary>
        public DeShadowExperimentAdaptiveKeyBasedSampling()
        {
        }

    }
}