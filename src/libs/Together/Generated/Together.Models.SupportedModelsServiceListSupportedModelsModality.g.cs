
#nullable enable

namespace Together
{
    /// <summary>
    /// Filter models by input modality.
    /// </summary>
    public enum SupportedModelsServiceListSupportedModelsModality
    {
        /// <summary>
        ///
        /// </summary>
        ModalityAudio,
        /// <summary>
        ///
        /// </summary>
        ModalityImage,
        /// <summary>
        ///
        /// </summary>
        ModalityText,
        /// <summary>
        ///
        /// </summary>
        ModalityVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedModelsServiceListSupportedModelsModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedModelsServiceListSupportedModelsModality value)
        {
            return value switch
            {
                SupportedModelsServiceListSupportedModelsModality.ModalityAudio => "MODALITY_AUDIO",
                SupportedModelsServiceListSupportedModelsModality.ModalityImage => "MODALITY_IMAGE",
                SupportedModelsServiceListSupportedModelsModality.ModalityText => "MODALITY_TEXT",
                SupportedModelsServiceListSupportedModelsModality.ModalityVideo => "MODALITY_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedModelsServiceListSupportedModelsModality? ToEnum(string value)
        {
            return value switch
            {
                "MODALITY_AUDIO" => SupportedModelsServiceListSupportedModelsModality.ModalityAudio,
                "MODALITY_IMAGE" => SupportedModelsServiceListSupportedModelsModality.ModalityImage,
                "MODALITY_TEXT" => SupportedModelsServiceListSupportedModelsModality.ModalityText,
                "MODALITY_VIDEO" => SupportedModelsServiceListSupportedModelsModality.ModalityVideo,
                _ => null,
            };
        }
    }
}