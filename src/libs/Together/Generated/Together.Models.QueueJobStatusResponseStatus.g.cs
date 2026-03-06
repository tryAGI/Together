
#nullable enable

namespace Together
{
    /// <summary>
    /// Current job status. Transitions: pending → running → done/failed. A pending job may also be canceled.
    /// </summary>
    public enum QueueJobStatusResponseStatus
    {
        /// <summary>
        /// pending → running → done/failed. A pending job may also be canceled.
        /// </summary>
        Pending,
        /// <summary>
        /// pending → running → done/failed. A pending job may also be canceled.
        /// </summary>
        Running,
        /// <summary>
        /// pending → running → done/failed. A pending job may also be canceled.
        /// </summary>
        Done,
        /// <summary>
        /// pending → running → done/failed. A pending job may also be canceled.
        /// </summary>
        Failed,
        /// <summary>
        /// pending → running → done/failed. A pending job may also be canceled.
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueJobStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueJobStatusResponseStatus value)
        {
            return value switch
            {
                QueueJobStatusResponseStatus.Pending => "pending",
                QueueJobStatusResponseStatus.Running => "running",
                QueueJobStatusResponseStatus.Done => "done",
                QueueJobStatusResponseStatus.Failed => "failed",
                QueueJobStatusResponseStatus.Canceled => "canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueJobStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => QueueJobStatusResponseStatus.Pending,
                "running" => QueueJobStatusResponseStatus.Running,
                "done" => QueueJobStatusResponseStatus.Done,
                "failed" => QueueJobStatusResponseStatus.Failed,
                "canceled" => QueueJobStatusResponseStatus.Canceled,
                _ => null,
            };
        }
    }
}