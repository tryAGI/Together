
#nullable enable

namespace Together
{
    /// <summary>
    /// Default Value: D_TYPE_UNSPECIFIED
    /// </summary>
    public enum RlDType
    {
        /// <summary>
        /// 
        /// </summary>
        DTypeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        DTypeInt64,
        /// <summary>
        /// 
        /// </summary>
        DTypeFloat32,
        /// <summary>
        /// 
        /// </summary>
        DTypeBfloat16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlDTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlDType value)
        {
            return value switch
            {
                RlDType.DTypeUnspecified => "D_TYPE_UNSPECIFIED",
                RlDType.DTypeInt64 => "D_TYPE_INT64",
                RlDType.DTypeFloat32 => "D_TYPE_FLOAT32",
                RlDType.DTypeBfloat16 => "D_TYPE_BFLOAT16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlDType? ToEnum(string value)
        {
            return value switch
            {
                "D_TYPE_UNSPECIFIED" => RlDType.DTypeUnspecified,
                "D_TYPE_INT64" => RlDType.DTypeInt64,
                "D_TYPE_FLOAT32" => RlDType.DTypeFloat32,
                "D_TYPE_BFLOAT16" => RlDType.DTypeBfloat16,
                _ => null,
            };
        }
    }
}