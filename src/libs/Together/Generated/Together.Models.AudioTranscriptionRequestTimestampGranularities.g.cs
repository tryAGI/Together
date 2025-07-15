
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioTranscriptionRequestTimestampGranularities
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
    public static class AudioTranscriptionRequestTimestampGranularitiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionRequestTimestampGranularities value)
        {
            return value switch
            {
                AudioTranscriptionRequestTimestampGranularities.Segment => "segment",
                AudioTranscriptionRequestTimestampGranularities.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionRequestTimestampGranularities? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AudioTranscriptionRequestTimestampGranularities.Segment,
                "word" => AudioTranscriptionRequestTimestampGranularities.Word,
                _ => null,
            };
        }
    }
}