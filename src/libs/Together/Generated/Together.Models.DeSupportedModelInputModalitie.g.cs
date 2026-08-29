
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum DeSupportedModelInputModalitie
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
    public static class DeSupportedModelInputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelInputModalitie value)
        {
            return value switch
            {
                DeSupportedModelInputModalitie.ModalityAudio => "MODALITY_AUDIO",
                DeSupportedModelInputModalitie.ModalityImage => "MODALITY_IMAGE",
                DeSupportedModelInputModalitie.ModalityText => "MODALITY_TEXT",
                DeSupportedModelInputModalitie.ModalityVideo => "MODALITY_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelInputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "MODALITY_AUDIO" => DeSupportedModelInputModalitie.ModalityAudio,
                "MODALITY_IMAGE" => DeSupportedModelInputModalitie.ModalityImage,
                "MODALITY_TEXT" => DeSupportedModelInputModalitie.ModalityText,
                "MODALITY_VIDEO" => DeSupportedModelInputModalitie.ModalityVideo,
                _ => null,
            };
        }
    }
}