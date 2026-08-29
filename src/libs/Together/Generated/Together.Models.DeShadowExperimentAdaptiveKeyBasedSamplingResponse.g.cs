
#nullable enable

namespace Together
{
    /// <summary>
    /// Adaptive sticky-key sampling returned by the API.
    /// </summary>
    public sealed partial class DeShadowExperimentAdaptiveKeyBasedSamplingResponse
    {
        /// <summary>
        /// Per-gateway-replica target QPS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetQps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TargetQps { get; set; }

        /// <summary>
        /// Request-body field used as the sticky sampling key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Sliding window for QPS observation when explicitly configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        public string? Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveKeyBasedSamplingResponse" /> class.
        /// </summary>
        /// <param name="targetQps">
        /// Per-gateway-replica target QPS.
        /// </param>
        /// <param name="key">
        /// Request-body field used as the sticky sampling key.
        /// </param>
        /// <param name="window">
        /// Sliding window for QPS observation when explicitly configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentAdaptiveKeyBasedSamplingResponse(
            double targetQps,
            string key,
            string? window)
        {
            this.TargetQps = targetQps;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveKeyBasedSamplingResponse" /> class.
        /// </summary>
        public DeShadowExperimentAdaptiveKeyBasedSamplingResponse()
        {
        }

    }
}