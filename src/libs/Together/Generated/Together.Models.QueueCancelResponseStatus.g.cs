
#nullable enable

namespace Together
{
    /// <summary>
    /// Job status after the cancel attempt. Only pending jobs can be<br/>
    /// canceled. If the job is already running, done, or failed, the status<br/>
    /// is returned unchanged.
    /// </summary>
    public enum QueueCancelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueCancelResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueCancelResponseStatus value)
        {
            return value switch
            {
                QueueCancelResponseStatus.Canceled => "canceled",
                QueueCancelResponseStatus.Running => "running",
                QueueCancelResponseStatus.Done => "done",
                QueueCancelResponseStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueCancelResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => QueueCancelResponseStatus.Canceled,
                "running" => QueueCancelResponseStatus.Running,
                "done" => QueueCancelResponseStatus.Done,
                "failed" => QueueCancelResponseStatus.Failed,
                _ => null,
            };
        }
    }
}