
#nullable enable

namespace Together
{
    /// <summary>
    /// Model to use for transcription<br/>
    /// Default Value: openai/whisper-large-v3
    /// </summary>
    public enum AudioTranscriptionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        OpenaiWhisperLargeV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionRequestModel value)
        {
            return value switch
            {
                AudioTranscriptionRequestModel.OpenaiWhisperLargeV3 => "openai/whisper-large-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "openai/whisper-large-v3" => AudioTranscriptionRequestModel.OpenaiWhisperLargeV3,
                _ => null,
            };
        }
    }
}