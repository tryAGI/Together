
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListEndpointsType
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
    public static class ListEndpointsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointsType value)
        {
            return value switch
            {
                ListEndpointsType.Dedicated => "dedicated",
                ListEndpointsType.Serverless => "serverless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEndpointsType? ToEnum(string value)
        {
            return value switch
            {
                "dedicated" => ListEndpointsType.Dedicated,
                "serverless" => ListEndpointsType.Serverless,
                _ => null,
            };
        }
    }
}