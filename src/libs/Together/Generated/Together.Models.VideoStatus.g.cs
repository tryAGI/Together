
#nullable enable

namespace Together
{
    /// <summary>
    /// Current lifecycle status of the video job.
    /// </summary>
    public enum VideoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoStatus value)
        {
            return value switch
            {
                VideoStatus.InProgress => "in_progress",
                VideoStatus.Completed => "completed",
                VideoStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => VideoStatus.InProgress,
                "completed" => VideoStatus.Completed,
                "failed" => VideoStatus.Failed,
                _ => null,
            };
        }
    }
}