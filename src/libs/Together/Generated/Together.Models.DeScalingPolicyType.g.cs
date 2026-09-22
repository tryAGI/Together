
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether `value` is a replica count or a percentage of the replica count at the start<br/>
    /// of the trailing period. Scaling events within that period count against the allowance;<br/>
    /// percentages are rounded to whole replicas.
    /// </summary>
    public enum DeScalingPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        ScalingPolicyTypePercent,
        /// <summary>
        ///
        /// </summary>
        ScalingPolicyTypePods,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeScalingPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeScalingPolicyType value)
        {
            return value switch
            {
                DeScalingPolicyType.ScalingPolicyTypePercent => "SCALING_POLICY_TYPE_PERCENT",
                DeScalingPolicyType.ScalingPolicyTypePods => "SCALING_POLICY_TYPE_PODS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeScalingPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "SCALING_POLICY_TYPE_PERCENT" => DeScalingPolicyType.ScalingPolicyTypePercent,
                "SCALING_POLICY_TYPE_PODS" => DeScalingPolicyType.ScalingPolicyTypePods,
                _ => null,
            };
        }
    }
}