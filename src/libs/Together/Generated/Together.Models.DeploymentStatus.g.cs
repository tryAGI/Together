
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
        DeploymentStatusFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatusReady,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatusScaling,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatusUpdating,
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
                DeploymentStatus.DeploymentStatusFailed => "Failed",
                DeploymentStatus.DeploymentStatusReady => "Ready",
                DeploymentStatus.DeploymentStatusScaling => "Scaling",
                DeploymentStatus.DeploymentStatusUpdating => "Updating",
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
                "Failed" => DeploymentStatus.DeploymentStatusFailed,
                "Ready" => DeploymentStatus.DeploymentStatusReady,
                "Scaling" => DeploymentStatus.DeploymentStatusScaling,
                "Updating" => DeploymentStatus.DeploymentStatusUpdating,
                _ => null,
            };
        }
    }
}