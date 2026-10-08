
#nullable enable

namespace Together
{
    /// <summary>
    /// Severity level for a shaping event.
    /// </summary>
    public enum EventLevel
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Info,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventLevel value)
        {
            return value switch
            {
                EventLevel.Error => "Error",
                EventLevel.Info => "Info",
                EventLevel.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventLevel? ToEnum(string value)
        {
            return value switch
            {
                "Error" => EventLevel.Error,
                "Info" => EventLevel.Info,
                "Warning" => EventLevel.Warning,
                _ => null,
            };
        }
    }
}