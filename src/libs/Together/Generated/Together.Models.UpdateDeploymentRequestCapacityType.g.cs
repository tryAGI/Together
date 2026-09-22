
#nullable enable

namespace Together
{
    /// <summary>
    /// Controls how replicas above reserved capacity behave. `stable` replicas stay running after scale-up; `preemptible` replicas may be evicted during capacity contention.
    /// </summary>
    public enum UpdateDeploymentRequestCapacityType
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
    public static class UpdateDeploymentRequestCapacityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentRequestCapacityType value)
        {
            return value switch
            {
                UpdateDeploymentRequestCapacityType.Preemptible => "preemptible",
                UpdateDeploymentRequestCapacityType.Stable => "stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentRequestCapacityType? ToEnum(string value)
        {
            return value switch
            {
                "preemptible" => UpdateDeploymentRequestCapacityType.Preemptible,
                "stable" => UpdateDeploymentRequestCapacityType.Stable,
                _ => null,
            };
        }
    }
}