
#nullable enable

namespace Together
{
    /// <summary>
    /// Time-to-first-token, end-to-end, and inter-token latency percentiles in milliseconds.
    /// </summary>
    public sealed partial class DeLatencyMetrics
    {
        /// <summary>
        /// 50th-percentile time to first token, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttftP50Ms")]
        public double? TtftP50Ms { get; set; }

        /// <summary>
        /// 90th-percentile time to first token, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttftP90Ms")]
        public double? TtftP90Ms { get; set; }

        /// <summary>
        /// 99th-percentile time to first token, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttftP99Ms")]
        public double? TtftP99Ms { get; set; }

        /// <summary>
        /// 50th-percentile end-to-end request latency, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyP50Ms")]
        public double? LatencyP50Ms { get; set; }

        /// <summary>
        /// 90th-percentile end-to-end request latency, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyP90Ms")]
        public double? LatencyP90Ms { get; set; }

        /// <summary>
        /// 99th-percentile end-to-end request latency, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyP99Ms")]
        public double? LatencyP99Ms { get; set; }

        /// <summary>
        /// 50th-percentile inter-token latency, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itlP50Ms")]
        public double? ItlP50Ms { get; set; }

        /// <summary>
        /// 90th-percentile inter-token latency, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itlP90Ms")]
        public double? ItlP90Ms { get; set; }

        /// <summary>
        /// 99th-percentile inter-token latency, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itlP99Ms")]
        public double? ItlP99Ms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeLatencyMetrics" /> class.
        /// </summary>
        /// <param name="ttftP50Ms">
        /// 50th-percentile time to first token, in milliseconds.
        /// </param>
        /// <param name="ttftP90Ms">
        /// 90th-percentile time to first token, in milliseconds.
        /// </param>
        /// <param name="ttftP99Ms">
        /// 99th-percentile time to first token, in milliseconds.
        /// </param>
        /// <param name="latencyP50Ms">
        /// 50th-percentile end-to-end request latency, in milliseconds.
        /// </param>
        /// <param name="latencyP90Ms">
        /// 90th-percentile end-to-end request latency, in milliseconds.
        /// </param>
        /// <param name="latencyP99Ms">
        /// 99th-percentile end-to-end request latency, in milliseconds.
        /// </param>
        /// <param name="itlP50Ms">
        /// 50th-percentile inter-token latency, in milliseconds.
        /// </param>
        /// <param name="itlP90Ms">
        /// 90th-percentile inter-token latency, in milliseconds.
        /// </param>
        /// <param name="itlP99Ms">
        /// 99th-percentile inter-token latency, in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeLatencyMetrics(
            double? ttftP50Ms,
            double? ttftP90Ms,
            double? ttftP99Ms,
            double? latencyP50Ms,
            double? latencyP90Ms,
            double? latencyP99Ms,
            double? itlP50Ms,
            double? itlP90Ms,
            double? itlP99Ms)
        {
            this.TtftP50Ms = ttftP50Ms;
            this.TtftP90Ms = ttftP90Ms;
            this.TtftP99Ms = ttftP99Ms;
            this.LatencyP50Ms = latencyP50Ms;
            this.LatencyP90Ms = latencyP90Ms;
            this.LatencyP99Ms = latencyP99Ms;
            this.ItlP50Ms = itlP50Ms;
            this.ItlP90Ms = itlP90Ms;
            this.ItlP99Ms = itlP99Ms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeLatencyMetrics" /> class.
        /// </summary>
        public DeLatencyMetrics()
        {
        }

    }
}