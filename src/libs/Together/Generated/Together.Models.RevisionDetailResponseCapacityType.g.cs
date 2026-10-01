
#nullable enable

namespace Together
{
    /// <summary>
    /// Capacity behavior for replicas above reserved capacity.
    /// </summary>
    public enum RevisionDetailResponseCapacityType
    {
        /// <summary>
        ///
        /// </summary>
        Preemptible,
        /// <summary>
        ///
        /// </summary>
        Stable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RevisionDetailResponseCapacityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevisionDetailResponseCapacityType value)
        {
            return value switch
            {
                RevisionDetailResponseCapacityType.Preemptible => "preemptible",
                RevisionDetailResponseCapacityType.Stable => "stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevisionDetailResponseCapacityType? ToEnum(string value)
        {
            return value switch
            {
                "preemptible" => RevisionDetailResponseCapacityType.Preemptible,
                "stable" => RevisionDetailResponseCapacityType.Stable,
                _ => null,
            };
        }
    }
}