
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageResponseDataB64Type
    {
        /// <summary>
        /// 
        /// </summary>
        B64Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageResponseDataB64TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseDataB64Type value)
        {
            return value switch
            {
                ImageResponseDataB64Type.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseDataB64Type? ToEnum(string value)
        {
            return value switch
            {
                "b64_json" => ImageResponseDataB64Type.B64Json,
                _ => null,
            };
        }
    }
}