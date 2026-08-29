
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum DeSupportedModelOutputModalitie
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
    public static class DeSupportedModelOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelOutputModalitie value)
        {
            return value switch
            {
                DeSupportedModelOutputModalitie.ModalityAudio => "MODALITY_AUDIO",
                DeSupportedModelOutputModalitie.ModalityImage => "MODALITY_IMAGE",
                DeSupportedModelOutputModalitie.ModalityText => "MODALITY_TEXT",
                DeSupportedModelOutputModalitie.ModalityVideo => "MODALITY_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelOutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "MODALITY_AUDIO" => DeSupportedModelOutputModalitie.ModalityAudio,
                "MODALITY_IMAGE" => DeSupportedModelOutputModalitie.ModalityImage,
                "MODALITY_TEXT" => DeSupportedModelOutputModalitie.ModalityText,
                "MODALITY_VIDEO" => DeSupportedModelOutputModalitie.ModalityVideo,
                _ => null,
            };
        }
    }
}