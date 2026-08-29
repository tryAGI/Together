
#nullable enable

namespace Together
{
    /// <summary>
    /// Evaluation form used by the metric rule.
    /// </summary>
    public enum DeMetricResultCheck
    {
        /// <summary>
        ///
        /// </summary>
        MetricCheckTypeRegression,
        /// <summary>
        ///
        /// </summary>
        MetricCheckTypeThreshold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeMetricResultCheckExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeMetricResultCheck value)
        {
            return value switch
            {
                DeMetricResultCheck.MetricCheckTypeRegression => "METRIC_CHECK_TYPE_REGRESSION",
                DeMetricResultCheck.MetricCheckTypeThreshold => "METRIC_CHECK_TYPE_THRESHOLD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeMetricResultCheck? ToEnum(string value)
        {
            return value switch
            {
                "METRIC_CHECK_TYPE_REGRESSION" => DeMetricResultCheck.MetricCheckTypeRegression,
                "METRIC_CHECK_TYPE_THRESHOLD" => DeMetricResultCheck.MetricCheckTypeThreshold,
                _ => null,
            };
        }
    }
}