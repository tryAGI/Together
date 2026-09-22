
#nullable enable

namespace Together
{
    /// <summary>
    /// Controls how replicas above reserved capacity behave. `stable` replicas stay running after scale-up; `preemptible` replicas may be evicted during capacity contention.
    /// </summary>
    public enum DeploymentResponseItemCapacityType
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
    public static class DeploymentResponseItemCapacityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentResponseItemCapacityType value)
        {
            return value switch
            {
                DeploymentResponseItemCapacityType.Preemptible => "preemptible",
                DeploymentResponseItemCapacityType.Stable => "stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentResponseItemCapacityType? ToEnum(string value)
        {
            return value switch
            {
                "preemptible" => DeploymentResponseItemCapacityType.Preemptible,
                "stable" => DeploymentResponseItemCapacityType.Stable,
                _ => null,
            };
        }
    }
}