
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageParamContentVariant2ItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageParamContentVariant2ItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageParamContentVariant2ItemVariant1Type value)
        {
            return value switch
            {
                ChatCompletionUserMessageParamContentVariant2ItemVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageParamContentVariant2ItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionUserMessageParamContentVariant2ItemVariant1Type.Text,
                _ => null,
            };
        }
    }
}