
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageContentMultimodalItemInputAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageContentMultimodalItemInputAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageContentMultimodalItemInputAudioType value)
        {
            return value switch
            {
                ChatCompletionUserMessageContentMultimodalItemInputAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageContentMultimodalItemInputAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => ChatCompletionUserMessageContentMultimodalItemInputAudioType.InputAudio,
                _ => null,
            };
        }
    }
}