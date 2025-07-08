
#nullable enable

namespace Together
{
    /// <summary>
    /// The task performed<br/>
    /// Example: translate
    /// </summary>
    public enum AudioTranslationVerboseJsonResponseTask
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
    public static class AudioTranslationVerboseJsonResponseTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranslationVerboseJsonResponseTask value)
        {
            return value switch
            {
                AudioTranslationVerboseJsonResponseTask.Transcribe => "transcribe",
                AudioTranslationVerboseJsonResponseTask.Translate => "translate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranslationVerboseJsonResponseTask? ToEnum(string value)
        {
            return value switch
            {
                "transcribe" => AudioTranslationVerboseJsonResponseTask.Transcribe,
                "translate" => AudioTranslationVerboseJsonResponseTask.Translate,
                _ => null,
            };
        }
    }
}