
#nullable enable

namespace Together
{
    /// <summary>
    /// Aggregation used for the metric.
    /// </summary>
    public enum DeMetricResultStat
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
    public static class DeMetricResultStatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeMetricResultStat value)
        {
            return value switch
            {
                DeMetricResultStat.MetricStatTypeAvg => "METRIC_STAT_TYPE_AVG",
                DeMetricResultStat.MetricStatTypeMax => "METRIC_STAT_TYPE_MAX",
                DeMetricResultStat.MetricStatTypeMin => "METRIC_STAT_TYPE_MIN",
                DeMetricResultStat.MetricStatTypePercentile => "METRIC_STAT_TYPE_PERCENTILE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeMetricResultStat? ToEnum(string value)
        {
            return value switch
            {
                "METRIC_STAT_TYPE_AVG" => DeMetricResultStat.MetricStatTypeAvg,
                "METRIC_STAT_TYPE_MAX" => DeMetricResultStat.MetricStatTypeMax,
                "METRIC_STAT_TYPE_MIN" => DeMetricResultStat.MetricStatTypeMin,
                "METRIC_STAT_TYPE_PERCENTILE" => DeMetricResultStat.MetricStatTypePercentile,
                _ => null,
            };
        }
    }
}