
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioFileUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFileUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFileUrlType value)
        {
            return value switch
            {
                AudioFileUrlType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFileUrlType? ToEnum(string value)
        {
            return value switch
            {
                "url" => AudioFileUrlType.Url,
                _ => null,
            };
        }
    }
}