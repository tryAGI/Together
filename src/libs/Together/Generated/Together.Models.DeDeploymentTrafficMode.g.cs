
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.<br/>
    /// Included only in responses
    /// </summary>
    public enum DeDeploymentTrafficMode
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
    public static class DeDeploymentTrafficModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeDeploymentTrafficMode value)
        {
            return value switch
            {
                DeDeploymentTrafficMode.TrafficModeLive => "TRAFFIC_MODE_LIVE",
                DeDeploymentTrafficMode.TrafficModeShadow => "TRAFFIC_MODE_SHADOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeDeploymentTrafficMode? ToEnum(string value)
        {
            return value switch
            {
                "TRAFFIC_MODE_LIVE" => DeDeploymentTrafficMode.TrafficModeLive,
                "TRAFFIC_MODE_SHADOW" => DeDeploymentTrafficMode.TrafficModeShadow,
                _ => null,
            };
        }
    }
}