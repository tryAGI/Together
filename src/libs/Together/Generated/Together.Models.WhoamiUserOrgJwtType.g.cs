
#nullable enable

namespace Together
{
    /// <summary>
    /// Always `user_org_jwt`.
    /// </summary>
    public enum WhoamiUserOrgJwtType
    {
        /// <summary>
        ///
        /// </summary>
        UserOrgJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhoamiUserOrgJwtTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhoamiUserOrgJwtType value)
        {
            return value switch
            {
                WhoamiUserOrgJwtType.UserOrgJwt => "user_org_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhoamiUserOrgJwtType? ToEnum(string value)
        {
            return value switch
            {
                "user_org_jwt" => WhoamiUserOrgJwtType.UserOrgJwt,
                _ => null,
            };
        }
    }
}