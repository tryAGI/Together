
#nullable enable

namespace Together
{
    /// <summary>
    /// The format of audio output<br/>
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
        Wav,
        /// <summary>
        /// 
        /// </summary>
        Raw,
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
                AudioSpeechRequestResponseFormat.Wav => "wav",
                AudioSpeechRequestResponseFormat.Raw => "raw",
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
                "wav" => AudioSpeechRequestResponseFormat.Wav,
                "raw" => AudioSpeechRequestResponseFormat.Raw,
                _ => null,
            };
        }
    }
}