
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecuteResponseVariant1DataOutputVariant1Type
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
    public static class ExecuteResponseVariant1DataOutputVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseVariant1DataOutputVariant1Type value)
        {
            return value switch
            {
                ExecuteResponseVariant1DataOutputVariant1Type.Stdout => "stdout",
                ExecuteResponseVariant1DataOutputVariant1Type.Stderr => "stderr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseVariant1DataOutputVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "stdout" => ExecuteResponseVariant1DataOutputVariant1Type.Stdout,
                "stderr" => ExecuteResponseVariant1DataOutputVariant1Type.Stderr,
                _ => null,
            };
        }
    }
}