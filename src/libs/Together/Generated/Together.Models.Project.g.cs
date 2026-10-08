
#nullable enable

namespace Together
{
    /// <summary>
    /// A project the authenticated caller can access.
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// Unique project identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Customer-facing project slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// ID of the organization that owns the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Display name of the organization that owns the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique project identifier.
        /// </param>
        /// <param name="name">
        /// Display name of the project.
        /// </param>
        /// <param name="slug">
        /// Customer-facing project slug.
        /// </param>
        /// <param name="organizationId">
        /// ID of the organization that owns the project.
        /// </param>
        /// <param name="organizationName">
        /// Display name of the organization that owns the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Project(
            string id,
            string name,
            string slug,
            string organizationId,
            string organizationName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.OrganizationName = organizationName ?? throw new global::System.ArgumentNullException(nameof(organizationName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }

    }
}