
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageContentMultimodalItemAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageContentMultimodalItemAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageContentMultimodalItemAudioType value)
        {
            return value switch
            {
                ChatCompletionUserMessageContentMultimodalItemAudioType.AudioUrl => "audio_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageContentMultimodalItemAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => ChatCompletionUserMessageContentMultimodalItemAudioType.AudioUrl,
                _ => null,
            };
        }
    }
}