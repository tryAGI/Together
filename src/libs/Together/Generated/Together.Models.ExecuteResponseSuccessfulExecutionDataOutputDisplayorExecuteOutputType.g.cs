
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType
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
    public static class ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType value)
        {
            return value switch
            {
                ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType.DisplayData => "display_data",
                ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType.ExecuteResult => "execute_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType? ToEnum(string value)
        {
            return value switch
            {
                "display_data" => ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType.DisplayData,
                "execute_result" => ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType.ExecuteResult,
                _ => null,
            };
        }
    }
}