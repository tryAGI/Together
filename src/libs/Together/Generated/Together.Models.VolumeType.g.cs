
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum VolumeType
    {
        /// <summary>
        /// 
        /// </summary>
        VolumeTypeReadOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeType value)
        {
            return value switch
            {
                VolumeType.VolumeTypeReadOnly => "readOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "readOnly" => VolumeType.VolumeTypeReadOnly,
                _ => null,
            };
        }
    }
}