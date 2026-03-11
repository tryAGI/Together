
#nullable enable

namespace Together
{
    /// <summary>
    /// Metric must be HTTPTotalRequests or HTTPAvgRequestDuration<br/>
    /// Example: HTTPTotalRequests
    /// </summary>
    public enum HTTPAutoscalingConfigMetric
    {
        /// <summary>
        /// 
        /// </summary>
        HTTPTotalRequests,
        /// <summary>
        /// 
        /// </summary>
        HTTPAvgRequestDuration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HTTPAutoscalingConfigMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HTTPAutoscalingConfigMetric value)
        {
            return value switch
            {
                HTTPAutoscalingConfigMetric.HTTPTotalRequests => "HTTPTotalRequests",
                HTTPAutoscalingConfigMetric.HTTPAvgRequestDuration => "HTTPAvgRequestDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HTTPAutoscalingConfigMetric? ToEnum(string value)
        {
            return value switch
            {
                "HTTPTotalRequests" => HTTPAutoscalingConfigMetric.HTTPTotalRequests,
                "HTTPAvgRequestDuration" => HTTPAutoscalingConfigMetric.HTTPAvgRequestDuration,
                _ => null,
            };
        }
    }
}