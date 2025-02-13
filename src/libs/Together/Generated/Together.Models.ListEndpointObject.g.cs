
#nullable enable

namespace Together
{
    /// <summary>
    /// The type of object<br/>
    /// Example: endpoint
    /// </summary>
    public enum ListEndpointObject
    {
        /// <summary>
        /// 
        /// </summary>
        Endpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEndpointObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointObject value)
        {
            return value switch
            {
                ListEndpointObject.Endpoint => "endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEndpointObject? ToEnum(string value)
        {
            return value switch
            {
                "endpoint" => ListEndpointObject.Endpoint,
                _ => null,
            };
        }
    }
}