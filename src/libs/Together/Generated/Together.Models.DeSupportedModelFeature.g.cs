
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum DeSupportedModelFeature
    {
        /// <summary>
        ///
        /// </summary>
        FeatureReasoning,
        /// <summary>
        ///
        /// </summary>
        FeatureStructuredOutput,
        /// <summary>
        ///
        /// </summary>
        FeatureToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeSupportedModelFeatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelFeature value)
        {
            return value switch
            {
                DeSupportedModelFeature.FeatureReasoning => "FEATURE_REASONING",
                DeSupportedModelFeature.FeatureStructuredOutput => "FEATURE_STRUCTURED_OUTPUT",
                DeSupportedModelFeature.FeatureToolCalling => "FEATURE_TOOL_CALLING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelFeature? ToEnum(string value)
        {
            return value switch
            {
                "FEATURE_REASONING" => DeSupportedModelFeature.FeatureReasoning,
                "FEATURE_STRUCTURED_OUTPUT" => DeSupportedModelFeature.FeatureStructuredOutput,
                "FEATURE_TOOL_CALLING" => DeSupportedModelFeature.FeatureToolCalling,
                _ => null,
            };
        }
    }
}