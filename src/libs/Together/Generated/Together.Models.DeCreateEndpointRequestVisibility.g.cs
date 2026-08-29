
#nullable enable

namespace Together
{
    /// <summary>
    /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
    /// Default Value: VISIBILITY_PRIVATE
    /// </summary>
    public enum DeCreateEndpointRequestVisibility
    {
        /// <summary>
        ///
        /// </summary>
        VisibilityInternal,
        /// <summary>
        ///
        /// </summary>
        VisibilityPrivate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeCreateEndpointRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeCreateEndpointRequestVisibility value)
        {
            return value switch
            {
                DeCreateEndpointRequestVisibility.VisibilityInternal => "VISIBILITY_INTERNAL",
                DeCreateEndpointRequestVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeCreateEndpointRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_INTERNAL" => DeCreateEndpointRequestVisibility.VisibilityInternal,
                "VISIBILITY_PRIVATE" => DeCreateEndpointRequestVisibility.VisibilityPrivate,
                _ => null,
            };
        }
    }
}