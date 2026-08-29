
#nullable enable

namespace Together
{
    /// <summary>
    /// Required direction that indicates whether higher or lower metric values are worse.
    /// </summary>
    public enum DeRegressionCheckDirection
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
    public static class DeRegressionCheckDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRegressionCheckDirection value)
        {
            return value switch
            {
                DeRegressionCheckDirection.RegressionDirectionHigherIsWorse => "REGRESSION_DIRECTION_HIGHER_IS_WORSE",
                DeRegressionCheckDirection.RegressionDirectionLowerIsWorse => "REGRESSION_DIRECTION_LOWER_IS_WORSE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRegressionCheckDirection? ToEnum(string value)
        {
            return value switch
            {
                "REGRESSION_DIRECTION_HIGHER_IS_WORSE" => DeRegressionCheckDirection.RegressionDirectionHigherIsWorse,
                "REGRESSION_DIRECTION_LOWER_IS_WORSE" => DeRegressionCheckDirection.RegressionDirectionLowerIsWorse,
                _ => null,
            };
        }
    }
}