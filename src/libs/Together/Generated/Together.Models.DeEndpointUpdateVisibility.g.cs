
#nullable enable

namespace Together
{
    /// <summary>
    /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
    /// Default Value: VISIBILITY_PRIVATE
    /// </summary>
    public enum DeEndpointUpdateVisibility
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
    public static class DeEndpointUpdateVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeEndpointUpdateVisibility value)
        {
            return value switch
            {
                DeEndpointUpdateVisibility.VisibilityInternal => "VISIBILITY_INTERNAL",
                DeEndpointUpdateVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeEndpointUpdateVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_INTERNAL" => DeEndpointUpdateVisibility.VisibilityInternal,
                "VISIBILITY_PRIVATE" => DeEndpointUpdateVisibility.VisibilityPrivate,
                _ => null,
            };
        }
    }
}