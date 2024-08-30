
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceType value)
        {
            return value switch
            {
                ToolChoiceType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolChoiceType.Function,
                _ => null,
            };
        }
    }
}