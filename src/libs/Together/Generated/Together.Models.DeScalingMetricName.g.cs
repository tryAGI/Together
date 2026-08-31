
#nullable enable

namespace Together
{
    /// <summary>
    /// Autoscaling metric name from the server allowlist.
    /// </summary>
    public enum DeScalingMetricName
    {
        /// <summary>
        ///
        /// </summary>
        CacheHitRate,
        /// <summary>
        ///
        /// </summary>
        DecodingSpeed,
        /// <summary>
        ///
        /// </summary>
        E2eLatency,
        /// <summary>
        ///
        /// </summary>
        GpuUtilization,
        /// <summary>
        ///
        /// </summary>
        InflightRequests,
        /// <summary>
        ///
        /// </summary>
        ThroughputPerReplica,
        /// <summary>
        ///
        /// </summary>
        TokenUtilization,
        /// <summary>
        ///
        /// </summary>
        Ttft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeScalingMetricNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeScalingMetricName value)
        {
            return value switch
            {
                DeScalingMetricName.CacheHitRate => "cache_hit_rate",
                DeScalingMetricName.DecodingSpeed => "decoding_speed",
                DeScalingMetricName.E2eLatency => "e2e_latency",
                DeScalingMetricName.GpuUtilization => "gpu_utilization",
                DeScalingMetricName.InflightRequests => "inflight_requests",
                DeScalingMetricName.ThroughputPerReplica => "throughput_per_replica",
                DeScalingMetricName.TokenUtilization => "token_utilization",
                DeScalingMetricName.Ttft => "ttft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeScalingMetricName? ToEnum(string value)
        {
            return value switch
            {
                "cache_hit_rate" => DeScalingMetricName.CacheHitRate,
                "decoding_speed" => DeScalingMetricName.DecodingSpeed,
                "e2e_latency" => DeScalingMetricName.E2eLatency,
                "gpu_utilization" => DeScalingMetricName.GpuUtilization,
                "inflight_requests" => DeScalingMetricName.InflightRequests,
                "throughput_per_replica" => DeScalingMetricName.ThroughputPerReplica,
                "token_utilization" => DeScalingMetricName.TokenUtilization,
                "ttft" => DeScalingMetricName.Ttft,
                _ => null,
            };
        }
    }
}