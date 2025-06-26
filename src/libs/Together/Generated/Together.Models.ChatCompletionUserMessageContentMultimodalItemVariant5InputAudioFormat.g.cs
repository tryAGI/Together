
#nullable enable

namespace Together
{
    /// <summary>
    /// The format of the audio data
    /// </summary>
    public enum ChatCompletionUserMessageContentMultimodalItemVariant5InputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageContentMultimodalItemVariant5InputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageContentMultimodalItemVariant5InputAudioFormat value)
        {
            return value switch
            {
                ChatCompletionUserMessageContentMultimodalItemVariant5InputAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageContentMultimodalItemVariant5InputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "wav" => ChatCompletionUserMessageContentMultimodalItemVariant5InputAudioFormat.Wav,
                _ => null,
            };
        }
    }
}