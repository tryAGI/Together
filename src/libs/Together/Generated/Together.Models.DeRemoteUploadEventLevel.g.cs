
#nullable enable

namespace Together
{
    /// <summary>
    /// Severity of the event.
    /// </summary>
    public enum DeRemoteUploadEventLevel
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
    public static class DeRemoteUploadEventLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRemoteUploadEventLevel value)
        {
            return value switch
            {
                DeRemoteUploadEventLevel.LevelDebug => "LEVEL_DEBUG",
                DeRemoteUploadEventLevel.LevelError => "LEVEL_ERROR",
                DeRemoteUploadEventLevel.LevelInfo => "LEVEL_INFO",
                DeRemoteUploadEventLevel.LevelWarn => "LEVEL_WARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRemoteUploadEventLevel? ToEnum(string value)
        {
            return value switch
            {
                "LEVEL_DEBUG" => DeRemoteUploadEventLevel.LevelDebug,
                "LEVEL_ERROR" => DeRemoteUploadEventLevel.LevelError,
                "LEVEL_INFO" => DeRemoteUploadEventLevel.LevelInfo,
                "LEVEL_WARN" => DeRemoteUploadEventLevel.LevelWarn,
                _ => null,
            };
        }
    }
}