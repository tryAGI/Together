
#nullable enable

namespace Together
{
    /// <summary>
    /// Current lifecycle state of the asynchronous import job.
    /// </summary>
    public enum DeRemoteUploadStatus
    {
        /// <summary>
        ///
        /// </summary>
        RemoteUploadStatusError,
        /// <summary>
        ///
        /// </summary>
        RemoteUploadStatusFailed,
        /// <summary>
        ///
        /// </summary>
        RemoteUploadStatusPending,
        /// <summary>
        ///
        /// </summary>
        RemoteUploadStatusRunning,
        /// <summary>
        ///
        /// </summary>
        RemoteUploadStatusSucceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeRemoteUploadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRemoteUploadStatus value)
        {
            return value switch
            {
                DeRemoteUploadStatus.RemoteUploadStatusError => "REMOTE_UPLOAD_STATUS_ERROR",
                DeRemoteUploadStatus.RemoteUploadStatusFailed => "REMOTE_UPLOAD_STATUS_FAILED",
                DeRemoteUploadStatus.RemoteUploadStatusPending => "REMOTE_UPLOAD_STATUS_PENDING",
                DeRemoteUploadStatus.RemoteUploadStatusRunning => "REMOTE_UPLOAD_STATUS_RUNNING",
                DeRemoteUploadStatus.RemoteUploadStatusSucceeded => "REMOTE_UPLOAD_STATUS_SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRemoteUploadStatus? ToEnum(string value)
        {
            return value switch
            {
                "REMOTE_UPLOAD_STATUS_ERROR" => DeRemoteUploadStatus.RemoteUploadStatusError,
                "REMOTE_UPLOAD_STATUS_FAILED" => DeRemoteUploadStatus.RemoteUploadStatusFailed,
                "REMOTE_UPLOAD_STATUS_PENDING" => DeRemoteUploadStatus.RemoteUploadStatusPending,
                "REMOTE_UPLOAD_STATUS_RUNNING" => DeRemoteUploadStatus.RemoteUploadStatusRunning,
                "REMOTE_UPLOAD_STATUS_SUCCEEDED" => DeRemoteUploadStatus.RemoteUploadStatusSucceeded,
                _ => null,
            };
        }
    }
}