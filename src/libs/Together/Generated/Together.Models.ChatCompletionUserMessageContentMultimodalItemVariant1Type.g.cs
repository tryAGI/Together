
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageContentMultimodalItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageContentMultimodalItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageContentMultimodalItemVariant1Type value)
        {
            return value switch
            {
                ChatCompletionUserMessageContentMultimodalItemVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageContentMultimodalItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionUserMessageContentMultimodalItemVariant1Type.Text,
                _ => null,
            };
        }
    }
}