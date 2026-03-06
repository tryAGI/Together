
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `list`.
    /// </summary>
    public enum ListVolumesResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVolumesResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVolumesResponseObject value)
        {
            return value switch
            {
                ListVolumesResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVolumesResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListVolumesResponseObject.List,
                _ => null,
            };
        }
    }
}