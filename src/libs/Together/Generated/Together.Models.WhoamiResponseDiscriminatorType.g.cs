
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum WhoamiResponseDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        OrgApiKey,
        /// <summary>
        ///
        /// </summary>
        ProjectApiKey,
        /// <summary>
        ///
        /// </summary>
        UserJwt,
        /// <summary>
        ///
        /// </summary>
        UserOrgJwt,
        /// <summary>
        ///
        /// </summary>
        UserOrgProjectJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhoamiResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhoamiResponseDiscriminatorType value)
        {
            return value switch
            {
                WhoamiResponseDiscriminatorType.OrgApiKey => "org_api_key",
                WhoamiResponseDiscriminatorType.ProjectApiKey => "project_api_key",
                WhoamiResponseDiscriminatorType.UserJwt => "user_jwt",
                WhoamiResponseDiscriminatorType.UserOrgJwt => "user_org_jwt",
                WhoamiResponseDiscriminatorType.UserOrgProjectJwt => "user_org_project_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhoamiResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "org_api_key" => WhoamiResponseDiscriminatorType.OrgApiKey,
                "project_api_key" => WhoamiResponseDiscriminatorType.ProjectApiKey,
                "user_jwt" => WhoamiResponseDiscriminatorType.UserJwt,
                "user_org_jwt" => WhoamiResponseDiscriminatorType.UserOrgJwt,
                "user_org_project_jwt" => WhoamiResponseDiscriminatorType.UserOrgProjectJwt,
                _ => null,
            };
        }
    }
}