
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum InterpreterOutputErrorOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterpreterOutputErrorOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterpreterOutputErrorOutputType value)
        {
            return value switch
            {
                InterpreterOutputErrorOutputType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterpreterOutputErrorOutputType? ToEnum(string value)
        {
            return value switch
            {
                "error" => InterpreterOutputErrorOutputType.Error,
                _ => null,
            };
        }
    }
}