
#nullable enable

namespace Together
{
    /// <summary>
    /// The task performed<br/>
    /// Example: transcribe
    /// </summary>
    public enum AudioTranscriptionVerboseJsonResponseTask
    {
        /// <summary>
        /// 
        /// </summary>
        Transcribe,
        /// <summary>
        /// 
        /// </summary>
        Translate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionVerboseJsonResponseTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionVerboseJsonResponseTask value)
        {
            return value switch
            {
                AudioTranscriptionVerboseJsonResponseTask.Transcribe => "transcribe",
                AudioTranscriptionVerboseJsonResponseTask.Translate => "translate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionVerboseJsonResponseTask? ToEnum(string value)
        {
            return value switch
            {
                "transcribe" => AudioTranscriptionVerboseJsonResponseTask.Transcribe,
                "translate" => AudioTranscriptionVerboseJsonResponseTask.Translate,
                _ => null,
            };
        }
    }
}