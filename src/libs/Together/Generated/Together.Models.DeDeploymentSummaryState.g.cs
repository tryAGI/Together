
#nullable enable

namespace Together
{
    /// <summary>
    /// Current state of the deployment.<br/>
    /// Included only in responses
    /// </summary>
    public enum DeDeploymentSummaryState
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
    public static class DeDeploymentSummaryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeDeploymentSummaryState value)
        {
            return value switch
            {
                DeDeploymentSummaryState.DeploymentStateDegraded => "DEPLOYMENT_STATE_DEGRADED",
                DeDeploymentSummaryState.DeploymentStateFailed => "DEPLOYMENT_STATE_FAILED",
                DeDeploymentSummaryState.DeploymentStateProvisioning => "DEPLOYMENT_STATE_PROVISIONING",
                DeDeploymentSummaryState.DeploymentStateReady => "DEPLOYMENT_STATE_READY",
                DeDeploymentSummaryState.DeploymentStateScaling => "DEPLOYMENT_STATE_SCALING",
                DeDeploymentSummaryState.DeploymentStateStopped => "DEPLOYMENT_STATE_STOPPED",
                DeDeploymentSummaryState.DeploymentStateStopping => "DEPLOYMENT_STATE_STOPPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeDeploymentSummaryState? ToEnum(string value)
        {
            return value switch
            {
                "DEPLOYMENT_STATE_DEGRADED" => DeDeploymentSummaryState.DeploymentStateDegraded,
                "DEPLOYMENT_STATE_FAILED" => DeDeploymentSummaryState.DeploymentStateFailed,
                "DEPLOYMENT_STATE_PROVISIONING" => DeDeploymentSummaryState.DeploymentStateProvisioning,
                "DEPLOYMENT_STATE_READY" => DeDeploymentSummaryState.DeploymentStateReady,
                "DEPLOYMENT_STATE_SCALING" => DeDeploymentSummaryState.DeploymentStateScaling,
                "DEPLOYMENT_STATE_STOPPED" => DeDeploymentSummaryState.DeploymentStateStopped,
                "DEPLOYMENT_STATE_STOPPING" => DeDeploymentSummaryState.DeploymentStateStopping,
                _ => null,
            };
        }
    }
}