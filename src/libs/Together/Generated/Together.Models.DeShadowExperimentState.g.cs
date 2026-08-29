
#nullable enable

namespace Together
{
    /// <summary>
    /// Derived serving state, active when the experiment has at least one target.<br/>
    /// Included only in responses
    /// </summary>
    public enum DeShadowExperimentState
    {
        /// <summary>
        ///
        /// </summary>
        ShadowExperimentStateActive,
        /// <summary>
        ///
        /// </summary>
        ShadowExperimentStateInactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeShadowExperimentStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeShadowExperimentState value)
        {
            return value switch
            {
                DeShadowExperimentState.ShadowExperimentStateActive => "SHADOW_EXPERIMENT_STATE_ACTIVE",
                DeShadowExperimentState.ShadowExperimentStateInactive => "SHADOW_EXPERIMENT_STATE_INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeShadowExperimentState? ToEnum(string value)
        {
            return value switch
            {
                "SHADOW_EXPERIMENT_STATE_ACTIVE" => DeShadowExperimentState.ShadowExperimentStateActive,
                "SHADOW_EXPERIMENT_STATE_INACTIVE" => DeShadowExperimentState.ShadowExperimentStateInactive,
                _ => null,
            };
        }
    }
}