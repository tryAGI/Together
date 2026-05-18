
#nullable enable

namespace Together
{
    /// <summary>
    /// Cluster phase.
    /// </summary>
    public enum ClusterPhaseTransitionPhase
    {
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseAcceptanceTestsFailed,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseDegraded,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseDeleting,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseInstallingDrivers,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseNcclTestsFailed,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseOnDemandComputePaused,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhasePaused,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseQueued,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseReady,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseRunningAcceptanceTests,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseRunningNcclTests,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseScheduled,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseWaitingForAutoScaler,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseWaitingForControlPlaneNodes,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseWaitingForDataPlaneNodes,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseWaitingForSharedVolume,
        /// <summary>
        /// 
        /// </summary>
        ClusterPhaseWaitingForSubnet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClusterPhaseTransitionPhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClusterPhaseTransitionPhase value)
        {
            return value switch
            {
                ClusterPhaseTransitionPhase.ClusterPhaseAcceptanceTestsFailed => "CLUSTER_PHASE_ACCEPTANCE_TESTS_FAILED",
                ClusterPhaseTransitionPhase.ClusterPhaseDegraded => "CLUSTER_PHASE_DEGRADED",
                ClusterPhaseTransitionPhase.ClusterPhaseDeleting => "CLUSTER_PHASE_DELETING",
                ClusterPhaseTransitionPhase.ClusterPhaseInstallingDrivers => "CLUSTER_PHASE_INSTALLING_DRIVERS",
                ClusterPhaseTransitionPhase.ClusterPhaseNcclTestsFailed => "CLUSTER_PHASE_NCCL_TESTS_FAILED",
                ClusterPhaseTransitionPhase.ClusterPhaseOnDemandComputePaused => "CLUSTER_PHASE_ON_DEMAND_COMPUTE_PAUSED",
                ClusterPhaseTransitionPhase.ClusterPhasePaused => "CLUSTER_PHASE_PAUSED",
                ClusterPhaseTransitionPhase.ClusterPhaseQueued => "CLUSTER_PHASE_QUEUED",
                ClusterPhaseTransitionPhase.ClusterPhaseReady => "CLUSTER_PHASE_READY",
                ClusterPhaseTransitionPhase.ClusterPhaseRunningAcceptanceTests => "CLUSTER_PHASE_RUNNING_ACCEPTANCE_TESTS",
                ClusterPhaseTransitionPhase.ClusterPhaseRunningNcclTests => "CLUSTER_PHASE_RUNNING_NCCL_TESTS",
                ClusterPhaseTransitionPhase.ClusterPhaseScheduled => "CLUSTER_PHASE_SCHEDULED",
                ClusterPhaseTransitionPhase.ClusterPhaseWaitingForAutoScaler => "CLUSTER_PHASE_WAITING_FOR_AUTO_SCALER",
                ClusterPhaseTransitionPhase.ClusterPhaseWaitingForControlPlaneNodes => "CLUSTER_PHASE_WAITING_FOR_CONTROL_PLANE_NODES",
                ClusterPhaseTransitionPhase.ClusterPhaseWaitingForDataPlaneNodes => "CLUSTER_PHASE_WAITING_FOR_DATA_PLANE_NODES",
                ClusterPhaseTransitionPhase.ClusterPhaseWaitingForSharedVolume => "CLUSTER_PHASE_WAITING_FOR_SHARED_VOLUME",
                ClusterPhaseTransitionPhase.ClusterPhaseWaitingForSubnet => "CLUSTER_PHASE_WAITING_FOR_SUBNET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClusterPhaseTransitionPhase? ToEnum(string value)
        {
            return value switch
            {
                "CLUSTER_PHASE_ACCEPTANCE_TESTS_FAILED" => ClusterPhaseTransitionPhase.ClusterPhaseAcceptanceTestsFailed,
                "CLUSTER_PHASE_DEGRADED" => ClusterPhaseTransitionPhase.ClusterPhaseDegraded,
                "CLUSTER_PHASE_DELETING" => ClusterPhaseTransitionPhase.ClusterPhaseDeleting,
                "CLUSTER_PHASE_INSTALLING_DRIVERS" => ClusterPhaseTransitionPhase.ClusterPhaseInstallingDrivers,
                "CLUSTER_PHASE_NCCL_TESTS_FAILED" => ClusterPhaseTransitionPhase.ClusterPhaseNcclTestsFailed,
                "CLUSTER_PHASE_ON_DEMAND_COMPUTE_PAUSED" => ClusterPhaseTransitionPhase.ClusterPhaseOnDemandComputePaused,
                "CLUSTER_PHASE_PAUSED" => ClusterPhaseTransitionPhase.ClusterPhasePaused,
                "CLUSTER_PHASE_QUEUED" => ClusterPhaseTransitionPhase.ClusterPhaseQueued,
                "CLUSTER_PHASE_READY" => ClusterPhaseTransitionPhase.ClusterPhaseReady,
                "CLUSTER_PHASE_RUNNING_ACCEPTANCE_TESTS" => ClusterPhaseTransitionPhase.ClusterPhaseRunningAcceptanceTests,
                "CLUSTER_PHASE_RUNNING_NCCL_TESTS" => ClusterPhaseTransitionPhase.ClusterPhaseRunningNcclTests,
                "CLUSTER_PHASE_SCHEDULED" => ClusterPhaseTransitionPhase.ClusterPhaseScheduled,
                "CLUSTER_PHASE_WAITING_FOR_AUTO_SCALER" => ClusterPhaseTransitionPhase.ClusterPhaseWaitingForAutoScaler,
                "CLUSTER_PHASE_WAITING_FOR_CONTROL_PLANE_NODES" => ClusterPhaseTransitionPhase.ClusterPhaseWaitingForControlPlaneNodes,
                "CLUSTER_PHASE_WAITING_FOR_DATA_PLANE_NODES" => ClusterPhaseTransitionPhase.ClusterPhaseWaitingForDataPlaneNodes,
                "CLUSTER_PHASE_WAITING_FOR_SHARED_VOLUME" => ClusterPhaseTransitionPhase.ClusterPhaseWaitingForSharedVolume,
                "CLUSTER_PHASE_WAITING_FOR_SUBNET" => ClusterPhaseTransitionPhase.ClusterPhaseWaitingForSubnet,
                _ => null,
            };
        }
    }
}