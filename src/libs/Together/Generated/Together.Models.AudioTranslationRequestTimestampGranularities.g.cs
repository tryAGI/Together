
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioTranslationRequestTimestampGranularities
    {
        /// <summary>
        ///
        /// </summary>
        Segment,
        /// <summary>
        ///
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranslationRequestTimestampGranularitiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranslationRequestTimestampGranularities value)
        {
            return value switch
            {
                AudioTranslationRequestTimestampGranularities.Segment => "segment",
                AudioTranslationRequestTimestampGranularities.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranslationRequestTimestampGranularities? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AudioTranslationRequestTimestampGranularities.Segment,
                "word" => AudioTranslationRequestTimestampGranularities.Word,
                _ => null,
            };
        }
    }
}