
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageResponseDataUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageResponseDataUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseDataUrlType value)
        {
            return value switch
            {
                ImageResponseDataUrlType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseDataUrlType? ToEnum(string value)
        {
            return value switch
            {
                "url" => ImageResponseDataUrlType.Url,
                _ => null,
            };
        }
    }
}