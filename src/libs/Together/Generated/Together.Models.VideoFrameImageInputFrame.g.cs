
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoFrameImageInputFrame
    {
        /// <summary>
        /// 
        /// </summary>
        First,
        /// <summary>
        /// 
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoFrameImageInputFrameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoFrameImageInputFrame value)
        {
            return value switch
            {
                VideoFrameImageInputFrame.First => "first",
                VideoFrameImageInputFrame.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoFrameImageInputFrame? ToEnum(string value)
        {
            return value switch
            {
                "first" => VideoFrameImageInputFrame.First,
                "last" => VideoFrameImageInputFrame.Last,
                _ => null,
            };
        }
    }
}