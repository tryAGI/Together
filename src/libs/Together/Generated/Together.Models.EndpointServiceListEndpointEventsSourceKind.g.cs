
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum EndpointServiceListEndpointEventsSourceKind
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
    public static class EndpointServiceListEndpointEventsSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndpointServiceListEndpointEventsSourceKind value)
        {
            return value switch
            {
                EndpointServiceListEndpointEventsSourceKind.SourceKindDeployment => "SOURCE_KIND_DEPLOYMENT",
                EndpointServiceListEndpointEventsSourceKind.SourceKindEndpoint => "SOURCE_KIND_ENDPOINT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndpointServiceListEndpointEventsSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "SOURCE_KIND_DEPLOYMENT" => EndpointServiceListEndpointEventsSourceKind.SourceKindDeployment,
                "SOURCE_KIND_ENDPOINT" => EndpointServiceListEndpointEventsSourceKind.SourceKindEndpoint,
                _ => null,
            };
        }
    }
}