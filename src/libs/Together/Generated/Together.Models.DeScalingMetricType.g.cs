
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether `target` is an absolute value, a utilization percentage, or a per-replica average.
    /// </summary>
    public enum DeScalingMetricType
    {
        /// <summary>
        ///
        /// </summary>
        MetricTargetTypeAverageValue,
        /// <summary>
        ///
        /// </summary>
        MetricTargetTypeUtilization,
        /// <summary>
        ///
        /// </summary>
        MetricTargetTypeValue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeScalingMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeScalingMetricType value)
        {
            return value switch
            {
                DeScalingMetricType.MetricTargetTypeAverageValue => "METRIC_TARGET_TYPE_AVERAGE_VALUE",
                DeScalingMetricType.MetricTargetTypeUtilization => "METRIC_TARGET_TYPE_UTILIZATION",
                DeScalingMetricType.MetricTargetTypeValue => "METRIC_TARGET_TYPE_VALUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeScalingMetricType? ToEnum(string value)
        {
            return value switch
            {
                "METRIC_TARGET_TYPE_AVERAGE_VALUE" => DeScalingMetricType.MetricTargetTypeAverageValue,
                "METRIC_TARGET_TYPE_UTILIZATION" => DeScalingMetricType.MetricTargetTypeUtilization,
                "METRIC_TARGET_TYPE_VALUE" => DeScalingMetricType.MetricTargetTypeValue,
                _ => null,
            };
        }
    }
}