
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageContentMultimodalItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageContentMultimodalItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageContentMultimodalItemVariant2Type value)
        {
            return value switch
            {
                ChatCompletionUserMessageContentMultimodalItemVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageContentMultimodalItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatCompletionUserMessageContentMultimodalItemVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}