
#nullable enable

namespace Together
{
    /// <summary>
    /// Output only. Rollout strategy selected at creation.<br/>
    /// Included only in responses
    /// </summary>
    public enum DeRolloutStrategy
    {
        /// <summary>
        ///
        /// </summary>
        RolloutStrategyTypeBlueGreen,
        /// <summary>
        ///
        /// </summary>
        RolloutStrategyTypeCanary,
        /// <summary>
        ///
        /// </summary>
        RolloutStrategyTypeRolling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeRolloutStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRolloutStrategy value)
        {
            return value switch
            {
                DeRolloutStrategy.RolloutStrategyTypeBlueGreen => "ROLLOUT_STRATEGY_TYPE_BLUE_GREEN",
                DeRolloutStrategy.RolloutStrategyTypeCanary => "ROLLOUT_STRATEGY_TYPE_CANARY",
                DeRolloutStrategy.RolloutStrategyTypeRolling => "ROLLOUT_STRATEGY_TYPE_ROLLING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRolloutStrategy? ToEnum(string value)
        {
            return value switch
            {
                "ROLLOUT_STRATEGY_TYPE_BLUE_GREEN" => DeRolloutStrategy.RolloutStrategyTypeBlueGreen,
                "ROLLOUT_STRATEGY_TYPE_CANARY" => DeRolloutStrategy.RolloutStrategyTypeCanary,
                "ROLLOUT_STRATEGY_TYPE_ROLLING" => DeRolloutStrategy.RolloutStrategyTypeRolling,
                _ => null,
            };
        }
    }
}