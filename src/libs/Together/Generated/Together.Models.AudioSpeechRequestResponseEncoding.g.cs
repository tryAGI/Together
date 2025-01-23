
#nullable enable

namespace Together
{
    /// <summary>
    /// Audio encoding of response<br/>
    /// Default Value: pcm_f32le
    /// </summary>
    public enum AudioSpeechRequestResponseEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        PcmF32le,
        /// <summary>
        /// 
        /// </summary>
        PcmS16le,
        /// <summary>
        /// 
        /// </summary>
        PcmMulaw,
        /// <summary>
        /// 
        /// </summary>
        PcmAlaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioSpeechRequestResponseEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSpeechRequestResponseEncoding value)
        {
            return value switch
            {
                AudioSpeechRequestResponseEncoding.PcmF32le => "pcm_f32le",
                AudioSpeechRequestResponseEncoding.PcmS16le => "pcm_s16le",
                AudioSpeechRequestResponseEncoding.PcmMulaw => "pcm_mulaw",
                AudioSpeechRequestResponseEncoding.PcmAlaw => "pcm_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSpeechRequestResponseEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_f32le" => AudioSpeechRequestResponseEncoding.PcmF32le,
                "pcm_s16le" => AudioSpeechRequestResponseEncoding.PcmS16le,
                "pcm_mulaw" => AudioSpeechRequestResponseEncoding.PcmMulaw,
                "pcm_alaw" => AudioSpeechRequestResponseEncoding.PcmAlaw,
                _ => null,
            };
        }
    }
}