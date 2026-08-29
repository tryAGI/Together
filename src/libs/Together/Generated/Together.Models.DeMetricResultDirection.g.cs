
#nullable enable

namespace Together
{
    /// <summary>
    /// Direction that indicates whether higher or lower values are worse.
    /// </summary>
    public enum DeMetricResultDirection
    {
        /// <summary>
        ///
        /// </summary>
        RegressionDirectionHigherIsWorse,
        /// <summary>
        ///
        /// </summary>
        RegressionDirectionLowerIsWorse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeMetricResultDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeMetricResultDirection value)
        {
            return value switch
            {
                DeMetricResultDirection.RegressionDirectionHigherIsWorse => "REGRESSION_DIRECTION_HIGHER_IS_WORSE",
                DeMetricResultDirection.RegressionDirectionLowerIsWorse => "REGRESSION_DIRECTION_LOWER_IS_WORSE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeMetricResultDirection? ToEnum(string value)
        {
            return value switch
            {
                "REGRESSION_DIRECTION_HIGHER_IS_WORSE" => DeMetricResultDirection.RegressionDirectionHigherIsWorse,
                "REGRESSION_DIRECTION_LOWER_IS_WORSE" => DeMetricResultDirection.RegressionDirectionLowerIsWorse,
                _ => null,
            };
        }
    }
}