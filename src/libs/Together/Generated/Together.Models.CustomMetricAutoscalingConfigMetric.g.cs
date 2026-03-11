
#nullable enable

namespace Together
{
    /// <summary>
    /// Metric must be CustomMetric<br/>
    /// Example: CustomMetric
    /// </summary>
    public enum CustomMetricAutoscalingConfigMetric
    {
        /// <summary>
        /// 
        /// </summary>
        CustomMetric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomMetricAutoscalingConfigMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomMetricAutoscalingConfigMetric value)
        {
            return value switch
            {
                CustomMetricAutoscalingConfigMetric.CustomMetric => "CustomMetric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomMetricAutoscalingConfigMetric? ToEnum(string value)
        {
            return value switch
            {
                "CustomMetric" => CustomMetricAutoscalingConfigMetric.CustomMetric,
                _ => null,
            };
        }
    }
}