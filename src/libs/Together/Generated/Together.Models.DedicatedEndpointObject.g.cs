
#nullable enable

namespace Together
{
    /// <summary>
    /// The type of object<br/>
    /// Example: endpoint
    /// </summary>
    public enum DedicatedEndpointObject
    {
        /// <summary>
        /// 
        /// </summary>
        Endpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DedicatedEndpointObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DedicatedEndpointObject value)
        {
            return value switch
            {
                DedicatedEndpointObject.Endpoint => "endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DedicatedEndpointObject? ToEnum(string value)
        {
            return value switch
            {
                "endpoint" => DedicatedEndpointObject.Endpoint,
                _ => null,
            };
        }
    }
}