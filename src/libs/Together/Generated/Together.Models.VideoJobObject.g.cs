
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always video.
    /// </summary>
    public enum VideoJobObject
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoJobObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoJobObject value)
        {
            return value switch
            {
                VideoJobObject.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoJobObject? ToEnum(string value)
        {
            return value switch
            {
                "video" => VideoJobObject.Video,
                _ => null,
            };
        }
    }
}