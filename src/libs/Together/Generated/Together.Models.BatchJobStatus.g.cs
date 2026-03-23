
#nullable enable

namespace Together
{
    /// <summary>
    /// Current status of the batch job<br/>
    /// Example: IN_PROGRESS
    /// </summary>
    public enum BatchJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchJobStatus value)
        {
            return value switch
            {
                BatchJobStatus.Cancelled => "CANCELLED",
                BatchJobStatus.Completed => "COMPLETED",
                BatchJobStatus.Expired => "EXPIRED",
                BatchJobStatus.Failed => "FAILED",
                BatchJobStatus.InProgress => "IN_PROGRESS",
                BatchJobStatus.Validating => "VALIDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => BatchJobStatus.Cancelled,
                "COMPLETED" => BatchJobStatus.Completed,
                "EXPIRED" => BatchJobStatus.Expired,
                "FAILED" => BatchJobStatus.Failed,
                "IN_PROGRESS" => BatchJobStatus.InProgress,
                "VALIDATING" => BatchJobStatus.Validating,
                _ => null,
            };
        }
    }
}