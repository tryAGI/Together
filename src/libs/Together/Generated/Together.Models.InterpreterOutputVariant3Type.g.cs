
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum InterpreterOutputVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        DisplayData,
        /// <summary>
        /// 
        /// </summary>
        ExecuteResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterpreterOutputVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterpreterOutputVariant3Type value)
        {
            return value switch
            {
                InterpreterOutputVariant3Type.DisplayData => "display_data",
                InterpreterOutputVariant3Type.ExecuteResult => "execute_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterpreterOutputVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "display_data" => InterpreterOutputVariant3Type.DisplayData,
                "execute_result" => InterpreterOutputVariant3Type.ExecuteResult,
                _ => null,
            };
        }
    }
}