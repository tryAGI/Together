
#nullable enable

namespace Together
{
    /// <summary>
    /// Serving class of the endpoint. Reserved endpoints use reserved capacity.<br/>
    /// Included only in responses
    /// </summary>
    public enum DeEndpointEndpointType
    {
        /// <summary>
        ///
        /// </summary>
        EndpointTypeDedicated,
        /// <summary>
        ///
        /// </summary>
        EndpointTypeReserved,
        /// <summary>
        ///
        /// </summary>
        EndpointTypeServerless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeEndpointEndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeEndpointEndpointType value)
        {
            return value switch
            {
                DeEndpointEndpointType.EndpointTypeDedicated => "ENDPOINT_TYPE_DEDICATED",
                DeEndpointEndpointType.EndpointTypeReserved => "ENDPOINT_TYPE_RESERVED",
                DeEndpointEndpointType.EndpointTypeServerless => "ENDPOINT_TYPE_SERVERLESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeEndpointEndpointType? ToEnum(string value)
        {
            return value switch
            {
                "ENDPOINT_TYPE_DEDICATED" => DeEndpointEndpointType.EndpointTypeDedicated,
                "ENDPOINT_TYPE_RESERVED" => DeEndpointEndpointType.EndpointTypeReserved,
                "ENDPOINT_TYPE_SERVERLESS" => DeEndpointEndpointType.EndpointTypeServerless,
                _ => null,
            };
        }
    }
}