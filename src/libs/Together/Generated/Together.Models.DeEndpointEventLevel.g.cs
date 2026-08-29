
#nullable enable

namespace Together
{
    /// <summary>
    /// Output only. Severity level.
    /// </summary>
    public enum DeEndpointEventLevel
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
    public static class DeEndpointEventLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeEndpointEventLevel value)
        {
            return value switch
            {
                DeEndpointEventLevel.LevelDebug => "LEVEL_DEBUG",
                DeEndpointEventLevel.LevelError => "LEVEL_ERROR",
                DeEndpointEventLevel.LevelInfo => "LEVEL_INFO",
                DeEndpointEventLevel.LevelWarn => "LEVEL_WARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeEndpointEventLevel? ToEnum(string value)
        {
            return value switch
            {
                "LEVEL_DEBUG" => DeEndpointEventLevel.LevelDebug,
                "LEVEL_ERROR" => DeEndpointEventLevel.LevelError,
                "LEVEL_INFO" => DeEndpointEventLevel.LevelInfo,
                "LEVEL_WARN" => DeEndpointEventLevel.LevelWarn,
                _ => null,
            };
        }
    }
}