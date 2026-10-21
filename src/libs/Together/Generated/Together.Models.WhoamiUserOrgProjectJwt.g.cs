
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhoamiUserOrgProjectJwt
    {
        /// <summary>
        /// Always `user_org_project_jwt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.WhoamiUserOrgProjectJwtTypeJsonConverter))]
        public global::Together.WhoamiUserOrgProjectJwtType Type { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.WhoamiProject Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiUserOrgProjectJwt" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="organization"></param>
        /// <param name="project"></param>
        /// <param name="type">
        /// Always `user_org_project_jwt`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhoamiUserOrgProjectJwt(
            global::Together.WhoamiUser user,
            global::Together.WhoamiOrganization organization,
            global::Together.WhoamiProject project,
            global::Together.WhoamiUserOrgProjectJwtType type)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiUserOrgProjectJwt" /> class.
        /// </summary>
        public WhoamiUserOrgProjectJwt()
        {
        }

    }
}