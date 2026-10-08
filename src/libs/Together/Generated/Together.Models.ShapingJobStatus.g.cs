
#nullable enable

namespace Together
{
    /// <summary>
    /// Lifecycle status of a shaping job.
    /// </summary>
    public enum ShapingJobStatus
    {
        /// <summary>
        ///
        /// </summary>
        CancelRequested,
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
        Error,
        /// <summary>
        ///
        /// </summary>
        Pending,
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
        UserError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShapingJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShapingJobStatus value)
        {
            return value switch
            {
                ShapingJobStatus.CancelRequested => "cancel_requested",
                ShapingJobStatus.Cancelled => "cancelled",
                ShapingJobStatus.Completed => "completed",
                ShapingJobStatus.Error => "error",
                ShapingJobStatus.Pending => "pending",
                ShapingJobStatus.Queued => "queued",
                ShapingJobStatus.Running => "running",
                ShapingJobStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShapingJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancel_requested" => ShapingJobStatus.CancelRequested,
                "cancelled" => ShapingJobStatus.Cancelled,
                "completed" => ShapingJobStatus.Completed,
                "error" => ShapingJobStatus.Error,
                "pending" => ShapingJobStatus.Pending,
                "queued" => ShapingJobStatus.Queued,
                "running" => ShapingJobStatus.Running,
                "user_error" => ShapingJobStatus.UserError,
                _ => null,
            };
        }
    }
}