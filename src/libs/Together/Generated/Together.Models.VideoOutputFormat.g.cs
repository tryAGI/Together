
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoOutputFormat value)
        {
            return value switch
            {
                VideoOutputFormat.Mp4 => "MP4",
                VideoOutputFormat.Webm => "WEBM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "MP4" => VideoOutputFormat.Mp4,
                "WEBM" => VideoOutputFormat.Webm,
                _ => null,
            };
        }
    }
}