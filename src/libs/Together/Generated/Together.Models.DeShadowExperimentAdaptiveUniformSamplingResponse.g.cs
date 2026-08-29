
#nullable enable

namespace Together
{
    /// <summary>
    /// Adaptive random sampling returned by the API.
    /// </summary>
    public sealed partial class DeShadowExperimentAdaptiveUniformSamplingResponse
    {
        /// <summary>
        /// Per-gateway-replica target QPS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetQps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TargetQps { get; set; }

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
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveUniformSamplingResponse" /> class.
        /// </summary>
        /// <param name="targetQps">
        /// Per-gateway-replica target QPS.
        /// </param>
        /// <param name="window">
        /// Sliding window for QPS observation when explicitly configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentAdaptiveUniformSamplingResponse(
            double targetQps,
            string? window)
        {
            this.TargetQps = targetQps;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentAdaptiveUniformSamplingResponse" /> class.
        /// </summary>
        public DeShadowExperimentAdaptiveUniformSamplingResponse()
        {
        }

    }
}