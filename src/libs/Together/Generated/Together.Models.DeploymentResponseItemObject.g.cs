
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `deployment`.
    /// </summary>
    public enum DeploymentResponseItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        Deployment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentResponseItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentResponseItemObject value)
        {
            return value switch
            {
                DeploymentResponseItemObject.Deployment => "deployment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentResponseItemObject? ToEnum(string value)
        {
            return value switch
            {
                "deployment" => DeploymentResponseItemObject.Deployment,
                _ => null,
            };
        }
    }
}