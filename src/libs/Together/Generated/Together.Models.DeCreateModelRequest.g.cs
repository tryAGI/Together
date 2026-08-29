
#nullable enable

namespace Together
{
    /// <summary>
    /// Request for registering a custom model or adapter in a project.
    /// </summary>
    public sealed partial class DeCreateModelRequest
    {
        /// <summary>
        /// Name for the custom model. May be bare or qualified as `&lt;project_slug&gt;/&lt;model_name&gt;`; a supplied project slug must match the project in the request path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Volume type to create. Use `model` or `adapter`; plural `models` and `adapters` are also accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Human-readable description of the model and its intended use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// ID of the supported base model from which this model was derived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateModelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the custom model. May be bare or qualified as `&lt;project_slug&gt;/&lt;model_name&gt;`; a supplied project slug must match the project in the request path.
        /// </param>
        /// <param name="type">
        /// Volume type to create. Use `model` or `adapter`; plural `models` and `adapters` are also accepted.
        /// </param>
        /// <param name="baseModelId">
        /// ID of the supported base model from which this model was derived.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the model and its intended use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateModelRequest(
            string name,
            string type,
            string baseModelId,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description;
            this.BaseModelId = baseModelId ?? throw new global::System.ArgumentNullException(nameof(baseModelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateModelRequest" /> class.
        /// </summary>
        public DeCreateModelRequest()
        {
        }

    }
}