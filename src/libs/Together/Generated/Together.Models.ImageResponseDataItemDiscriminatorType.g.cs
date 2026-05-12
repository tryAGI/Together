
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageResponseDataItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        B64Json,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageResponseDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseDataItemDiscriminatorType value)
        {
            return value switch
            {
                ImageResponseDataItemDiscriminatorType.B64Json => "b64_json",
                ImageResponseDataItemDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "b64_json" => ImageResponseDataItemDiscriminatorType.B64Json,
                "url" => ImageResponseDataItemDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}