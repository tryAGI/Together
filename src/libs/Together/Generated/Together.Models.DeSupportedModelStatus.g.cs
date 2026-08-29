
#nullable enable

namespace Together
{
    /// <summary>
    /// Catalog recommendation status for the model.
    /// </summary>
    public enum DeSupportedModelStatus
    {
        /// <summary>
        ///
        /// </summary>
        SupportedModelStatusDeprecated,
        /// <summary>
        ///
        /// </summary>
        SupportedModelStatusHidden,
        /// <summary>
        ///
        /// </summary>
        SupportedModelStatusRecommended,
        /// <summary>
        ///
        /// </summary>
        SupportedModelStatusSupported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeSupportedModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelStatus value)
        {
            return value switch
            {
                DeSupportedModelStatus.SupportedModelStatusDeprecated => "SUPPORTED_MODEL_STATUS_DEPRECATED",
                DeSupportedModelStatus.SupportedModelStatusHidden => "SUPPORTED_MODEL_STATUS_HIDDEN",
                DeSupportedModelStatus.SupportedModelStatusRecommended => "SUPPORTED_MODEL_STATUS_RECOMMENDED",
                DeSupportedModelStatus.SupportedModelStatusSupported => "SUPPORTED_MODEL_STATUS_SUPPORTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "SUPPORTED_MODEL_STATUS_DEPRECATED" => DeSupportedModelStatus.SupportedModelStatusDeprecated,
                "SUPPORTED_MODEL_STATUS_HIDDEN" => DeSupportedModelStatus.SupportedModelStatusHidden,
                "SUPPORTED_MODEL_STATUS_RECOMMENDED" => DeSupportedModelStatus.SupportedModelStatusRecommended,
                "SUPPORTED_MODEL_STATUS_SUPPORTED" => DeSupportedModelStatus.SupportedModelStatusSupported,
                _ => null,
            };
        }
    }
}