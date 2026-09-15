
#nullable enable

namespace Together
{
    /// <summary>
    /// Aggregation used for the metric. Optional for router_error_rate and inflight_requests; omitted values default to METRIC_STAT_TYPE_AVG. Required for router_latency, where AVG or PERCENTILE may be used.
    /// </summary>
    public enum DeMetricRuleStat
    {
        /// <summary>
        ///
        /// </summary>
        MetricStatTypeAvg,
        /// <summary>
        ///
        /// </summary>
        MetricStatTypePercentile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeMetricRuleStatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeMetricRuleStat value)
        {
            return value switch
            {
                DeMetricRuleStat.MetricStatTypeAvg => "METRIC_STAT_TYPE_AVG",
                DeMetricRuleStat.MetricStatTypePercentile => "METRIC_STAT_TYPE_PERCENTILE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeMetricRuleStat? ToEnum(string value)
        {
            return value switch
            {
                "METRIC_STAT_TYPE_AVG" => DeMetricRuleStat.MetricStatTypeAvg,
                "METRIC_STAT_TYPE_PERCENTILE" => DeMetricRuleStat.MetricStatTypePercentile,
                _ => null,
            };
        }
    }
}