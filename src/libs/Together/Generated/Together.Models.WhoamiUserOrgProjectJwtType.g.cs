
#nullable enable

namespace Together
{
    /// <summary>
    /// Always `user_org_project_jwt`.
    /// </summary>
    public enum WhoamiUserOrgProjectJwtType
    {
        /// <summary>
        ///
        /// </summary>
        UserOrgProjectJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhoamiUserOrgProjectJwtTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhoamiUserOrgProjectJwtType value)
        {
            return value switch
            {
                WhoamiUserOrgProjectJwtType.UserOrgProjectJwt => "user_org_project_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhoamiUserOrgProjectJwtType? ToEnum(string value)
        {
            return value switch
            {
                "user_org_project_jwt" => WhoamiUserOrgProjectJwtType.UserOrgProjectJwt,
                _ => null,
            };
        }
    }
}