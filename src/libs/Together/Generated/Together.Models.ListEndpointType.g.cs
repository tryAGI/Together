
#nullable enable

namespace Together
{
    /// <summary>
    /// The type of endpoint<br/>
    /// Example: serverless
    /// </summary>
    public enum ListEndpointType
    {
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
        /// <summary>
        /// 
        /// </summary>
        Serverless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointType value)
        {
            return value switch
            {
                ListEndpointType.Dedicated => "dedicated",
                ListEndpointType.Serverless => "serverless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEndpointType? ToEnum(string value)
        {
            return value switch
            {
                "dedicated" => ListEndpointType.Dedicated,
                "serverless" => ListEndpointType.Serverless,
                _ => null,
            };
        }
    }
}