
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ErrorOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorOutputType value)
        {
            return value switch
            {
                ErrorOutputType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorOutputType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ErrorOutputType.Error,
                _ => null,
            };
        }
    }
}