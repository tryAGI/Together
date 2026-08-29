
#nullable enable

namespace Together
{
    /// <summary>
    /// Endpoint metadata exposed through the public endpoint catalog.
    /// </summary>
    public sealed partial class DePublicEndpoint
    {
        /// <summary>
        /// Unique endpoint identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the project that owns the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Endpoint string in the form `&lt;project_slug&gt;/&lt;endpoint_name&gt;`, passed as the `model` parameter when calling inference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Timestamp when the endpoint was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the endpoint was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Public visibility of the endpoint.
        /// </summary>
        /// <default>"VISIBILITY_PUBLIC"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string Visibility { get; set; } = "VISIBILITY_PUBLIC";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePublicEndpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique endpoint identifier.
        /// </param>
        /// <param name="projectId">
        /// ID of the project that owns the endpoint.
        /// </param>
        /// <param name="name">
        /// Endpoint string in the form `&lt;project_slug&gt;/&lt;endpoint_name&gt;`, passed as the `model` parameter when calling inference.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the endpoint was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the endpoint was last updated.
        /// </param>
        /// <param name="visibility">
        /// Public visibility of the endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePublicEndpoint(
            string id,
            string projectId,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string visibility = "VISIBILITY_PUBLIC")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePublicEndpoint" /> class.
        /// </summary>
        public DePublicEndpoint()
        {
        }

    }
}