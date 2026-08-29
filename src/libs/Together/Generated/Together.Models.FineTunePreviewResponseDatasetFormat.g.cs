
#nullable enable

namespace Together
{
    /// <summary>
    /// Detected SFT dataset format for the sampled rows.
    /// </summary>
    public enum FineTunePreviewResponseDatasetFormat
    {
        /// <summary>
        ///
        /// </summary>
        Conversation,
        /// <summary>
        ///
        /// </summary>
        General,
        /// <summary>
        ///
        /// </summary>
        Instruction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTunePreviewResponseDatasetFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTunePreviewResponseDatasetFormat value)
        {
            return value switch
            {
                FineTunePreviewResponseDatasetFormat.Conversation => "conversation",
                FineTunePreviewResponseDatasetFormat.General => "general",
                FineTunePreviewResponseDatasetFormat.Instruction => "instruction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTunePreviewResponseDatasetFormat? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => FineTunePreviewResponseDatasetFormat.Conversation,
                "general" => FineTunePreviewResponseDatasetFormat.General,
                "instruction" => FineTunePreviewResponseDatasetFormat.Instruction,
                _ => null,
            };
        }
    }
}