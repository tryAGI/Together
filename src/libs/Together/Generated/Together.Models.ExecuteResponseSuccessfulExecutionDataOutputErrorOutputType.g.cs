
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType value)
        {
            return value switch
            {
                ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType.Error,
                _ => null,
            };
        }
    }
}