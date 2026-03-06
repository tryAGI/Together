
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum InterpreterOutputDisplayorExecuteOutputType
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
    public static class InterpreterOutputDisplayorExecuteOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterpreterOutputDisplayorExecuteOutputType value)
        {
            return value switch
            {
                InterpreterOutputDisplayorExecuteOutputType.DisplayData => "display_data",
                InterpreterOutputDisplayorExecuteOutputType.ExecuteResult => "execute_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterpreterOutputDisplayorExecuteOutputType? ToEnum(string value)
        {
            return value switch
            {
                "display_data" => InterpreterOutputDisplayorExecuteOutputType.DisplayData,
                "execute_result" => InterpreterOutputDisplayorExecuteOutputType.ExecuteResult,
                _ => null,
            };
        }
    }
}