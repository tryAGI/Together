
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageContentMultimodalItemVideoType
    {
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageContentMultimodalItemVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageContentMultimodalItemVideoType value)
        {
            return value switch
            {
                ChatCompletionUserMessageContentMultimodalItemVideoType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageContentMultimodalItemVideoType? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => ChatCompletionUserMessageContentMultimodalItemVideoType.VideoUrl,
                _ => null,
            };
        }
    }
}