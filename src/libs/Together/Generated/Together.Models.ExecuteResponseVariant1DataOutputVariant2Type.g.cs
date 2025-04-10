
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecuteResponseVariant1DataOutputVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteResponseVariant1DataOutputVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseVariant1DataOutputVariant2Type value)
        {
            return value switch
            {
                ExecuteResponseVariant1DataOutputVariant2Type.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseVariant1DataOutputVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "error" => ExecuteResponseVariant1DataOutputVariant2Type.Error,
                _ => null,
            };
        }
    }
}