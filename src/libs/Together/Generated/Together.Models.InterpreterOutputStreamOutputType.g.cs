
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum InterpreterOutputStreamOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Stdout,
        /// <summary>
        /// 
        /// </summary>
        Stderr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterpreterOutputStreamOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterpreterOutputStreamOutputType value)
        {
            return value switch
            {
                InterpreterOutputStreamOutputType.Stdout => "stdout",
                InterpreterOutputStreamOutputType.Stderr => "stderr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterpreterOutputStreamOutputType? ToEnum(string value)
        {
            return value switch
            {
                "stdout" => InterpreterOutputStreamOutputType.Stdout,
                "stderr" => InterpreterOutputStreamOutputType.Stderr,
                _ => null,
            };
        }
    }
}