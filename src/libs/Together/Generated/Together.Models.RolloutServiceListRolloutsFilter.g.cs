
#nullable enable

namespace Together
{
    /// <summary>
    /// Narrow results to active or terminal rollouts. Omit to list all rollouts.
    /// </summary>
    public enum RolloutServiceListRolloutsFilter
    {
        /// <summary>
        ///
        /// </summary>
        RolloutFilterActive,
        /// <summary>
        ///
        /// </summary>
        RolloutFilterTerminal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RolloutServiceListRolloutsFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RolloutServiceListRolloutsFilter value)
        {
            return value switch
            {
                RolloutServiceListRolloutsFilter.RolloutFilterActive => "ROLLOUT_FILTER_ACTIVE",
                RolloutServiceListRolloutsFilter.RolloutFilterTerminal => "ROLLOUT_FILTER_TERMINAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RolloutServiceListRolloutsFilter? ToEnum(string value)
        {
            return value switch
            {
                "ROLLOUT_FILTER_ACTIVE" => RolloutServiceListRolloutsFilter.RolloutFilterActive,
                "ROLLOUT_FILTER_TERMINAL" => RolloutServiceListRolloutsFilter.RolloutFilterTerminal,
                _ => null,
            };
        }
    }
}