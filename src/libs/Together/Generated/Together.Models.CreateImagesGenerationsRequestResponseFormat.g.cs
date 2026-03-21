
#nullable enable

namespace Together
{
    /// <summary>
    /// Format of the image response. Can be either a base64 string or a URL.
    /// </summary>
    public enum CreateImagesGenerationsRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImagesGenerationsRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImagesGenerationsRequestResponseFormat value)
        {
            return value switch
            {
                CreateImagesGenerationsRequestResponseFormat.Base64 => "base64",
                CreateImagesGenerationsRequestResponseFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImagesGenerationsRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CreateImagesGenerationsRequestResponseFormat.Base64,
                "url" => CreateImagesGenerationsRequestResponseFormat.Url,
                _ => null,
            };
        }
    }
}