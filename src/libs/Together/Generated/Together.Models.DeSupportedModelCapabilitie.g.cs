
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum DeSupportedModelCapabilitie
    {
        /// <summary>
        ///
        /// </summary>
        CapabilityChat,
        /// <summary>
        ///
        /// </summary>
        CapabilityEmbedding,
        /// <summary>
        ///
        /// </summary>
        CapabilityImageGeneration,
        /// <summary>
        ///
        /// </summary>
        CapabilityReranking,
        /// <summary>
        ///
        /// </summary>
        CapabilityVideoGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeSupportedModelCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelCapabilitie value)
        {
            return value switch
            {
                DeSupportedModelCapabilitie.CapabilityChat => "CAPABILITY_CHAT",
                DeSupportedModelCapabilitie.CapabilityEmbedding => "CAPABILITY_EMBEDDING",
                DeSupportedModelCapabilitie.CapabilityImageGeneration => "CAPABILITY_IMAGE_GENERATION",
                DeSupportedModelCapabilitie.CapabilityReranking => "CAPABILITY_RERANKING",
                DeSupportedModelCapabilitie.CapabilityVideoGeneration => "CAPABILITY_VIDEO_GENERATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "CAPABILITY_CHAT" => DeSupportedModelCapabilitie.CapabilityChat,
                "CAPABILITY_EMBEDDING" => DeSupportedModelCapabilitie.CapabilityEmbedding,
                "CAPABILITY_IMAGE_GENERATION" => DeSupportedModelCapabilitie.CapabilityImageGeneration,
                "CAPABILITY_RERANKING" => DeSupportedModelCapabilitie.CapabilityReranking,
                "CAPABILITY_VIDEO_GENERATION" => DeSupportedModelCapabilitie.CapabilityVideoGeneration,
                _ => null,
            };
        }
    }
}