
#nullable enable

namespace Together
{
    /// <summary>
    /// Custom or derived model registered in a project and backed by versioned weight files.
    /// </summary>
    public sealed partial class DeModel
    {
        /// <summary>
        /// Unique model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the project that owns the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// ID of the organization that owns the model's project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Project-qualified model name in the form `&lt;project_slug&gt;/&lt;model_name&gt;`. Create and update requests may use the bare or qualified form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable description of the model and its intended use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Architecture, size, precision, and speculative-decoding metadata derived from the model files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeModelWeights Weights { get; set; }

        /// <summary>
        /// ID of the supported or custom base model from which this model was derived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModelId")]
        public string? BaseModelId { get; set; }

        /// <summary>
        /// Resource name of the base model, using `projects/{baseProject}/models/{baseModelId}`; empty when the model has no base.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Who can discover the model. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </summary>
        /// <default>global::Together.DeModelVisibility.VisibilityPrivate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeModelVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeModelVisibility Visibility { get; set; } = global::Together.DeModelVisibility.VisibilityPrivate;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique model identifier.
        /// </param>
        /// <param name="projectId">
        /// ID of the project that owns the model.
        /// </param>
        /// <param name="organizationId">
        /// ID of the organization that owns the model's project.
        /// </param>
        /// <param name="name">
        /// Project-qualified model name in the form `&lt;project_slug&gt;/&lt;model_name&gt;`. Create and update requests may use the bare or qualified form.
        /// </param>
        /// <param name="weights">
        /// Architecture, size, precision, and speculative-decoding metadata derived from the model files.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the model. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
        /// <param name="description">
        /// Human-readable description of the model and its intended use.
        /// </param>
        /// <param name="baseModelId">
        /// ID of the supported or custom base model from which this model was derived.
        /// </param>
        /// <param name="baseModel">
        /// Resource name of the base model, using `projects/{baseProject}/models/{baseModelId}`; empty when the model has no base.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeModel(
            string id,
            string projectId,
            string organizationId,
            string name,
            global::Together.DeModelWeights weights,
            global::Together.DeModelVisibility visibility,
            string? description,
            string? baseModelId,
            string? baseModel)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Weights = weights ?? throw new global::System.ArgumentNullException(nameof(weights));
            this.BaseModelId = baseModelId;
            this.BaseModel = baseModel;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModel" /> class.
        /// </summary>
        public DeModel()
        {
        }

    }
}