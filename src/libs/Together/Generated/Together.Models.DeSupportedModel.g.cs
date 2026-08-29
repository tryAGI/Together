
#nullable enable

namespace Together
{
    /// <summary>
    /// Curated catalog entry for a platform-supported model.
    /// </summary>
    public sealed partial class DeSupportedModel
    {
        /// <summary>
        /// Unique ID of the deployable Together-hosted base model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Catalog-controlled HF model ID used for inference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Catalog-controlled human-readable model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Human-readable model description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Input modalities supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputModalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeSupportedModelInputModalitie> InputModalities { get; set; }

        /// <summary>
        /// Output modalities produced by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputModalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeSupportedModelOutputModalitie> OutputModalities { get; set; }

        /// <summary>
        /// Product surfaces where the model is offered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeSupportedModelProduct> Products { get; set; }

        /// <summary>
        /// Advanced features exposed by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.IList<global::Together.DeSupportedModelFeature>? Features { get; set; }

        /// <summary>
        /// High-level tasks the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeSupportedModelCapabilitie> Capabilities { get; set; }

        /// <summary>
        /// Model architecture from the underlying weights metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        /// Maximum context length from the underlying weights metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextLength")]
        public string? ContextLength { get; set; }

        /// <summary>
        /// Organization or publisher associated with the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publisher")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Publisher { get; set; }

        /// <summary>
        /// Catalog recommendation status for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeSupportedModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeSupportedModelStatus Status { get; set; }

        /// <summary>
        /// Searchable catalog tags for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Preferred input format for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputFormat")]
        public string? InputFormat { get; set; }

        /// <summary>
        /// Preferred output format for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Serverless endpoint name for inference, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessEndpoint")]
        public string? ServerlessEndpoint { get; set; }

        /// <summary>
        /// Model family identifier for related catalog entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("familyId")]
        public string? FamilyId { get; set; }

        /// <summary>
        /// UI-facing model type badge, such as chat, language, code, image, embedding, rerank, moderation, audio, video, or transcribe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayType { get; set; }

        /// <summary>
        /// Bare model ID for the architecture's base model; empty when no base model is linked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModelId { get; set; }

        /// <summary>
        /// Resource name for the base model as `projects/{projectId}/models/{modelId}`; empty when unresolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Certified deployment profiles available for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentProfiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeSupportedModelDeploymentProfile> DeploymentProfiles { get; set; }

        /// <summary>
        /// Timestamp when the catalog entry was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the catalog entry was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the deployable Together-hosted base model.
        /// </param>
        /// <param name="name">
        /// Catalog-controlled HF model ID used for inference.
        /// </param>
        /// <param name="displayName">
        /// Catalog-controlled human-readable model name.
        /// </param>
        /// <param name="inputModalities">
        /// Input modalities supported by the model.
        /// </param>
        /// <param name="outputModalities">
        /// Output modalities produced by the model.
        /// </param>
        /// <param name="products">
        /// Product surfaces where the model is offered.
        /// </param>
        /// <param name="capabilities">
        /// High-level tasks the model supports.
        /// </param>
        /// <param name="publisher">
        /// Organization or publisher associated with the model.
        /// </param>
        /// <param name="status">
        /// Catalog recommendation status for the model.
        /// </param>
        /// <param name="displayType">
        /// UI-facing model type badge, such as chat, language, code, image, embedding, rerank, moderation, audio, video, or transcribe.
        /// </param>
        /// <param name="baseModelId">
        /// Bare model ID for the architecture's base model; empty when no base model is linked.
        /// </param>
        /// <param name="baseModel">
        /// Resource name for the base model as `projects/{projectId}/models/{modelId}`; empty when unresolved.
        /// </param>
        /// <param name="deploymentProfiles">
        /// Certified deployment profiles available for the model.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the catalog entry was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the catalog entry was last updated.
        /// </param>
        /// <param name="description">
        /// Human-readable model description.
        /// </param>
        /// <param name="features">
        /// Advanced features exposed by the model.
        /// </param>
        /// <param name="architecture">
        /// Model architecture from the underlying weights metadata.
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length from the underlying weights metadata.
        /// </param>
        /// <param name="tags">
        /// Searchable catalog tags for the model.
        /// </param>
        /// <param name="inputFormat">
        /// Preferred input format for the model.
        /// </param>
        /// <param name="outputFormat">
        /// Preferred output format for the model.
        /// </param>
        /// <param name="serverlessEndpoint">
        /// Serverless endpoint name for inference, if available.
        /// </param>
        /// <param name="familyId">
        /// Model family identifier for related catalog entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeSupportedModel(
            string id,
            string name,
            string displayName,
            global::System.Collections.Generic.IList<global::Together.DeSupportedModelInputModalitie> inputModalities,
            global::System.Collections.Generic.IList<global::Together.DeSupportedModelOutputModalitie> outputModalities,
            global::System.Collections.Generic.IList<global::Together.DeSupportedModelProduct> products,
            global::System.Collections.Generic.IList<global::Together.DeSupportedModelCapabilitie> capabilities,
            string publisher,
            global::Together.DeSupportedModelStatus status,
            string displayType,
            string baseModelId,
            string baseModel,
            global::System.Collections.Generic.IList<global::Together.DeSupportedModelDeploymentProfile> deploymentProfiles,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            global::System.Collections.Generic.IList<global::Together.DeSupportedModelFeature>? features,
            string? architecture,
            string? contextLength,
            global::System.Collections.Generic.IList<string>? tags,
            string? inputFormat,
            string? outputFormat,
            string? serverlessEndpoint,
            string? familyId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Products = products ?? throw new global::System.ArgumentNullException(nameof(products));
            this.Features = features;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Architecture = architecture;
            this.ContextLength = contextLength;
            this.Publisher = publisher ?? throw new global::System.ArgumentNullException(nameof(publisher));
            this.Status = status;
            this.Tags = tags;
            this.InputFormat = inputFormat;
            this.OutputFormat = outputFormat;
            this.ServerlessEndpoint = serverlessEndpoint;
            this.FamilyId = familyId;
            this.DisplayType = displayType ?? throw new global::System.ArgumentNullException(nameof(displayType));
            this.BaseModelId = baseModelId ?? throw new global::System.ArgumentNullException(nameof(baseModelId));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.DeploymentProfiles = deploymentProfiles ?? throw new global::System.ArgumentNullException(nameof(deploymentProfiles));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModel" /> class.
        /// </summary>
        public DeSupportedModel()
        {
        }

    }
}