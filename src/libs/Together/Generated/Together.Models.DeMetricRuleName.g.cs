
#nullable enable

namespace Together
{
    /// <summary>
    /// Required catalogue key for the metric to gate on. `serving_latency` is retired.
    /// </summary>
    public enum DeMetricRuleName
    {
        /// <summary>
        ///
        /// </summary>
        InflightRequests,
        /// <summary>
        ///
        /// </summary>
        RouterErrorRate,
        /// <summary>
        ///
        /// </summary>
        RouterLatency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeMetricRuleNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeMetricRuleName value)
        {
            return value switch
            {
                DeMetricRuleName.InflightRequests => "inflight_requests",
                DeMetricRuleName.RouterErrorRate => "router_error_rate",
                DeMetricRuleName.RouterLatency => "router_latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeMetricRuleName? ToEnum(string value)
        {
            return value switch
            {
                "inflight_requests" => DeMetricRuleName.InflightRequests,
                "router_error_rate" => DeMetricRuleName.RouterErrorRate,
                "router_latency" => DeMetricRuleName.RouterLatency,
                _ => null,
            };
        }
    }
}