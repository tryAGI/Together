
#nullable enable

namespace Together
{
    /// <summary>
    /// Informational condition type. `CapacityLimited` means the current step advanced partially because full capacity was not placeable.
    /// </summary>
    public enum DeRolloutConditionType
    {
        /// <summary>
        ///
        /// </summary>
        CapacityLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeRolloutConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRolloutConditionType value)
        {
            return value switch
            {
                DeRolloutConditionType.CapacityLimited => "CapacityLimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRolloutConditionType? ToEnum(string value)
        {
            return value switch
            {
                "CapacityLimited" => DeRolloutConditionType.CapacityLimited,
                _ => null,
            };
        }
    }
}