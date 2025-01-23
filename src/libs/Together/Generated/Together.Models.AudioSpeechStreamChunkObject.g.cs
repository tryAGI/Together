
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioSpeechStreamChunkObject
    {
        /// <summary>
        /// 
        /// </summary>
        AudioTtsChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioSpeechStreamChunkObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSpeechStreamChunkObject value)
        {
            return value switch
            {
                AudioSpeechStreamChunkObject.AudioTtsChunk => "audio.tts.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSpeechStreamChunkObject? ToEnum(string value)
        {
            return value switch
            {
                "audio.tts.chunk" => AudioSpeechStreamChunkObject.AudioTtsChunk,
                _ => null,
            };
        }
    }
}