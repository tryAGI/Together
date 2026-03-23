
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
        Degraded,
        /// <summary>
        /// 
        /// </summary>
        Deleting,
        /// <summary>
        /// 
        /// </summary>
        InstallingDrivers,
        /// <summary>
        /// 
        /// </summary>
        OnDemandComputePaused,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        RunningAcceptanceTests,
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
        WaitingForSharedVolume,
        /// <summary>
        /// 
        /// </summary>
        WaitingForSubnet,
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
                GPUClusterInfoStatus.Degraded => "Degraded",
                GPUClusterInfoStatus.Deleting => "Deleting",
                GPUClusterInfoStatus.InstallingDrivers => "InstallingDrivers",
                GPUClusterInfoStatus.OnDemandComputePaused => "OnDemandComputePaused",
                GPUClusterInfoStatus.Paused => "Paused",
                GPUClusterInfoStatus.Ready => "Ready",
                GPUClusterInfoStatus.RunningAcceptanceTests => "RunningAcceptanceTests",
                GPUClusterInfoStatus.WaitingForControlPlaneNodes => "WaitingForControlPlaneNodes",
                GPUClusterInfoStatus.WaitingForDataPlaneNodes => "WaitingForDataPlaneNodes",
                GPUClusterInfoStatus.WaitingForSharedVolume => "WaitingForSharedVolume",
                GPUClusterInfoStatus.WaitingForSubnet => "WaitingForSubnet",
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
                "Degraded" => GPUClusterInfoStatus.Degraded,
                "Deleting" => GPUClusterInfoStatus.Deleting,
                "InstallingDrivers" => GPUClusterInfoStatus.InstallingDrivers,
                "OnDemandComputePaused" => GPUClusterInfoStatus.OnDemandComputePaused,
                "Paused" => GPUClusterInfoStatus.Paused,
                "Ready" => GPUClusterInfoStatus.Ready,
                "RunningAcceptanceTests" => GPUClusterInfoStatus.RunningAcceptanceTests,
                "WaitingForControlPlaneNodes" => GPUClusterInfoStatus.WaitingForControlPlaneNodes,
                "WaitingForDataPlaneNodes" => GPUClusterInfoStatus.WaitingForDataPlaneNodes,
                "WaitingForSharedVolume" => GPUClusterInfoStatus.WaitingForSharedVolume,
                "WaitingForSubnet" => GPUClusterInfoStatus.WaitingForSubnet,
                _ => null,
            };
        }
    }
}