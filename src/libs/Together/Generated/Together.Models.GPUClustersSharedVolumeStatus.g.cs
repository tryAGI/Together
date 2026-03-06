
#nullable enable

namespace Together
{
    /// <summary>
    /// Deployment status of the volume.
    /// </summary>
    public enum GPUClustersSharedVolumeStatus
    {
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
        Provisioning,
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
                GPUClustersSharedVolumeStatus.Available => "available",
                GPUClustersSharedVolumeStatus.Bound => "bound",
                GPUClustersSharedVolumeStatus.Provisioning => "provisioning",
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
                "available" => GPUClustersSharedVolumeStatus.Available,
                "bound" => GPUClustersSharedVolumeStatus.Bound,
                "provisioning" => GPUClustersSharedVolumeStatus.Provisioning,
                _ => null,
            };
        }
    }
}