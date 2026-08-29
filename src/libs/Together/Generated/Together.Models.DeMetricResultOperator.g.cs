
#nullable enable

namespace Together
{
    /// <summary>
    /// Threshold comparison operator.
    /// </summary>
    public enum DeMetricResultOperator
    {
        /// <summary>
        ///
        /// </summary>
        ThresholdOperatorGt,
        /// <summary>
        ///
        /// </summary>
        ThresholdOperatorGte,
        /// <summary>
        ///
        /// </summary>
        ThresholdOperatorLt,
        /// <summary>
        ///
        /// </summary>
        ThresholdOperatorLte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeMetricResultOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeMetricResultOperator value)
        {
            return value switch
            {
                DeMetricResultOperator.ThresholdOperatorGt => "THRESHOLD_OPERATOR_GT",
                DeMetricResultOperator.ThresholdOperatorGte => "THRESHOLD_OPERATOR_GTE",
                DeMetricResultOperator.ThresholdOperatorLt => "THRESHOLD_OPERATOR_LT",
                DeMetricResultOperator.ThresholdOperatorLte => "THRESHOLD_OPERATOR_LTE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeMetricResultOperator? ToEnum(string value)
        {
            return value switch
            {
                "THRESHOLD_OPERATOR_GT" => DeMetricResultOperator.ThresholdOperatorGt,
                "THRESHOLD_OPERATOR_GTE" => DeMetricResultOperator.ThresholdOperatorGte,
                "THRESHOLD_OPERATOR_LT" => DeMetricResultOperator.ThresholdOperatorLt,
                "THRESHOLD_OPERATOR_LTE" => DeMetricResultOperator.ThresholdOperatorLte,
                _ => null,
            };
        }
    }
}