
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum InterpreterOutputVariant1Type
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
    public static class InterpreterOutputVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterpreterOutputVariant1Type value)
        {
            return value switch
            {
                InterpreterOutputVariant1Type.Stdout => "stdout",
                InterpreterOutputVariant1Type.Stderr => "stderr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterpreterOutputVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "stdout" => InterpreterOutputVariant1Type.Stdout,
                "stderr" => InterpreterOutputVariant1Type.Stderr,
                _ => null,
            };
        }
    }
}