
#nullable enable

namespace Together
{
    /// <summary>
    /// Current status of the GPU cluster.
    /// </summary>
    public enum GPUClusterInfoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        WaitingForControlPlaneNodes,
        /// <summary>
        /// 
        /// </summary>
        WaitingForDataPlaneNodes,
        /// <summary>
        /// 
        /// </summary>
        WaitingForSubnet,
        /// <summary>
        /// 
        /// </summary>
        WaitingForSharedVolume,
        /// <summary>
        /// 
        /// </summary>
        InstallingDrivers,
        /// <summary>
        /// 
        /// </summary>
        RunningAcceptanceTests,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        OnDemandComputePaused,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Degraded,
        /// <summary>
        /// 
        /// </summary>
        Deleting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClusterInfoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterInfoStatus value)
        {
            return value switch
            {
                GPUClusterInfoStatus.WaitingForControlPlaneNodes => "WaitingForControlPlaneNodes",
                GPUClusterInfoStatus.WaitingForDataPlaneNodes => "WaitingForDataPlaneNodes",
                GPUClusterInfoStatus.WaitingForSubnet => "WaitingForSubnet",
                GPUClusterInfoStatus.WaitingForSharedVolume => "WaitingForSharedVolume",
                GPUClusterInfoStatus.InstallingDrivers => "InstallingDrivers",
                GPUClusterInfoStatus.RunningAcceptanceTests => "RunningAcceptanceTests",
                GPUClusterInfoStatus.Paused => "Paused",
                GPUClusterInfoStatus.OnDemandComputePaused => "OnDemandComputePaused",
                GPUClusterInfoStatus.Ready => "Ready",
                GPUClusterInfoStatus.Degraded => "Degraded",
                GPUClusterInfoStatus.Deleting => "Deleting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterInfoStatus? ToEnum(string value)
        {
            return value switch
            {
                "WaitingForControlPlaneNodes" => GPUClusterInfoStatus.WaitingForControlPlaneNodes,
                "WaitingForDataPlaneNodes" => GPUClusterInfoStatus.WaitingForDataPlaneNodes,
                "WaitingForSubnet" => GPUClusterInfoStatus.WaitingForSubnet,
                "WaitingForSharedVolume" => GPUClusterInfoStatus.WaitingForSharedVolume,
                "InstallingDrivers" => GPUClusterInfoStatus.InstallingDrivers,
                "RunningAcceptanceTests" => GPUClusterInfoStatus.RunningAcceptanceTests,
                "Paused" => GPUClusterInfoStatus.Paused,
                "OnDemandComputePaused" => GPUClusterInfoStatus.OnDemandComputePaused,
                "Ready" => GPUClusterInfoStatus.Ready,
                "Degraded" => GPUClusterInfoStatus.Degraded,
                "Deleting" => GPUClusterInfoStatus.Deleting,
                _ => null,
            };
        }
    }
}