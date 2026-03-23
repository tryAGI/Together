
#nullable enable

namespace Together
{
    /// <summary>
    /// The format of audio output. Supported formats are mp3, wav, raw if streaming is false. If streaming is true, the only supported format is raw.<br/>
    /// Default Value: wav
    /// </summary>
    public enum AudioSpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Raw,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioSpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSpeechRequestResponseFormat value)
        {
            return value switch
            {
                AudioSpeechRequestResponseFormat.Mp3 => "mp3",
                AudioSpeechRequestResponseFormat.Raw => "raw",
                AudioSpeechRequestResponseFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSpeechRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => AudioSpeechRequestResponseFormat.Mp3,
                "raw" => AudioSpeechRequestResponseFormat.Raw,
                "wav" => AudioSpeechRequestResponseFormat.Wav,
                _ => null,
            };
        }
    }
}