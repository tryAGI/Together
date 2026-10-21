
#nullable enable

namespace Together
{
    /// <summary>
    /// Always `project_api_key`.
    /// </summary>
    public enum WhoamiProjectApiKeyType
    {
        /// <summary>
        ///
        /// </summary>
        ProjectApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhoamiProjectApiKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhoamiProjectApiKeyType value)
        {
            return value switch
            {
                WhoamiProjectApiKeyType.ProjectApiKey => "project_api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhoamiProjectApiKeyType? ToEnum(string value)
        {
            return value switch
            {
                "project_api_key" => WhoamiProjectApiKeyType.ProjectApiKey,
                _ => null,
            };
        }
    }
}