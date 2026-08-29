
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhoamiResponse
    {
        /// <summary>
        /// The ID of the API key that authenticated the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// The ID of the project the API key is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Human-readable name of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// DNS-friendly project identifier. Used with an endpoint slug as `&lt;project_slug&gt;/&lt;endpoint_slug&gt;` to form the `model` value in dedicated endpoint inference calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectSlug { get; set; }

        /// <summary>
        /// The ID of the organization that owns the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Human-readable name of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationName { get; set; }

        /// <summary>
        /// The ID of the authenticated user, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiResponse" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key that authenticated the request.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project the API key is scoped to.
        /// </param>
        /// <param name="projectName">
        /// Human-readable name of the project.
        /// </param>
        /// <param name="projectSlug">
        /// DNS-friendly project identifier. Used with an endpoint slug as `&lt;project_slug&gt;/&lt;endpoint_slug&gt;` to form the `model` value in dedicated endpoint inference calls.
        /// </param>
        /// <param name="organizationId">
        /// The ID of the organization that owns the project.
        /// </param>
        /// <param name="organizationName">
        /// Human-readable name of the organization.
        /// </param>
        /// <param name="userId">
        /// The ID of the authenticated user, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhoamiResponse(
            string apiKeyId,
            string projectId,
            string projectName,
            string projectSlug,
            string organizationId,
            string organizationName,
            string? userId)
        {
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ProjectSlug = projectSlug ?? throw new global::System.ArgumentNullException(nameof(projectSlug));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.OrganizationName = organizationName ?? throw new global::System.ArgumentNullException(nameof(organizationName));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiResponse" /> class.
        /// </summary>
        public WhoamiResponse()
        {
        }

    }
}