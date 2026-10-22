
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhoamiOrgApiKey
    {
        /// <summary>
        /// Always `org_api_key`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.WhoamiOrgApiKeyTypeJsonConverter))]
        public global::Together.WhoamiOrgApiKeyType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.WhoamiApiKey ApiKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.WhoamiOrganization Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiOrgApiKey" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="organization"></param>
        /// <param name="type">
        /// Always `org_api_key`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhoamiOrgApiKey(
            global::Together.WhoamiApiKey apiKey,
            global::Together.WhoamiOrganization organization,
            global::Together.WhoamiOrgApiKeyType type)
        {
            this.Type = type;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiOrgApiKey" /> class.
        /// </summary>
        public WhoamiOrgApiKey()
        {
        }

    }
}