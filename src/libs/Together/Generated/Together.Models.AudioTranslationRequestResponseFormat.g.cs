
#nullable enable

namespace Together
{
    /// <summary>
    /// The format of the response<br/>
    /// Default Value: json
    /// </summary>
    public enum AudioTranslationRequestResponseFormat
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
    public static class AudioTranslationRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranslationRequestResponseFormat value)
        {
            return value switch
            {
                AudioTranslationRequestResponseFormat.Json => "json",
                AudioTranslationRequestResponseFormat.VerboseJson => "verbose_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranslationRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AudioTranslationRequestResponseFormat.Json,
                "verbose_json" => AudioTranslationRequestResponseFormat.VerboseJson,
                _ => null,
            };
        }
    }
}