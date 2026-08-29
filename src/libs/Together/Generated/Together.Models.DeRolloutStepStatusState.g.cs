
#nullable enable

namespace Together
{
    /// <summary>
    /// Execution state of this rollout step.
    /// </summary>
    public enum DeRolloutStepStatusState
    {
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
        RolloutStepStatePending,
        /// <summary>
        ///
        /// </summary>
        RolloutStepStateRunning,
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
                DeRolloutStepStatusState.RolloutStepStateFailed => "ROLLOUT_STEP_STATE_FAILED",
                DeRolloutStepStatusState.RolloutStepStatePassed => "ROLLOUT_STEP_STATE_PASSED",
                DeRolloutStepStatusState.RolloutStepStatePending => "ROLLOUT_STEP_STATE_PENDING",
                DeRolloutStepStatusState.RolloutStepStateRunning => "ROLLOUT_STEP_STATE_RUNNING",
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
                "ROLLOUT_STEP_STATE_FAILED" => DeRolloutStepStatusState.RolloutStepStateFailed,
                "ROLLOUT_STEP_STATE_PASSED" => DeRolloutStepStatusState.RolloutStepStatePassed,
                "ROLLOUT_STEP_STATE_PENDING" => DeRolloutStepStatusState.RolloutStepStatePending,
                "ROLLOUT_STEP_STATE_RUNNING" => DeRolloutStepStatusState.RolloutStepStateRunning,
                _ => null,
            };
        }
    }
}