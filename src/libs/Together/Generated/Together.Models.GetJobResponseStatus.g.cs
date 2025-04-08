
#nullable enable

namespace Together
{
    /// <summary>
    /// Example: Complete
    /// </summary>
    public enum GetJobResponseStatus
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
    public static class GetJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobResponseStatus value)
        {
            return value switch
            {
                GetJobResponseStatus.Queued => "Queued",
                GetJobResponseStatus.Running => "Running",
                GetJobResponseStatus.Complete => "Complete",
                GetJobResponseStatus.Failed => "Failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Queued" => GetJobResponseStatus.Queued,
                "Running" => GetJobResponseStatus.Running,
                "Complete" => GetJobResponseStatus.Complete,
                "Failed" => GetJobResponseStatus.Failed,
                _ => null,
            };
        }
    }
}