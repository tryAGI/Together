
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageParamContentVariant2ItemVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageParamContentVariant2ItemVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageParamContentVariant2ItemVariant3Type value)
        {
            return value switch
            {
                ChatCompletionUserMessageParamContentVariant2ItemVariant3Type.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageParamContentVariant2ItemVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => ChatCompletionUserMessageParamContentVariant2ItemVariant3Type.VideoUrl,
                _ => null,
            };
        }
    }
}