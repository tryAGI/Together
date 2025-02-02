
#nullable enable

namespace Together
{
    /// <summary>
    /// The format of the image response. Can be either be `jpeg` or `png`. Defaults to `jpeg`.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum RequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestOutputFormat value)
        {
            return value switch
            {
                RequestOutputFormat.Jpeg => "jpeg",
                RequestOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => RequestOutputFormat.Jpeg,
                "png" => RequestOutputFormat.Png,
                _ => null,
            };
        }
    }
}