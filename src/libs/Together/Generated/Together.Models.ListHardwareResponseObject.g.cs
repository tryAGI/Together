
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListHardwareResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListHardwareResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListHardwareResponseObject value)
        {
            return value switch
            {
                ListHardwareResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListHardwareResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListHardwareResponseObject.List,
                _ => null,
            };
        }
    }
}