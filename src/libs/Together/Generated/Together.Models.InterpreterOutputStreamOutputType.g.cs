
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
        Stderr,
        /// <summary>
        /// 
        /// </summary>
        Stdout,
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
                InterpreterOutputStreamOutputType.Stderr => "stderr",
                InterpreterOutputStreamOutputType.Stdout => "stdout",
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
                "stderr" => InterpreterOutputStreamOutputType.Stderr,
                "stdout" => InterpreterOutputStreamOutputType.Stdout,
                _ => null,
            };
        }
    }
}