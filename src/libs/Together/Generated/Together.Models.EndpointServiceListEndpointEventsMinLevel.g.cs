
#nullable enable

namespace Together
{
    /// <summary>
    /// Minimum severity. Omit to disable severity filtering.
    /// </summary>
    public enum EndpointServiceListEndpointEventsMinLevel
    {
        /// <summary>
        ///
        /// </summary>
        LevelDebug,
        /// <summary>
        ///
        /// </summary>
        LevelError,
        /// <summary>
        ///
        /// </summary>
        LevelInfo,
        /// <summary>
        ///
        /// </summary>
        LevelWarn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndpointServiceListEndpointEventsMinLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndpointServiceListEndpointEventsMinLevel value)
        {
            return value switch
            {
                EndpointServiceListEndpointEventsMinLevel.LevelDebug => "LEVEL_DEBUG",
                EndpointServiceListEndpointEventsMinLevel.LevelError => "LEVEL_ERROR",
                EndpointServiceListEndpointEventsMinLevel.LevelInfo => "LEVEL_INFO",
                EndpointServiceListEndpointEventsMinLevel.LevelWarn => "LEVEL_WARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndpointServiceListEndpointEventsMinLevel? ToEnum(string value)
        {
            return value switch
            {
                "LEVEL_DEBUG" => EndpointServiceListEndpointEventsMinLevel.LevelDebug,
                "LEVEL_ERROR" => EndpointServiceListEndpointEventsMinLevel.LevelError,
                "LEVEL_INFO" => EndpointServiceListEndpointEventsMinLevel.LevelInfo,
                "LEVEL_WARN" => EndpointServiceListEndpointEventsMinLevel.LevelWarn,
                _ => null,
            };
        }
    }
}