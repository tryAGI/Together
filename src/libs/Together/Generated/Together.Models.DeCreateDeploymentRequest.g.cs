
#nullable enable

namespace Together
{
    /// <summary>
    /// Configuration for creating a deployment that binds a model and immutable config to an endpoint.
    /// </summary>
    public sealed partial class DeCreateDeploymentRequest
    {
        /// <summary>
        /// Name for the deployment within its endpoint. Returned as a fully-qualified endpoint string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Deprecated. Use `model`. Model identifier to serve, accepted when `model` is unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Deprecated. Use `model` with a /revisions/{revisionId} segment. If omitted, the latest revision is resolved at creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelRevisionId")]
        public string? ModelRevisionId { get; set; }

        /// <summary>
        /// Deprecated. Use `config`. Config revision identifier to deploy, accepted when `config` is unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Model resource name in the form `projects/{projectId}/models/{modelId}[/revisions/{revisionId}]`. Omit the revision segment to pin the latest revision at creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Autoscaling configuration for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeAutoscaling Autoscaling { get; set; }

        /// <summary>
        /// Immutable config revision in the form `projects/{projectId}/configs/{configRevisionId}`. The config must be compatible with the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public string? Config { get; set; }

        /// <summary>
        /// Enables dynamic loading of LoRA adapters on the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableLora")]
        public bool? EnableLora { get; set; }

        /// <summary>
        /// Placement policy to use when scheduling the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DePlacementJsonConverter))]
        public global::Together.DePlacement? Placement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the deployment within its endpoint. Returned as a fully-qualified endpoint string.
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration for the deployment.
        /// </param>
        /// <param name="modelId">
        /// Deprecated. Use `model`. Model identifier to serve, accepted when `model` is unset.
        /// </param>
        /// <param name="modelRevisionId">
        /// Deprecated. Use `model` with a /revisions/{revisionId} segment. If omitted, the latest revision is resolved at creation.
        /// </param>
        /// <param name="configId">
        /// Deprecated. Use `config`. Config revision identifier to deploy, accepted when `config` is unset.
        /// </param>
        /// <param name="model">
        /// Model resource name in the form `projects/{projectId}/models/{modelId}[/revisions/{revisionId}]`. Omit the revision segment to pin the latest revision at creation time.
        /// </param>
        /// <param name="config">
        /// Immutable config revision in the form `projects/{projectId}/configs/{configRevisionId}`. The config must be compatible with the model.
        /// </param>
        /// <param name="enableLora">
        /// Enables dynamic loading of LoRA adapters on the deployment.
        /// </param>
        /// <param name="placement">
        /// Placement policy to use when scheduling the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateDeploymentRequest(
            string name,
            global::Together.DeAutoscaling autoscaling,
            string? modelId,
            string? modelRevisionId,
            string? configId,
            string? model,
            string? config,
            bool? enableLora,
            global::Together.DePlacement? placement)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ModelId = modelId;
            this.ModelRevisionId = modelRevisionId;
            this.ConfigId = configId;
            this.Model = model;
            this.Autoscaling = autoscaling ?? throw new global::System.ArgumentNullException(nameof(autoscaling));
            this.Config = config;
            this.EnableLora = enableLora;
            this.Placement = placement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateDeploymentRequest" /> class.
        /// </summary>
        public DeCreateDeploymentRequest()
        {
        }

    }
}