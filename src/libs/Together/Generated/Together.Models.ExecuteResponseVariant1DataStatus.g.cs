
#nullable enable

namespace Together
{
    /// <summary>
    /// Status of the execution. Currently only supports success.
    /// </summary>
    public enum ExecuteResponseVariant1DataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteResponseVariant1DataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseVariant1DataStatus value)
        {
            return value switch
            {
                ExecuteResponseVariant1DataStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseVariant1DataStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ExecuteResponseVariant1DataStatus.Success,
                _ => null,
            };
        }
    }
}