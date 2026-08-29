
#nullable enable

namespace Together
{
    /// <summary>
    /// Lifecycle state of a file in the validation pipeline. The typical<br/>
    /// progression is `PENDING` → `QUEUED` → `RUNNING` → `COMPLETED` /<br/>
    /// `FAILED`. `INVALID_FORMAT` is a terminal state for files whose<br/>
    /// contents failed validation in a user-correctable way.
    /// </summary>
    public enum FileProcessingStatus
    {
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
        InvalidFormat,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileProcessingStatus value)
        {
            return value switch
            {
                FileProcessingStatus.Completed => "COMPLETED",
                FileProcessingStatus.Failed => "FAILED",
                FileProcessingStatus.InvalidFormat => "INVALID_FORMAT",
                FileProcessingStatus.Pending => "PENDING",
                FileProcessingStatus.Queued => "QUEUED",
                FileProcessingStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => FileProcessingStatus.Completed,
                "FAILED" => FileProcessingStatus.Failed,
                "INVALID_FORMAT" => FileProcessingStatus.InvalidFormat,
                "PENDING" => FileProcessingStatus.Pending,
                "QUEUED" => FileProcessingStatus.Queued,
                "RUNNING" => FileProcessingStatus.Running,
                _ => null,
            };
        }
    }
}