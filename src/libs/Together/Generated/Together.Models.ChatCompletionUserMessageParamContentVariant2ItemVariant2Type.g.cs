
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageParamContentVariant2ItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageParamContentVariant2ItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageParamContentVariant2ItemVariant2Type value)
        {
            return value switch
            {
                ChatCompletionUserMessageParamContentVariant2ItemVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageParamContentVariant2ItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatCompletionUserMessageParamContentVariant2ItemVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}