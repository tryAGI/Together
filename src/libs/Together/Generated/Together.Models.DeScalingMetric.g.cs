
#nullable enable

namespace Together
{
    /// <summary>
    /// Metric and target used by the autoscaler to recommend a replica count.
    /// </summary>
    public sealed partial class DeScalingMetric
    {
        /// <summary>
        /// Metric name, such as `gpu_utilization`, `ttft`, `inflight_requests`, `e2e_latency`, `throughput_per_replica`, or `decoding_speed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether `target` is an absolute value, a utilization percentage, or a per-replica average.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeScalingMetricTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeScalingMetricType Type { get; set; }

        /// <summary>
        /// Target interpreted according to `type`. Utilization uses a percentage from 0 to 100, value uses an absolute measurement, and average value uses a per-replica measurement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Target { get; set; }

        /// <summary>
        /// Percentile to evaluate for latency-based metrics: `p50`, `p90`, `p95`, or `p99`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public string? Percentile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeScalingMetric" /> class.
        /// </summary>
        /// <param name="name">
        /// Metric name, such as `gpu_utilization`, `ttft`, `inflight_requests`, `e2e_latency`, `throughput_per_replica`, or `decoding_speed`.
        /// </param>
        /// <param name="type">
        /// Whether `target` is an absolute value, a utilization percentage, or a per-replica average.
        /// </param>
        /// <param name="target">
        /// Target interpreted according to `type`. Utilization uses a percentage from 0 to 100, value uses an absolute measurement, and average value uses a per-replica measurement.
        /// </param>
        /// <param name="percentile">
        /// Percentile to evaluate for latency-based metrics: `p50`, `p90`, `p95`, or `p99`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeScalingMetric(
            string name,
            global::Together.DeScalingMetricType type,
            double target,
            string? percentile)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Target = target;
            this.Percentile = percentile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeScalingMetric" /> class.
        /// </summary>
        public DeScalingMetric()
        {
        }

    }
}