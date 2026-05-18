
#nullable enable

namespace Together
{
    /// <summary>
    /// Node phase.
    /// </summary>
    public enum NodePhaseTransitionPhase
    {
        /// <summary>
        /// 
        /// </summary>
        NodePhaseBooting,
        /// <summary>
        /// 
        /// </summary>
        NodePhaseBootstrapping,
        /// <summary>
        /// 
        /// </summary>
        NodePhaseFailed,
        /// <summary>
        /// 
        /// </summary>
        NodePhasePaused,
        /// <summary>
        /// 
        /// </summary>
        NodePhasePending,
        /// <summary>
        /// 
        /// </summary>
        NodePhaseRunning,
        /// <summary>
        /// 
        /// </summary>
        NodePhaseScheduling,
        /// <summary>
        /// 
        /// </summary>
        NodePhaseSucceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodePhaseTransitionPhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodePhaseTransitionPhase value)
        {
            return value switch
            {
                NodePhaseTransitionPhase.NodePhaseBooting => "NODE_PHASE_BOOTING",
                NodePhaseTransitionPhase.NodePhaseBootstrapping => "NODE_PHASE_BOOTSTRAPPING",
                NodePhaseTransitionPhase.NodePhaseFailed => "NODE_PHASE_FAILED",
                NodePhaseTransitionPhase.NodePhasePaused => "NODE_PHASE_PAUSED",
                NodePhaseTransitionPhase.NodePhasePending => "NODE_PHASE_PENDING",
                NodePhaseTransitionPhase.NodePhaseRunning => "NODE_PHASE_RUNNING",
                NodePhaseTransitionPhase.NodePhaseScheduling => "NODE_PHASE_SCHEDULING",
                NodePhaseTransitionPhase.NodePhaseSucceeded => "NODE_PHASE_SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodePhaseTransitionPhase? ToEnum(string value)
        {
            return value switch
            {
                "NODE_PHASE_BOOTING" => NodePhaseTransitionPhase.NodePhaseBooting,
                "NODE_PHASE_BOOTSTRAPPING" => NodePhaseTransitionPhase.NodePhaseBootstrapping,
                "NODE_PHASE_FAILED" => NodePhaseTransitionPhase.NodePhaseFailed,
                "NODE_PHASE_PAUSED" => NodePhaseTransitionPhase.NodePhasePaused,
                "NODE_PHASE_PENDING" => NodePhaseTransitionPhase.NodePhasePending,
                "NODE_PHASE_RUNNING" => NodePhaseTransitionPhase.NodePhaseRunning,
                "NODE_PHASE_SCHEDULING" => NodePhaseTransitionPhase.NodePhaseScheduling,
                "NODE_PHASE_SUCCEEDED" => NodePhaseTransitionPhase.NodePhaseSucceeded,
                _ => null,
            };
        }
    }
}