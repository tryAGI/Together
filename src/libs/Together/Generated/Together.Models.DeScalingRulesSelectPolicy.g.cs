
#nullable enable

namespace Together
{
    /// <summary>
    /// `SCALING_POLICY_SELECT_MIN` chooses the policy allowing the smallest replica change;<br/>
    /// `SCALING_POLICY_SELECT_MAX` chooses the largest. These are caps, not guaranteed changes.<br/>
    /// `SCALING_POLICY_SELECT_DISABLED` holds this direction steady while replica bounds still apply.<br/>
    /// Omitted preserves the existing selector on update. When no selector is configured,<br/>
    /// authored policies use MAX; with no policies configured, the platform defaults apply.<br/>
    /// To reset the selector, include `autoscaling.scaleDown.selectPolicy` or<br/>
    /// `autoscaling.scaleUp.selectPolicy` in the update mask and omit `selectPolicy`.<br/>
    /// Clear both policies and `selectPolicy` to restore inherited defaults.
    /// </summary>
    public enum DeScalingRulesSelectPolicy
    {
        /// <summary>
        ///
        /// </summary>
        ScalingPolicySelectDisabled,
        /// <summary>
        ///
        /// </summary>
        ScalingPolicySelectMax,
        /// <summary>
        ///
        /// </summary>
        ScalingPolicySelectMin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeScalingRulesSelectPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeScalingRulesSelectPolicy value)
        {
            return value switch
            {
                DeScalingRulesSelectPolicy.ScalingPolicySelectDisabled => "SCALING_POLICY_SELECT_DISABLED",
                DeScalingRulesSelectPolicy.ScalingPolicySelectMax => "SCALING_POLICY_SELECT_MAX",
                DeScalingRulesSelectPolicy.ScalingPolicySelectMin => "SCALING_POLICY_SELECT_MIN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeScalingRulesSelectPolicy? ToEnum(string value)
        {
            return value switch
            {
                "SCALING_POLICY_SELECT_DISABLED" => DeScalingRulesSelectPolicy.ScalingPolicySelectDisabled,
                "SCALING_POLICY_SELECT_MAX" => DeScalingRulesSelectPolicy.ScalingPolicySelectMax,
                "SCALING_POLICY_SELECT_MIN" => DeScalingRulesSelectPolicy.ScalingPolicySelectMin,
                _ => null,
            };
        }
    }
}