
#nullable enable

namespace Together
{
    /// <summary>
    /// Output only. Whether this row describes the endpoint or one of its deployments.
    /// </summary>
    public enum DeEndpointEventSourceKind
    {
        /// <summary>
        ///
        /// </summary>
        SourceKindDeployment,
        /// <summary>
        ///
        /// </summary>
        SourceKindEndpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeEndpointEventSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeEndpointEventSourceKind value)
        {
            return value switch
            {
                DeEndpointEventSourceKind.SourceKindDeployment => "SOURCE_KIND_DEPLOYMENT",
                DeEndpointEventSourceKind.SourceKindEndpoint => "SOURCE_KIND_ENDPOINT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeEndpointEventSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "SOURCE_KIND_DEPLOYMENT" => DeEndpointEventSourceKind.SourceKindDeployment,
                "SOURCE_KIND_ENDPOINT" => DeEndpointEventSourceKind.SourceKindEndpoint,
                _ => null,
            };
        }
    }
}