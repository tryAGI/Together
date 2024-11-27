
#nullable enable

namespace Together
{
    /// <summary>
    /// Format of the image response. Can be either a base64 string or a URL.
    /// </summary>
    public enum RequestResponseFormat
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
    public static class RequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestResponseFormat value)
        {
            return value switch
            {
                RequestResponseFormat.Base64 => "base64",
                RequestResponseFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => RequestResponseFormat.Base64,
                "url" => RequestResponseFormat.Url,
                _ => null,
            };
        }
    }
}