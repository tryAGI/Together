
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioTranscriptionRequestTimestampGranularitie
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
    public static class AudioTranscriptionRequestTimestampGranularitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionRequestTimestampGranularitie value)
        {
            return value switch
            {
                AudioTranscriptionRequestTimestampGranularitie.Segment => "segment",
                AudioTranscriptionRequestTimestampGranularitie.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionRequestTimestampGranularitie? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AudioTranscriptionRequestTimestampGranularitie.Segment,
                "word" => AudioTranscriptionRequestTimestampGranularitie.Word,
                _ => null,
            };
        }
    }
}