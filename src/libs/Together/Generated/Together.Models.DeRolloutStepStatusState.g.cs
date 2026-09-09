
#nullable enable

namespace Together
{
    /// <summary>
    /// Outcome of this step. Finished steps are PASSED, the live step mirrors the rollout state, skipped-over steps are SKIPPED, and unreached steps are PENDING.
    /// </summary>
    public enum DeRolloutStepStatusState
    {
        /// <summary>
        ///
        /// </summary>
        RolloutStepStateCanceled,
        /// <summary>
        ///
        /// </summary>
        RolloutStepStateFailed,
        /// <summary>
        ///
        /// </summary>
        RolloutStepStatePassed,
        /// <summary>
        ///
        /// </summary>
        RolloutStepStatePaused,
        /// <summary>
        ///
        /// </summary>
        RolloutStepStatePending,
        /// <summary>
        ///
        /// </summary>
        RolloutStepStateRunning,
        /// <summary>
        ///
        /// </summary>
        RolloutStepStateSkipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeRolloutStepStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRolloutStepStatusState value)
        {
            return value switch
            {
                DeRolloutStepStatusState.RolloutStepStateCanceled => "ROLLOUT_STEP_STATE_CANCELED",
                DeRolloutStepStatusState.RolloutStepStateFailed => "ROLLOUT_STEP_STATE_FAILED",
                DeRolloutStepStatusState.RolloutStepStatePassed => "ROLLOUT_STEP_STATE_PASSED",
                DeRolloutStepStatusState.RolloutStepStatePaused => "ROLLOUT_STEP_STATE_PAUSED",
                DeRolloutStepStatusState.RolloutStepStatePending => "ROLLOUT_STEP_STATE_PENDING",
                DeRolloutStepStatusState.RolloutStepStateRunning => "ROLLOUT_STEP_STATE_RUNNING",
                DeRolloutStepStatusState.RolloutStepStateSkipped => "ROLLOUT_STEP_STATE_SKIPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRolloutStepStatusState? ToEnum(string value)
        {
            return value switch
            {
                "ROLLOUT_STEP_STATE_CANCELED" => DeRolloutStepStatusState.RolloutStepStateCanceled,
                "ROLLOUT_STEP_STATE_FAILED" => DeRolloutStepStatusState.RolloutStepStateFailed,
                "ROLLOUT_STEP_STATE_PASSED" => DeRolloutStepStatusState.RolloutStepStatePassed,
                "ROLLOUT_STEP_STATE_PAUSED" => DeRolloutStepStatusState.RolloutStepStatePaused,
                "ROLLOUT_STEP_STATE_PENDING" => DeRolloutStepStatusState.RolloutStepStatePending,
                "ROLLOUT_STEP_STATE_RUNNING" => DeRolloutStepStatusState.RolloutStepStateRunning,
                "ROLLOUT_STEP_STATE_SKIPPED" => DeRolloutStepStatusState.RolloutStepStateSkipped,
                _ => null,
            };
        }
    }
}