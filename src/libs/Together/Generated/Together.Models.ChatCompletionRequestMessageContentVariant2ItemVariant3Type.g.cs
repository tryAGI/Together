
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestMessageContentVariant2ItemVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentVariant2ItemVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentVariant2ItemVariant3Type value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentVariant2ItemVariant3Type.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentVariant2ItemVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => ChatCompletionRequestMessageContentVariant2ItemVariant3Type.VideoUrl,
                _ => null,
            };
        }
    }
}