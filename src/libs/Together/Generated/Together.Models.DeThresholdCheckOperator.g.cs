
#nullable enable

namespace Together
{
    /// <summary>
    /// Required comparison operator applied to the target metric value.
    /// </summary>
    public enum DeThresholdCheckOperator
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
    public static class DeThresholdCheckOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeThresholdCheckOperator value)
        {
            return value switch
            {
                DeThresholdCheckOperator.ThresholdOperatorGt => "THRESHOLD_OPERATOR_GT",
                DeThresholdCheckOperator.ThresholdOperatorGte => "THRESHOLD_OPERATOR_GTE",
                DeThresholdCheckOperator.ThresholdOperatorLt => "THRESHOLD_OPERATOR_LT",
                DeThresholdCheckOperator.ThresholdOperatorLte => "THRESHOLD_OPERATOR_LTE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeThresholdCheckOperator? ToEnum(string value)
        {
            return value switch
            {
                "THRESHOLD_OPERATOR_GT" => DeThresholdCheckOperator.ThresholdOperatorGt,
                "THRESHOLD_OPERATOR_GTE" => DeThresholdCheckOperator.ThresholdOperatorGte,
                "THRESHOLD_OPERATOR_LT" => DeThresholdCheckOperator.ThresholdOperatorLt,
                "THRESHOLD_OPERATOR_LTE" => DeThresholdCheckOperator.ThresholdOperatorLte,
                _ => null,
            };
        }
    }
}