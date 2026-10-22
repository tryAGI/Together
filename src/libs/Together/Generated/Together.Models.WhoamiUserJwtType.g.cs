
#nullable enable

namespace Together
{
    /// <summary>
    /// Always `user_jwt`.
    /// </summary>
    public enum WhoamiUserJwtType
    {
        /// <summary>
        ///
        /// </summary>
        UserJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhoamiUserJwtTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhoamiUserJwtType value)
        {
            return value switch
            {
                WhoamiUserJwtType.UserJwt => "user_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhoamiUserJwtType? ToEnum(string value)
        {
            return value switch
            {
                "user_jwt" => WhoamiUserJwtType.UserJwt,
                _ => null,
            };
        }
    }
}