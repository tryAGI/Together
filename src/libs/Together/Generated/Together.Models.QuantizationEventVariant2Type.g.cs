
#nullable enable

namespace Together
{
    /// <summary>
    /// Quantization event type.
    /// </summary>
    public enum QuantizationEventVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        QuantizationJobComplete,
        /// <summary>
        ///
        /// </summary>
        QuantizationJobStart,
        /// <summary>
        ///
        /// </summary>
        QuantizationMergeComplete,
        /// <summary>
        ///
        /// </summary>
        QuantizationModelDownloadComplete,
        /// <summary>
        ///
        /// </summary>
        QuantizationModelUploadComplete,
        /// <summary>
        ///
        /// </summary>
        QuantizationQuantizeProcessComplete,
        /// <summary>
        ///
        /// </summary>
        QuantizationQuantizeProcessStart,
        /// <summary>
        ///
        /// </summary>
        ShapingError,
        /// <summary>
        ///
        /// </summary>
        ShapingUserError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuantizationEventVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QuantizationEventVariant2Type value)
        {
            return value switch
            {
                QuantizationEventVariant2Type.QuantizationJobComplete => "QUANTIZATION_JOB_COMPLETE",
                QuantizationEventVariant2Type.QuantizationJobStart => "QUANTIZATION_JOB_START",
                QuantizationEventVariant2Type.QuantizationMergeComplete => "QUANTIZATION_MERGE_COMPLETE",
                QuantizationEventVariant2Type.QuantizationModelDownloadComplete => "QUANTIZATION_MODEL_DOWNLOAD_COMPLETE",
                QuantizationEventVariant2Type.QuantizationModelUploadComplete => "QUANTIZATION_MODEL_UPLOAD_COMPLETE",
                QuantizationEventVariant2Type.QuantizationQuantizeProcessComplete => "QUANTIZATION_QUANTIZE_PROCESS_COMPLETE",
                QuantizationEventVariant2Type.QuantizationQuantizeProcessStart => "QUANTIZATION_QUANTIZE_PROCESS_START",
                QuantizationEventVariant2Type.ShapingError => "SHAPING_ERROR",
                QuantizationEventVariant2Type.ShapingUserError => "SHAPING_USER_ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QuantizationEventVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "QUANTIZATION_JOB_COMPLETE" => QuantizationEventVariant2Type.QuantizationJobComplete,
                "QUANTIZATION_JOB_START" => QuantizationEventVariant2Type.QuantizationJobStart,
                "QUANTIZATION_MERGE_COMPLETE" => QuantizationEventVariant2Type.QuantizationMergeComplete,
                "QUANTIZATION_MODEL_DOWNLOAD_COMPLETE" => QuantizationEventVariant2Type.QuantizationModelDownloadComplete,
                "QUANTIZATION_MODEL_UPLOAD_COMPLETE" => QuantizationEventVariant2Type.QuantizationModelUploadComplete,
                "QUANTIZATION_QUANTIZE_PROCESS_COMPLETE" => QuantizationEventVariant2Type.QuantizationQuantizeProcessComplete,
                "QUANTIZATION_QUANTIZE_PROCESS_START" => QuantizationEventVariant2Type.QuantizationQuantizeProcessStart,
                "SHAPING_ERROR" => QuantizationEventVariant2Type.ShapingError,
                "SHAPING_USER_ERROR" => QuantizationEventVariant2Type.ShapingUserError,
                _ => null,
            };
        }
    }
}