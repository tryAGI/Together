
#nullable enable

namespace Together
{
    /// <summary>
    /// Current status of the shared volume.
    /// </summary>
    public enum GPUClustersSharedVolumeStatus
    {
        /// <summary>
        ///
        /// </summary>
        AccessRevoked,
        /// <summary>
        ///
        /// </summary>
        Available,
        /// <summary>
        ///
        /// </summary>
        Bound,
        /// <summary>
        ///
        /// </summary>
        Deleting,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Provisioning,
        /// <summary>
        ///
        /// </summary>
        Scheduled,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClustersSharedVolumeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClustersSharedVolumeStatus value)
        {
            return value switch
            {
                GPUClustersSharedVolumeStatus.AccessRevoked => "access_revoked",
                GPUClustersSharedVolumeStatus.Available => "available",
                GPUClustersSharedVolumeStatus.Bound => "bound",
                GPUClustersSharedVolumeStatus.Deleting => "deleting",
                GPUClustersSharedVolumeStatus.Failed => "failed",
                GPUClustersSharedVolumeStatus.Provisioning => "provisioning",
                GPUClustersSharedVolumeStatus.Scheduled => "scheduled",
                GPUClustersSharedVolumeStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClustersSharedVolumeStatus? ToEnum(string value)
        {
            return value switch
            {
                "access_revoked" => GPUClustersSharedVolumeStatus.AccessRevoked,
                "available" => GPUClustersSharedVolumeStatus.Available,
                "bound" => GPUClustersSharedVolumeStatus.Bound,
                "deleting" => GPUClustersSharedVolumeStatus.Deleting,
                "failed" => GPUClustersSharedVolumeStatus.Failed,
                "provisioning" => GPUClustersSharedVolumeStatus.Provisioning,
                "scheduled" => GPUClustersSharedVolumeStatus.Scheduled,
                "unknown" => GPUClustersSharedVolumeStatus.Unknown,
                _ => null,
            };
        }
    }
}