
#nullable enable

namespace Together
{
    /// <summary>
    /// Result of evaluating this metric at the gate.
    /// </summary>
    public enum DeMetricResultVerdict
    {
        /// <summary>
        ///
        /// </summary>
        MetricVerdictBreached,
        /// <summary>
        ///
        /// </summary>
        MetricVerdictPass,
        /// <summary>
        ///
        /// </summary>
        MetricVerdictUnavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeMetricResultVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeMetricResultVerdict value)
        {
            return value switch
            {
                DeMetricResultVerdict.MetricVerdictBreached => "METRIC_VERDICT_BREACHED",
                DeMetricResultVerdict.MetricVerdictPass => "METRIC_VERDICT_PASS",
                DeMetricResultVerdict.MetricVerdictUnavailable => "METRIC_VERDICT_UNAVAILABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeMetricResultVerdict? ToEnum(string value)
        {
            return value switch
            {
                "METRIC_VERDICT_BREACHED" => DeMetricResultVerdict.MetricVerdictBreached,
                "METRIC_VERDICT_PASS" => DeMetricResultVerdict.MetricVerdictPass,
                "METRIC_VERDICT_UNAVAILABLE" => DeMetricResultVerdict.MetricVerdictUnavailable,
                _ => null,
            };
        }
    }
}