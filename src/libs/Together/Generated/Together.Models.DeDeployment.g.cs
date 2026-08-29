
#nullable enable

namespace Together
{
    /// <summary>
    /// Serving workload that binds a model and immutable config to an endpoint and manages its replicas.
    /// </summary>
    public sealed partial class DeDeployment
    {
        /// <summary>
        /// Unique deployment identifier.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// ID of the project that owns the deployment.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// ID of the endpoint that contains the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Project- and endpoint-qualified deployment name in the form `&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;`. Pass it as `model` in an inference request to target this deployment directly instead of using the endpoint's traffic split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Timestamp when the deployment was created.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the deployment was last updated.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Deprecated. Use `model`. Model identifier being served, populated during migration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Deprecated. Use `model` with a /revisions/{revisionId} segment. Pin to a specific model revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelRevisionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelRevisionId { get; set; }

        /// <summary>
        /// Pinned model resource in the form `projects/{projectId}/models/{modelId}/revisions/{revisionId}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Replica bounds, timing windows, and metrics that control horizontal scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeAutoscalingResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeAutoscalingResponse Autoscaling { get; set; }

        /// <summary>
        /// Deprecated. Use `config`. Config revision identifier, populated during migration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigId { get; set; }

        /// <summary>
        /// Immutable config revision in the form `projects/{projectId}/configs/{configRevisionId}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Config { get; set; }

        /// <summary>
        /// Deprecated. Use `speculator`. Speculative decoding model identifier derived from the deployment config.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculatorId")]
        public string? SpeculatorId { get; set; }

        /// <summary>
        /// Deprecated. Use `speculator`. ID of the speculative decoding draft-model revision pinned at creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculatorRevisionId")]
        public string? SpeculatorRevisionId { get; set; }

        /// <summary>
        /// Pinned draft-model resource used for speculative decoding, in the same form as `model`. Omitted when speculative decoding is disabled.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculator")]
        public string? Speculator { get; set; }

        /// <summary>
        /// Estimated fraction in [0, 1] of endpoint traffic that reaches this deployment under the current routing configuration. Absent or unrouted deployments are 0.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedEffectiveTrafficShare")]
        public double? EstimatedEffectiveTrafficShare { get; set; }

        /// <summary>
        /// Whether the deployment can dynamically load LoRA adapters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableLora")]
        public bool? EnableLora { get; set; }

        /// <summary>
        /// Opaque version tag for optimistic concurrency control. Supply on update/delete to ensure consistent read-modify-write. If not set, the write overwrites based on current state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Hardware selected by the deployment config, including GPU type and count.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        public string Hardware { get; set; } = default!;

        /// <summary>
        /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("trafficMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeDeploymentTrafficModeJsonConverter))]
        public global::Together.DeDeploymentTrafficMode TrafficMode { get; set; } = default!;

        /// <summary>
        /// Serving engine and feature support derived from the immutable config.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtimeInfo")]
        public global::Together.DeRuntimeInfo? RuntimeInfo { get; set; }

        /// <summary>
        /// Number of replicas the autoscaler currently wants across all regions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desiredReplicas")]
        public int? DesiredReplicas { get; set; }

        /// <summary>
        /// Current lifecycle state and observed replica counts.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Together.DeDeploymentStatus Status { get; set; } = default!;

        /// <summary>
        /// Region constraints used to schedule the deployment's replicas.
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
        /// Initializes a new instance of the <see cref="DeDeployment" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// ID of the endpoint that contains the deployment.
        /// </param>
        /// <param name="name">
        /// Project- and endpoint-qualified deployment name in the form `&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;`. Pass it as `model` in an inference request to target this deployment directly instead of using the endpoint's traffic split.
        /// </param>
        /// <param name="modelId">
        /// Deprecated. Use `model`. Model identifier being served, populated during migration.
        /// </param>
        /// <param name="modelRevisionId">
        /// Deprecated. Use `model` with a /revisions/{revisionId} segment. Pin to a specific model revision.
        /// </param>
        /// <param name="model">
        /// Pinned model resource in the form `projects/{projectId}/models/{modelId}/revisions/{revisionId}`.
        /// </param>
        /// <param name="autoscaling">
        /// Replica bounds, timing windows, and metrics that control horizontal scaling.
        /// </param>
        /// <param name="configId">
        /// Deprecated. Use `config`. Config revision identifier, populated during migration.
        /// </param>
        /// <param name="config">
        /// Immutable config revision in the form `projects/{projectId}/configs/{configRevisionId}`.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag for optimistic concurrency control. Supply on update/delete to ensure consistent read-modify-write. If not set, the write overwrites based on current state.
        /// </param>
        /// <param name="speculatorId">
        /// Deprecated. Use `speculator`. Speculative decoding model identifier derived from the deployment config.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="speculatorRevisionId">
        /// Deprecated. Use `speculator`. ID of the speculative decoding draft-model revision pinned at creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="speculator">
        /// Pinned draft-model resource used for speculative decoding, in the same form as `model`. Omitted when speculative decoding is disabled.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="estimatedEffectiveTrafficShare">
        /// Estimated fraction in [0, 1] of endpoint traffic that reaches this deployment under the current routing configuration. Absent or unrouted deployments are 0.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="enableLora">
        /// Whether the deployment can dynamically load LoRA adapters.
        /// </param>
        /// <param name="runtimeInfo">
        /// Serving engine and feature support derived from the immutable config.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="desiredReplicas">
        /// Number of replicas the autoscaler currently wants across all regions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="placement">
        /// Region constraints used to schedule the deployment's replicas.
        /// </param>
        /// <param name="id">
        /// Unique deployment identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// ID of the project that owns the deployment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the deployment was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the deployment was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="hardware">
        /// Hardware selected by the deployment config, including GPU type and count.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="trafficMode">
        /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Current lifecycle state and observed replica counts.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeDeployment(
            string endpointId,
            string name,
            string modelId,
            string modelRevisionId,
            string model,
            global::Together.DeAutoscalingResponse autoscaling,
            string configId,
            string config,
            string etag,
            string? speculatorId,
            string? speculatorRevisionId,
            string? speculator,
            double? estimatedEffectiveTrafficShare,
            bool? enableLora,
            global::Together.DeRuntimeInfo? runtimeInfo,
            int? desiredReplicas,
            global::Together.DePlacement? placement,
            string id = default!,
            string projectId = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!,
            string hardware = default!,
            global::Together.DeDeploymentTrafficMode trafficMode = default!,
            global::Together.DeDeploymentStatus status = default!)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelRevisionId = modelRevisionId ?? throw new global::System.ArgumentNullException(nameof(modelRevisionId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Autoscaling = autoscaling;
            this.ConfigId = configId ?? throw new global::System.ArgumentNullException(nameof(configId));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.SpeculatorId = speculatorId;
            this.SpeculatorRevisionId = speculatorRevisionId;
            this.Speculator = speculator;
            this.EstimatedEffectiveTrafficShare = estimatedEffectiveTrafficShare;
            this.EnableLora = enableLora;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.Hardware = hardware;
            this.TrafficMode = trafficMode;
            this.RuntimeInfo = runtimeInfo;
            this.DesiredReplicas = desiredReplicas;
            this.Status = status;
            this.Placement = placement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeployment" /> class.
        /// </summary>
        public DeDeployment()
        {
        }

    }
}