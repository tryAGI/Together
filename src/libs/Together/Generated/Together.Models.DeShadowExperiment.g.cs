
#nullable enable

namespace Together
{
    /// <summary>
    /// Experiment that mirrors sampled endpoint requests to target deployments without changing client responses.
    /// </summary>
    public sealed partial class DeShadowExperiment
    {
        /// <summary>
        /// Output only. Unique shadow experiment identifier.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Output only. Project that owns the parent endpoint.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Output only. Endpoint whose traffic this experiment samples.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Human-readable shadow experiment name, unique within the endpoint. At most 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// User defined description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Endpoint source and sampling configuration for mirrored requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentSourceResponse Source { get; set; }

        /// <summary>
        /// Target deployments that receive mirrored traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeShadowExperimentTarget> Targets { get; set; }

        /// <summary>
        /// Identifier of the principal that created the experiment.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// Timestamp when the experiment was created.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the experiment was last updated.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Opaque version tag for optimistic concurrency control. Returned on read; set it on update or delete requests for consistent read-modify-write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Derived serving state, active when the experiment has at least one target.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeShadowExperimentStateJsonConverter))]
        public global::Together.DeShadowExperimentState State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperiment" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable shadow experiment name, unique within the endpoint. At most 256 characters.
        /// </param>
        /// <param name="source">
        /// Endpoint source and sampling configuration for mirrored requests.
        /// </param>
        /// <param name="targets">
        /// Target deployments that receive mirrored traffic.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag for optimistic concurrency control. Returned on read; set it on update or delete requests for consistent read-modify-write.
        /// </param>
        /// <param name="description">
        /// User defined description.
        /// </param>
        /// <param name="id">
        /// Output only. Unique shadow experiment identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Output only. Project that owns the parent endpoint.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endpointId">
        /// Output only. Endpoint whose traffic this experiment samples.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Identifier of the principal that created the experiment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the experiment was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the experiment was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Derived serving state, active when the experiment has at least one target.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperiment(
            string name,
            global::Together.DeShadowExperimentSourceResponse source,
            global::System.Collections.Generic.IList<global::Together.DeShadowExperimentTarget> targets,
            string etag,
            string? description,
            string id = default!,
            string projectId = default!,
            string endpointId = default!,
            string createdBy = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!,
            global::Together.DeShadowExperimentState state = default!)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.EndpointId = endpointId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperiment" /> class.
        /// </summary>
        public DeShadowExperiment()
        {
        }

    }
}