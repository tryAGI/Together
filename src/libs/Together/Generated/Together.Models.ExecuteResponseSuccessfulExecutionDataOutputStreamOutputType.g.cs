
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
        Stderr,
        /// <summary>
        /// 
        /// </summary>
        Stdout,
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
                ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stderr => "stderr",
                ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stdout => "stdout",
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
                "stderr" => ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stderr,
                "stdout" => ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType.Stdout,
                _ => null,
            };
        }
    }
}