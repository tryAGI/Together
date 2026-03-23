
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
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
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
                JobInfoSuccessResponseStatus.Complete => "Complete",
                JobInfoSuccessResponseStatus.Failed => "Failed",
                JobInfoSuccessResponseStatus.Queued => "Queued",
                JobInfoSuccessResponseStatus.Running => "Running",
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
                "Complete" => JobInfoSuccessResponseStatus.Complete,
                "Failed" => JobInfoSuccessResponseStatus.Failed,
                "Queued" => JobInfoSuccessResponseStatus.Queued,
                "Running" => JobInfoSuccessResponseStatus.Running,
                _ => null,
            };
        }
    }
}