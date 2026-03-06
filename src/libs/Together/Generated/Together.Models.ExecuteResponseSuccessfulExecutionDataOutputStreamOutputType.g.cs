
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType
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
    public static class ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType value)
        {
            return value switch
            {
                ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stdout => "stdout",
                ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stderr => "stderr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType? ToEnum(string value)
        {
            return value switch
            {
                "stdout" => ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stdout,
                "stderr" => ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stderr,
                _ => null,
            };
        }
    }
}