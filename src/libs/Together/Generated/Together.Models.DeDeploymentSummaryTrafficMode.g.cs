
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.
    /// </summary>
    public enum DeDeploymentSummaryTrafficMode
    {
        /// <summary>
        ///
        /// </summary>
        TrafficModeLive,
        /// <summary>
        ///
        /// </summary>
        TrafficModeShadow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeDeploymentSummaryTrafficModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeDeploymentSummaryTrafficMode value)
        {
            return value switch
            {
                DeDeploymentSummaryTrafficMode.TrafficModeLive => "TRAFFIC_MODE_LIVE",
                DeDeploymentSummaryTrafficMode.TrafficModeShadow => "TRAFFIC_MODE_SHADOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeDeploymentSummaryTrafficMode? ToEnum(string value)
        {
            return value switch
            {
                "TRAFFIC_MODE_LIVE" => DeDeploymentSummaryTrafficMode.TrafficModeLive,
                "TRAFFIC_MODE_SHADOW" => DeDeploymentSummaryTrafficMode.TrafficModeShadow,
                _ => null,
            };
        }
    }
}