
#nullable enable

namespace Together
{
    /// <summary>
    /// Managed cohort split that subdivides a control deployment's live traffic among the control and one or more variants.
    /// </summary>
    public sealed partial class DeABExperiment
    {
        /// <summary>
        /// Output only. Unique A/B experiment identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Output only. Project that owns the parent endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Output only. Endpoint this A/B experiment belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Human-readable A/B experiment name, unique within the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional free-form description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Two to 20 participating deployments with exactly one control and percentages that add up to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeABExperimentMember> Members { get; set; }

        /// <summary>
        /// Output only. Identifier of the principal that created the A/B experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Output only. Timestamp when the A/B experiment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Output only. Timestamp when the A/B experiment was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Optional opaque version tag for optimistic concurrency control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeABExperiment" /> class.
        /// </summary>
        /// <param name="id">
        /// Output only. Unique A/B experiment identifier.
        /// </param>
        /// <param name="projectId">
        /// Output only. Project that owns the parent endpoint.
        /// </param>
        /// <param name="endpointId">
        /// Output only. Endpoint this A/B experiment belongs to.
        /// </param>
        /// <param name="name">
        /// Human-readable A/B experiment name, unique within the endpoint.
        /// </param>
        /// <param name="members">
        /// Two to 20 participating deployments with exactly one control and percentages that add up to 100.
        /// </param>
        /// <param name="createdBy">
        /// Output only. Identifier of the principal that created the A/B experiment.
        /// </param>
        /// <param name="createdAt">
        /// Output only. Timestamp when the A/B experiment was created.
        /// </param>
        /// <param name="updatedAt">
        /// Output only. Timestamp when the A/B experiment was last updated.
        /// </param>
        /// <param name="etag">
        /// Optional opaque version tag for optimistic concurrency control.
        /// </param>
        /// <param name="description">
        /// Optional free-form description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeABExperiment(
            string id,
            string projectId,
            string endpointId,
            string name,
            global::System.Collections.Generic.IList<global::Together.DeABExperimentMember> members,
            string createdBy,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string etag,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeABExperiment" /> class.
        /// </summary>
        public DeABExperiment()
        {
        }

    }
}