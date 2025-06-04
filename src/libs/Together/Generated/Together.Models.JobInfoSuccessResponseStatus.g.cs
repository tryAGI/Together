
#nullable enable

namespace Together
{
    /// <summary>
    /// Example: Complete
    /// </summary>
    public enum JobInfoSuccessResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobInfoSuccessResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobInfoSuccessResponseStatus value)
        {
            return value switch
            {
                JobInfoSuccessResponseStatus.Queued => "Queued",
                JobInfoSuccessResponseStatus.Running => "Running",
                JobInfoSuccessResponseStatus.Complete => "Complete",
                JobInfoSuccessResponseStatus.Failed => "Failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobInfoSuccessResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Queued" => JobInfoSuccessResponseStatus.Queued,
                "Running" => JobInfoSuccessResponseStatus.Running,
                "Complete" => JobInfoSuccessResponseStatus.Complete,
                "Failed" => JobInfoSuccessResponseStatus.Failed,
                _ => null,
            };
        }
    }
}