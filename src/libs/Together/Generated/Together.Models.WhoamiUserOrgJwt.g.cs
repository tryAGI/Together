
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhoamiUserOrgJwt
    {
        /// <summary>
        /// Always `user_org_jwt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.WhoamiUserOrgJwtTypeJsonConverter))]
        public global::Together.WhoamiUserOrgJwtType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.WhoamiUser User { get; set; }

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
        /// Initializes a new instance of the <see cref="WhoamiUserOrgJwt" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="organization"></param>
        /// <param name="type">
        /// Always `user_org_jwt`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhoamiUserOrgJwt(
            global::Together.WhoamiUser user,
            global::Together.WhoamiOrganization organization,
            global::Together.WhoamiUserOrgJwtType type)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiUserOrgJwt" /> class.
        /// </summary>
        public WhoamiUserOrgJwt()
        {
        }

    }
}