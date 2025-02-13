
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListEndpointsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEndpointsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointsResponseObject value)
        {
            return value switch
            {
                ListEndpointsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEndpointsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListEndpointsResponseObject.List,
                _ => null,
            };
        }
    }
}