
#nullable enable

namespace Together
{
    /// <summary>
    /// Compact deployment status embedded in an endpoint response.
    /// </summary>
    public sealed partial class DeDeploymentSummary
    {
        /// <summary>
        /// Deployment identifier.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Deprecated. Use `model`. Model identifier being served.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Hardware configuration selected by the deployment's config, such as its GPU type and count.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        public string? Hardware { get; set; }

        /// <summary>
        /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trafficMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeDeploymentSummaryTrafficModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeDeploymentSummaryTrafficMode TrafficMode { get; set; }

        /// <summary>
        /// Current state of the deployment.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeDeploymentSummaryStateJsonConverter))]
        public global::Together.DeDeploymentSummaryState State { get; set; } = default!;

        /// <summary>
        /// Inference-addressable name in the fully-qualified form<br/>
        /// "&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;". Pass it as the<br/>
        /// "model" field when calling the inference API to pin to this deployment.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Timestamp when the deployment was created.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Autoscaling configuration for the deployment.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeAutoscalingResponseJsonConverter))]
        public global::Together.DeAutoscalingResponse Autoscaling { get; set; } = default!;

        /// <summary>
        /// Number of replicas the autoscaler currently wants across all regions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desiredReplicas")]
        public int? DesiredReplicas { get; set; }

        /// <summary>
        /// Number of replicas currently ready to serve requests across all regions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyReplicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Resource name of the served model in the form<br/>
        /// `projects/{projectId}/models/{modelId}/revisions/{revisionId}`.<br/>
        /// For public models, the model's owning project may differ from the deployment's project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Estimated fraction from 0 to 1 of endpoint traffic currently routed to this deployment.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedEffectiveTrafficShare")]
        public double EstimatedEffectiveTrafficShare { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentSummary" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Deprecated. Use `model`. Model identifier being served.
        /// </param>
        /// <param name="trafficMode">
        /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.
        /// </param>
        /// <param name="model">
        /// Resource name of the served model in the form<br/>
        /// `projects/{projectId}/models/{modelId}/revisions/{revisionId}`.<br/>
        /// For public models, the model's owning project may differ from the deployment's project.
        /// </param>
        /// <param name="hardware">
        /// Hardware configuration selected by the deployment's config, such as its GPU type and count.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="desiredReplicas">
        /// Number of replicas the autoscaler currently wants across all regions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="readyReplicas">
        /// Number of replicas currently ready to serve requests across all regions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Deployment identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Current state of the deployment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Inference-addressable name in the fully-qualified form<br/>
        /// "&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;". Pass it as the<br/>
        /// "model" field when calling the inference API to pin to this deployment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the deployment was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration for the deployment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="estimatedEffectiveTrafficShare">
        /// Estimated fraction from 0 to 1 of endpoint traffic currently routed to this deployment.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeDeploymentSummary(
            string modelId,
            global::Together.DeDeploymentSummaryTrafficMode trafficMode,
            string model,
            string? hardware,
            int? desiredReplicas,
            int? readyReplicas,
            string id = default!,
            global::Together.DeDeploymentSummaryState state = default!,
            string name = default!,
            global::System.DateTime createdAt = default!,
            global::Together.DeAutoscalingResponse autoscaling = default!,
            double estimatedEffectiveTrafficShare = default!)
        {
            this.Id = id;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Hardware = hardware;
            this.TrafficMode = trafficMode;
            this.State = state;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.Autoscaling = autoscaling;
            this.DesiredReplicas = desiredReplicas;
            this.ReadyReplicas = readyReplicas;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.EstimatedEffectiveTrafficShare = estimatedEffectiveTrafficShare;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentSummary" /> class.
        /// </summary>
        public DeDeploymentSummary()
        {
        }

    }
}