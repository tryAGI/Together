
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
        Updating,
        /// <summary>
        /// 
        /// </summary>
        Scaling,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Failed,
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
                DeploymentStatus.Updating => "Updating",
                DeploymentStatus.Scaling => "Scaling",
                DeploymentStatus.Ready => "Ready",
                DeploymentStatus.Failed => "Failed",
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
                "Updating" => DeploymentStatus.Updating,
                "Scaling" => DeploymentStatus.Scaling,
                "Ready" => DeploymentStatus.Ready,
                "Failed" => DeploymentStatus.Failed,
                _ => null,
            };
        }
    }
}