
#nullable enable

namespace Together
{
    /// <summary>
    /// Default Value: pcm_s16le_16000
    /// </summary>
    public enum RealtimeTranscriptionInputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        PcmS16le16000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionInputAudioFormat value)
        {
            return value switch
            {
                RealtimeTranscriptionInputAudioFormat.PcmS16le16000 => "pcm_s16le_16000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16000" => RealtimeTranscriptionInputAudioFormat.PcmS16le16000,
                _ => null,
            };
        }
    }
}