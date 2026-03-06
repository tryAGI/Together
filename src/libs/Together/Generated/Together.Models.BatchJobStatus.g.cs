
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
        Validating,
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
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
                BatchJobStatus.Validating => "VALIDATING",
                BatchJobStatus.InProgress => "IN_PROGRESS",
                BatchJobStatus.Completed => "COMPLETED",
                BatchJobStatus.Failed => "FAILED",
                BatchJobStatus.Expired => "EXPIRED",
                BatchJobStatus.Cancelled => "CANCELLED",
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
                "VALIDATING" => BatchJobStatus.Validating,
                "IN_PROGRESS" => BatchJobStatus.InProgress,
                "COMPLETED" => BatchJobStatus.Completed,
                "FAILED" => BatchJobStatus.Failed,
                "EXPIRED" => BatchJobStatus.Expired,
                "CANCELLED" => BatchJobStatus.Cancelled,
                _ => null,
            };
        }
    }
}