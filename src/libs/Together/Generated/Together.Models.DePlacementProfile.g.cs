
#nullable enable

namespace Together
{
    /// <summary>
    /// Reusable ordered region preferences for scheduling a project's deployments.
    /// </summary>
    public sealed partial class DePlacementProfile
    {
        /// <summary>
        /// Unique placement profile identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project that owns the placement profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Organization that owns the placement profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Human-readable placement profile name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Preferred deployment regions in descending priority order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferredRegions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PreferredRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePlacementProfile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique placement profile identifier.
        /// </param>
        /// <param name="projectId">
        /// Project that owns the placement profile.
        /// </param>
        /// <param name="organizationId">
        /// Organization that owns the placement profile.
        /// </param>
        /// <param name="name">
        /// Human-readable placement profile name.
        /// </param>
        /// <param name="preferredRegions">
        /// Preferred deployment regions in descending priority order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePlacementProfile(
            string id,
            string projectId,
            string organizationId,
            string name,
            global::System.Collections.Generic.IList<string> preferredRegions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PreferredRegions = preferredRegions ?? throw new global::System.ArgumentNullException(nameof(preferredRegions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePlacementProfile" /> class.
        /// </summary>
        public DePlacementProfile()
        {
        }

    }
}