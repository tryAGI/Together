
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecuteResponseVariant1DataOutputVariant3Type
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
    public static class ExecuteResponseVariant1DataOutputVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteResponseVariant1DataOutputVariant3Type value)
        {
            return value switch
            {
                ExecuteResponseVariant1DataOutputVariant3Type.DisplayData => "display_data",
                ExecuteResponseVariant1DataOutputVariant3Type.ExecuteResult => "execute_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteResponseVariant1DataOutputVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "display_data" => ExecuteResponseVariant1DataOutputVariant3Type.DisplayData,
                "execute_result" => ExecuteResponseVariant1DataOutputVariant3Type.ExecuteResult,
                _ => null,
            };
        }
    }
}