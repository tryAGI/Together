
#nullable enable

namespace Together
{
    /// <summary>
    /// High-level lifecycle state.
    /// </summary>
    public enum DeDeploymentStatusState
    {
        /// <summary>
        ///
        /// </summary>
        DeploymentStateDegraded,
        /// <summary>
        ///
        /// </summary>
        DeploymentStateFailed,
        /// <summary>
        ///
        /// </summary>
        DeploymentStateProvisioning,
        /// <summary>
        ///
        /// </summary>
        DeploymentStateReady,
        /// <summary>
        ///
        /// </summary>
        DeploymentStateScaling,
        /// <summary>
        ///
        /// </summary>
        DeploymentStateStopped,
        /// <summary>
        ///
        /// </summary>
        DeploymentStateStopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeDeploymentStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeDeploymentStatusState value)
        {
            return value switch
            {
                DeDeploymentStatusState.DeploymentStateDegraded => "DEPLOYMENT_STATE_DEGRADED",
                DeDeploymentStatusState.DeploymentStateFailed => "DEPLOYMENT_STATE_FAILED",
                DeDeploymentStatusState.DeploymentStateProvisioning => "DEPLOYMENT_STATE_PROVISIONING",
                DeDeploymentStatusState.DeploymentStateReady => "DEPLOYMENT_STATE_READY",
                DeDeploymentStatusState.DeploymentStateScaling => "DEPLOYMENT_STATE_SCALING",
                DeDeploymentStatusState.DeploymentStateStopped => "DEPLOYMENT_STATE_STOPPED",
                DeDeploymentStatusState.DeploymentStateStopping => "DEPLOYMENT_STATE_STOPPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeDeploymentStatusState? ToEnum(string value)
        {
            return value switch
            {
                "DEPLOYMENT_STATE_DEGRADED" => DeDeploymentStatusState.DeploymentStateDegraded,
                "DEPLOYMENT_STATE_FAILED" => DeDeploymentStatusState.DeploymentStateFailed,
                "DEPLOYMENT_STATE_PROVISIONING" => DeDeploymentStatusState.DeploymentStateProvisioning,
                "DEPLOYMENT_STATE_READY" => DeDeploymentStatusState.DeploymentStateReady,
                "DEPLOYMENT_STATE_SCALING" => DeDeploymentStatusState.DeploymentStateScaling,
                "DEPLOYMENT_STATE_STOPPED" => DeDeploymentStatusState.DeploymentStateStopped,
                "DEPLOYMENT_STATE_STOPPING" => DeDeploymentStatusState.DeploymentStateStopping,
                _ => null,
            };
        }
    }
}