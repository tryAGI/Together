
#nullable enable

namespace Together
{
    /// <summary>
    /// Output only. High-level rollout lifecycle state.<br/>
    /// Included only in responses
    /// </summary>
    public enum DeRolloutState
    {
        /// <summary>
        ///
        /// </summary>
        RolloutStateAborted,
        /// <summary>
        ///
        /// </summary>
        RolloutStateAborting,
        /// <summary>
        ///
        /// </summary>
        RolloutStateCanceled,
        /// <summary>
        ///
        /// </summary>
        RolloutStateCancelling,
        /// <summary>
        ///
        /// </summary>
        RolloutStateCompleted,
        /// <summary>
        ///
        /// </summary>
        RolloutStatePaused,
        /// <summary>
        ///
        /// </summary>
        RolloutStatePausing,
        /// <summary>
        ///
        /// </summary>
        RolloutStatePending,
        /// <summary>
        ///
        /// </summary>
        RolloutStateRunning,
        /// <summary>
        ///
        /// </summary>
        RolloutStateStabilizing,
        /// <summary>
        ///
        /// </summary>
        RolloutStateSystemPaused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeRolloutStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRolloutState value)
        {
            return value switch
            {
                DeRolloutState.RolloutStateAborted => "ROLLOUT_STATE_ABORTED",
                DeRolloutState.RolloutStateAborting => "ROLLOUT_STATE_ABORTING",
                DeRolloutState.RolloutStateCanceled => "ROLLOUT_STATE_CANCELED",
                DeRolloutState.RolloutStateCancelling => "ROLLOUT_STATE_CANCELLING",
                DeRolloutState.RolloutStateCompleted => "ROLLOUT_STATE_COMPLETED",
                DeRolloutState.RolloutStatePaused => "ROLLOUT_STATE_PAUSED",
                DeRolloutState.RolloutStatePausing => "ROLLOUT_STATE_PAUSING",
                DeRolloutState.RolloutStatePending => "ROLLOUT_STATE_PENDING",
                DeRolloutState.RolloutStateRunning => "ROLLOUT_STATE_RUNNING",
                DeRolloutState.RolloutStateStabilizing => "ROLLOUT_STATE_STABILIZING",
                DeRolloutState.RolloutStateSystemPaused => "ROLLOUT_STATE_SYSTEM_PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRolloutState? ToEnum(string value)
        {
            return value switch
            {
                "ROLLOUT_STATE_ABORTED" => DeRolloutState.RolloutStateAborted,
                "ROLLOUT_STATE_ABORTING" => DeRolloutState.RolloutStateAborting,
                "ROLLOUT_STATE_CANCELED" => DeRolloutState.RolloutStateCanceled,
                "ROLLOUT_STATE_CANCELLING" => DeRolloutState.RolloutStateCancelling,
                "ROLLOUT_STATE_COMPLETED" => DeRolloutState.RolloutStateCompleted,
                "ROLLOUT_STATE_PAUSED" => DeRolloutState.RolloutStatePaused,
                "ROLLOUT_STATE_PAUSING" => DeRolloutState.RolloutStatePausing,
                "ROLLOUT_STATE_PENDING" => DeRolloutState.RolloutStatePending,
                "ROLLOUT_STATE_RUNNING" => DeRolloutState.RolloutStateRunning,
                "ROLLOUT_STATE_STABILIZING" => DeRolloutState.RolloutStateStabilizing,
                "ROLLOUT_STATE_SYSTEM_PAUSED" => DeRolloutState.RolloutStateSystemPaused,
                _ => null,
            };
        }
    }
}