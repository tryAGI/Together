
#nullable enable

namespace Together
{
    /// <summary>
    /// Always `org_api_key`.
    /// </summary>
    public enum WhoamiOrgApiKeyType
    {
        /// <summary>
        ///
        /// </summary>
        OrgApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhoamiOrgApiKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhoamiOrgApiKeyType value)
        {
            return value switch
            {
                WhoamiOrgApiKeyType.OrgApiKey => "org_api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhoamiOrgApiKeyType? ToEnum(string value)
        {
            return value switch
            {
                "org_api_key" => WhoamiOrgApiKeyType.OrgApiKey,
                _ => null,
            };
        }
    }
}