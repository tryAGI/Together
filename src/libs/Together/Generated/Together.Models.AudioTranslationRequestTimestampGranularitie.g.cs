
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioTranslationRequestTimestampGranularitie
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
    public static class AudioTranslationRequestTimestampGranularitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranslationRequestTimestampGranularitie value)
        {
            return value switch
            {
                AudioTranslationRequestTimestampGranularitie.Segment => "segment",
                AudioTranslationRequestTimestampGranularitie.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranslationRequestTimestampGranularitie? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AudioTranslationRequestTimestampGranularitie.Segment,
                "word" => AudioTranslationRequestTimestampGranularitie.Word,
                _ => null,
            };
        }
    }
}