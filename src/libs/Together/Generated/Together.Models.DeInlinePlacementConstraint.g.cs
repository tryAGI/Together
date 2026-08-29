
#nullable enable

namespace Together
{
    /// <summary>
    /// How strictly the regions list is enforced.
    /// </summary>
    public enum DeInlinePlacementConstraint
    {
        /// <summary>
        ///
        /// </summary>
        EnforcementPreferred,
        /// <summary>
        ///
        /// </summary>
        EnforcementRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeInlinePlacementConstraintExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeInlinePlacementConstraint value)
        {
            return value switch
            {
                DeInlinePlacementConstraint.EnforcementPreferred => "ENFORCEMENT_PREFERRED",
                DeInlinePlacementConstraint.EnforcementRequired => "ENFORCEMENT_REQUIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeInlinePlacementConstraint? ToEnum(string value)
        {
            return value switch
            {
                "ENFORCEMENT_PREFERRED" => DeInlinePlacementConstraint.EnforcementPreferred,
                "ENFORCEMENT_REQUIRED" => DeInlinePlacementConstraint.EnforcementRequired,
                _ => null,
            };
        }
    }
}