
#nullable enable

namespace Together
{
    /// <summary>
    /// Model to use for translation<br/>
    /// Default Value: openai/whisper-large-v3
    /// </summary>
    public enum AudioTranslationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        OpenaiWhisperLargeV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranslationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranslationRequestModel value)
        {
            return value switch
            {
                AudioTranslationRequestModel.OpenaiWhisperLargeV3 => "openai/whisper-large-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranslationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "openai/whisper-large-v3" => AudioTranslationRequestModel.OpenaiWhisperLargeV3,
                _ => null,
            };
        }
    }
}