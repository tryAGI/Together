
#nullable enable

namespace Together
{
    /// <summary>
    /// Status of the execution. Currently only supports success.
    /// </summary>
    public enum ExecuteResponseSuccessfulExecutionDataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteResponseSuccessfulExecutionDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseSuccessfulExecutionDataStatus value)
        {
            return value switch
            {
                ExecuteResponseSuccessfulExecutionDataStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseSuccessfulExecutionDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ExecuteResponseSuccessfulExecutionDataStatus.Success,
                _ => null,
            };
        }
    }
}