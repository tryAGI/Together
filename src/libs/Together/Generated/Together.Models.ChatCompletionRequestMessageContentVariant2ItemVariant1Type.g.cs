
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestMessageContentVariant2ItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentVariant2ItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentVariant2ItemVariant1Type value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentVariant2ItemVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentVariant2ItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionRequestMessageContentVariant2ItemVariant1Type.Text,
                _ => null,
            };
        }
    }
}