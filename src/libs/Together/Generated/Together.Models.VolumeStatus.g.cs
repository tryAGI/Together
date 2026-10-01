
#nullable enable

namespace Together
{
    /// <summary>
    /// Status of a volume version. Only ready versions can be mounted.
    /// </summary>
    public enum VolumeStatus
    {
        /// <summary>
        ///
        /// </summary>
        VolumeStatusFailed,
        /// <summary>
        ///
        /// </summary>
        VolumeStatusPending,
        /// <summary>
        ///
        /// </summary>
        VolumeStatusReady,
        /// <summary>
        ///
        /// </summary>
        VolumeStatusSyncing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VolumeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeStatus value)
        {
            return value switch
            {
                VolumeStatus.VolumeStatusFailed => "failed",
                VolumeStatus.VolumeStatusPending => "pending",
                VolumeStatus.VolumeStatusReady => "ready",
                VolumeStatus.VolumeStatusSyncing => "syncing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => VolumeStatus.VolumeStatusFailed,
                "pending" => VolumeStatus.VolumeStatusPending,
                "ready" => VolumeStatus.VolumeStatusReady,
                "syncing" => VolumeStatus.VolumeStatusSyncing,
                _ => null,
            };
        }
    }
}