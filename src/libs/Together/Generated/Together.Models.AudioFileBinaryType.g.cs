
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioFileBinaryType
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFileBinaryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFileBinaryType value)
        {
            return value switch
            {
                AudioFileBinaryType.Binary => "binary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFileBinaryType? ToEnum(string value)
        {
            return value switch
            {
                "binary" => AudioFileBinaryType.Binary,
                _ => null,
            };
        }
    }
}