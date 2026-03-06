
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `list`.
    /// </summary>
    public enum ListSecretsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSecretsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSecretsResponseObject value)
        {
            return value switch
            {
                ListSecretsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSecretsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListSecretsResponseObject.List,
                _ => null,
            };
        }
    }
}