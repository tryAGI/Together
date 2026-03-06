
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `secret`.
    /// </summary>
    public enum SecretResponseItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretResponseItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretResponseItemObject value)
        {
            return value switch
            {
                SecretResponseItemObject.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretResponseItemObject? ToEnum(string value)
        {
            return value switch
            {
                "secret" => SecretResponseItemObject.Secret,
                _ => null,
            };
        }
    }
}