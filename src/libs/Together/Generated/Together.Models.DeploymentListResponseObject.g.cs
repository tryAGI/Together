
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `list`.
    /// </summary>
    public enum DeploymentListResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentListResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentListResponseObject value)
        {
            return value switch
            {
                DeploymentListResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentListResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => DeploymentListResponseObject.List,
                _ => null,
            };
        }
    }
}