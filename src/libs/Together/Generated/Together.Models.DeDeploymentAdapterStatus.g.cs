
#nullable enable

namespace Together
{
    /// <summary>
    /// Controller-reported load state for an adapter on one deployment cluster.
    /// </summary>
    public sealed partial class DeDeploymentAdapterStatus
    {
        /// <summary>
        /// Adapter model identifier for this status row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterModelId { get; set; }

        /// <summary>
        /// Cluster reporting this adapter status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterId { get; set; }

        /// <summary>
        /// Adapter revision currently loaded on pods in this cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realizedRevisionId")]
        public string? RealizedRevisionId { get; set; }

        /// <summary>
        /// Adapter row etag observed by the controller when it wrote this status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realizedEtag")]
        public string? RealizedEtag { get; set; }

        /// <summary>
        /// Current adapter load state in this cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeDeploymentAdapterStatusStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeDeploymentAdapterStatusState State { get; set; }

        /// <summary>
        /// Stable reason code for the current adapter state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Human-readable details about the current adapter state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Number of pods with the adapter ready to serve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyPodCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReadyPodCount { get; set; }

        /// <summary>
        /// Number of pods that failed to load the adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedPodCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedPodCount { get; set; }

        /// <summary>
        /// Total pods expected to report adapter load state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPodCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPodCount { get; set; }

        /// <summary>
        /// Time when the adapter first reached READY in this cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loadedAt")]
        public global::System.DateTime? LoadedAt { get; set; }

        /// <summary>
        /// Time when this adapter status was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Resource name of the adapter model, using projects/{projectId}/models/{adapterModelId}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterModel")]
        public string? AdapterModel { get; set; }

        /// <summary>
        /// Resource name of the adapter model revision currently loaded in this cluster, using projects/{projectId}/models/{adapterModelId}/revisions/{revisionId}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realizedRevision")]
        public string? RealizedRevision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentAdapterStatus" /> class.
        /// </summary>
        /// <param name="adapterModelId">
        /// Adapter model identifier for this status row.
        /// </param>
        /// <param name="clusterId">
        /// Cluster reporting this adapter status.
        /// </param>
        /// <param name="state">
        /// Current adapter load state in this cluster.
        /// </param>
        /// <param name="readyPodCount">
        /// Number of pods with the adapter ready to serve.
        /// </param>
        /// <param name="failedPodCount">
        /// Number of pods that failed to load the adapter.
        /// </param>
        /// <param name="totalPodCount">
        /// Total pods expected to report adapter load state.
        /// </param>
        /// <param name="realizedRevisionId">
        /// Adapter revision currently loaded on pods in this cluster.
        /// </param>
        /// <param name="realizedEtag">
        /// Adapter row etag observed by the controller when it wrote this status.
        /// </param>
        /// <param name="reason">
        /// Stable reason code for the current adapter state.
        /// </param>
        /// <param name="message">
        /// Human-readable details about the current adapter state.
        /// </param>
        /// <param name="loadedAt">
        /// Time when the adapter first reached READY in this cluster.
        /// </param>
        /// <param name="updatedAt">
        /// Time when this adapter status was last updated.
        /// </param>
        /// <param name="adapterModel">
        /// Resource name of the adapter model, using projects/{projectId}/models/{adapterModelId}.
        /// </param>
        /// <param name="realizedRevision">
        /// Resource name of the adapter model revision currently loaded in this cluster, using projects/{projectId}/models/{adapterModelId}/revisions/{revisionId}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeDeploymentAdapterStatus(
            string adapterModelId,
            string clusterId,
            global::Together.DeDeploymentAdapterStatusState state,
            int readyPodCount,
            int failedPodCount,
            int totalPodCount,
            string? realizedRevisionId,
            string? realizedEtag,
            string? reason,
            string? message,
            global::System.DateTime? loadedAt,
            global::System.DateTime? updatedAt,
            string? adapterModel,
            string? realizedRevision)
        {
            this.AdapterModelId = adapterModelId ?? throw new global::System.ArgumentNullException(nameof(adapterModelId));
            this.ClusterId = clusterId ?? throw new global::System.ArgumentNullException(nameof(clusterId));
            this.RealizedRevisionId = realizedRevisionId;
            this.RealizedEtag = realizedEtag;
            this.State = state;
            this.Reason = reason;
            this.Message = message;
            this.ReadyPodCount = readyPodCount;
            this.FailedPodCount = failedPodCount;
            this.TotalPodCount = totalPodCount;
            this.LoadedAt = loadedAt;
            this.UpdatedAt = updatedAt;
            this.AdapterModel = adapterModel;
            this.RealizedRevision = realizedRevision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentAdapterStatus" /> class.
        /// </summary>
        public DeDeploymentAdapterStatus()
        {
        }

    }
}