
#nullable enable

namespace Together
{
    /// <summary>
    /// One endpoint- or deployment-scoped entry in an endpoint's combined audit and lifecycle feed.
    /// </summary>
    public sealed partial class DeEndpointEvent
    {
        /// <summary>
        /// Output only. Unique event identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Output only. Event creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Output only. Severity level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeEndpointEventLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeEndpointEventLevel Level { get; set; }

        /// <summary>
        /// Output only. Stable event type, such as `endpoint.updated`, `deployment.created`, `deployment.scaled`, `condition.set`, or `pod.log`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Output only. Human-readable description of the event. Short and stable; not structured data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Output only. Service, cluster, or controller that emitted the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Output only. Whether this row describes the endpoint or one of its deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeEndpointEventSourceKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeEndpointEventSourceKind SourceKind { get; set; }

        /// <summary>
        /// Output only. The endpoint this event belongs to. Always set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Output only. Deployment associated with the event when `sourceKind` is `SOURCE_KIND_DEPLOYMENT`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// Output only. ID of the event's subject, such as a rollout, shadow target, or condition type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjectId")]
        public string? SubjectId { get; set; }

        /// <summary>
        /// Resource name at the time of the event. Populated by: deployment.created, deployment.deleted, endpoint.created, endpoint.deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Field-mask paths that were modified. Populated by: deployment.updated, endpoint.updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        public global::System.Collections.Generic.IList<string>? Paths { get; set; }

        /// <summary>
        /// Replica-count transition. Populated by: deployment.scaled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldReplicas")]
        public int? OldReplicas { get; set; }

        /// <summary>
        /// New replica count for a `deployment.scaled` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newReplicas")]
        public int? NewReplicas { get; set; }

        /// <summary>
        /// Target version. Populated by `target.created`; the target ID is carried in `subjectId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Condition status for `condition.set` and `cluster_condition.set`: `True`, `False`, or `Unknown`. The condition type is carried in `subjectId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Stable condition reason, such as `AllReplicasReady`, `ReplicasProgressing`, or `ApplySuccessful`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// ID of the cluster associated with a cluster-scoped event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterId")]
        public string? ClusterId { get; set; }

        /// <summary>
        /// Deployment subservice associated with the event, such as `model-deployment` or `speculator-deployment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceType")]
        public string? ServiceType { get; set; }

        /// <summary>
        /// Opaque replica identity associated with a `pod.*` event, stable for grouping events from the same replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaId")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// Stable public component label associated with a replica event, such as `engine`, `model-download`, or `sidecar`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerName")]
        public string? ContainerName { get; set; }

        /// <summary>
        /// Short diagnostic log excerpt captured with a pod event, for example during a crash, out-of-memory termination, or image pull failure. This field is truncated and is not a streaming log API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logExcerpt")]
        public string? LogExcerpt { get; set; }

        /// <summary>
        /// Opaque node handle for correlating replica failures on the same node. Omitted when the replica is unscheduled or the node is unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpointEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Output only. Unique event identifier.
        /// </param>
        /// <param name="createdAt">
        /// Output only. Event creation time.
        /// </param>
        /// <param name="level">
        /// Output only. Severity level.
        /// </param>
        /// <param name="type">
        /// Output only. Stable event type, such as `endpoint.updated`, `deployment.created`, `deployment.scaled`, `condition.set`, or `pod.log`.
        /// </param>
        /// <param name="source">
        /// Output only. Service, cluster, or controller that emitted the event.
        /// </param>
        /// <param name="sourceKind">
        /// Output only. Whether this row describes the endpoint or one of its deployments.
        /// </param>
        /// <param name="endpointId">
        /// Output only. The endpoint this event belongs to. Always set.
        /// </param>
        /// <param name="message">
        /// Output only. Human-readable description of the event. Short and stable; not structured data.
        /// </param>
        /// <param name="deploymentId">
        /// Output only. Deployment associated with the event when `sourceKind` is `SOURCE_KIND_DEPLOYMENT`.
        /// </param>
        /// <param name="subjectId">
        /// Output only. ID of the event's subject, such as a rollout, shadow target, or condition type.
        /// </param>
        /// <param name="name">
        /// Resource name at the time of the event. Populated by: deployment.created, deployment.deleted, endpoint.created, endpoint.deleted
        /// </param>
        /// <param name="paths">
        /// Field-mask paths that were modified. Populated by: deployment.updated, endpoint.updated
        /// </param>
        /// <param name="oldReplicas">
        /// Replica-count transition. Populated by: deployment.scaled
        /// </param>
        /// <param name="newReplicas">
        /// New replica count for a `deployment.scaled` event.
        /// </param>
        /// <param name="version">
        /// Target version. Populated by `target.created`; the target ID is carried in `subjectId`.
        /// </param>
        /// <param name="status">
        /// Condition status for `condition.set` and `cluster_condition.set`: `True`, `False`, or `Unknown`. The condition type is carried in `subjectId`.
        /// </param>
        /// <param name="reason">
        /// Stable condition reason, such as `AllReplicasReady`, `ReplicasProgressing`, or `ApplySuccessful`.
        /// </param>
        /// <param name="clusterId">
        /// ID of the cluster associated with a cluster-scoped event.
        /// </param>
        /// <param name="serviceType">
        /// Deployment subservice associated with the event, such as `model-deployment` or `speculator-deployment`.
        /// </param>
        /// <param name="replicaId">
        /// Opaque replica identity associated with a `pod.*` event, stable for grouping events from the same replica.
        /// </param>
        /// <param name="containerName">
        /// Stable public component label associated with a replica event, such as `engine`, `model-download`, or `sidecar`.
        /// </param>
        /// <param name="logExcerpt">
        /// Short diagnostic log excerpt captured with a pod event, for example during a crash, out-of-memory termination, or image pull failure. This field is truncated and is not a streaming log API.
        /// </param>
        /// <param name="nodeId">
        /// Opaque node handle for correlating replica failures on the same node. Omitted when the replica is unscheduled or the node is unknown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeEndpointEvent(
            string id,
            global::System.DateTime createdAt,
            global::Together.DeEndpointEventLevel level,
            string type,
            string source,
            global::Together.DeEndpointEventSourceKind sourceKind,
            string endpointId,
            string? message,
            string? deploymentId,
            string? subjectId,
            string? name,
            global::System.Collections.Generic.IList<string>? paths,
            int? oldReplicas,
            int? newReplicas,
            int? version,
            string? status,
            string? reason,
            string? clusterId,
            string? serviceType,
            string? replicaId,
            string? containerName,
            string? logExcerpt,
            string? nodeId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Level = level;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.SourceKind = sourceKind;
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.DeploymentId = deploymentId;
            this.SubjectId = subjectId;
            this.Name = name;
            this.Paths = paths;
            this.OldReplicas = oldReplicas;
            this.NewReplicas = newReplicas;
            this.Version = version;
            this.Status = status;
            this.Reason = reason;
            this.ClusterId = clusterId;
            this.ServiceType = serviceType;
            this.ReplicaId = replicaId;
            this.ContainerName = containerName;
            this.LogExcerpt = logExcerpt;
            this.NodeId = nodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpointEvent" /> class.
        /// </summary>
        public DeEndpointEvent()
        {
        }

    }
}