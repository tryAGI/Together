
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeploymentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatusUpdating,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatusScaling,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatusReady,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatusFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentStatus value)
        {
            return value switch
            {
                DeploymentStatus.DeploymentStatusUpdating => "Updating",
                DeploymentStatus.DeploymentStatusScaling => "Scaling",
                DeploymentStatus.DeploymentStatusReady => "Ready",
                DeploymentStatus.DeploymentStatusFailed => "Failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentStatus? ToEnum(string value)
        {
            return value switch
            {
                "Updating" => DeploymentStatus.DeploymentStatusUpdating,
                "Scaling" => DeploymentStatus.DeploymentStatusScaling,
                "Ready" => DeploymentStatus.DeploymentStatusReady,
                "Failed" => DeploymentStatus.DeploymentStatusFailed,
                _ => null,
            };
        }
    }
}