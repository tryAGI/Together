
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
        VALIDATING,
        /// <summary>
        /// 
        /// </summary>
        INPROGRESS,
        /// <summary>
        /// 
        /// </summary>
        COMPLETED,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        EXPIRED,
        /// <summary>
        /// 
        /// </summary>
        CANCELLED,
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
                BatchJobStatus.VALIDATING => "VALIDATING",
                BatchJobStatus.INPROGRESS => "IN_PROGRESS",
                BatchJobStatus.COMPLETED => "COMPLETED",
                BatchJobStatus.FAILED => "FAILED",
                BatchJobStatus.EXPIRED => "EXPIRED",
                BatchJobStatus.CANCELLED => "CANCELLED",
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
                "VALIDATING" => BatchJobStatus.VALIDATING,
                "IN_PROGRESS" => BatchJobStatus.INPROGRESS,
                "COMPLETED" => BatchJobStatus.COMPLETED,
                "FAILED" => BatchJobStatus.FAILED,
                "EXPIRED" => BatchJobStatus.EXPIRED,
                "CANCELLED" => BatchJobStatus.CANCELLED,
                _ => null,
            };
        }
    }
}