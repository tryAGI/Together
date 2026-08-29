
#nullable enable

namespace Together
{
    /// <summary>
    /// Required aggregation used for the metric.
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
        MetricStatTypeMax,
        /// <summary>
        ///
        /// </summary>
        MetricStatTypeMin,
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
                DeMetricRuleStat.MetricStatTypeMax => "METRIC_STAT_TYPE_MAX",
                DeMetricRuleStat.MetricStatTypeMin => "METRIC_STAT_TYPE_MIN",
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
                "METRIC_STAT_TYPE_MAX" => DeMetricRuleStat.MetricStatTypeMax,
                "METRIC_STAT_TYPE_MIN" => DeMetricRuleStat.MetricStatTypeMin,
                "METRIC_STAT_TYPE_PERCENTILE" => DeMetricRuleStat.MetricStatTypePercentile,
                _ => null,
            };
        }
    }
}