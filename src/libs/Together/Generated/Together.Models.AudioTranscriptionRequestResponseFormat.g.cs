
#nullable enable

namespace Together
{
    /// <summary>
    /// The format of the response<br/>
    /// Default Value: json
    /// </summary>
    public enum AudioTranscriptionRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        VerboseJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionRequestResponseFormat value)
        {
            return value switch
            {
                AudioTranscriptionRequestResponseFormat.Json => "json",
                AudioTranscriptionRequestResponseFormat.VerboseJson => "verbose_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AudioTranscriptionRequestResponseFormat.Json,
                "verbose_json" => AudioTranscriptionRequestResponseFormat.VerboseJson,
                _ => null,
            };
        }
    }
}