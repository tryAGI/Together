
#nullable enable

namespace Together
{
    /// <summary>
    /// Asynchronous job that imports remote files into a registered model and creates a model revision.
    /// </summary>
    public sealed partial class DeRemoteUpload
    {
        /// <summary>
        /// Unique ID of the remote model import job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the project that owns the import job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// ID of the registered model receiving the imported files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Hugging Face repository or presigned URL being imported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteUrl { get; set; }

        /// <summary>
        /// Current lifecycle state of the asynchronous import job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRemoteUploadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeRemoteUploadStatus Status { get; set; }

        /// <summary>
        /// Human-readable progress or failure detail for the current status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Number of times the import worker has restarted this job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartCount")]
        public int? RestartCount { get; set; }

        /// <summary>
        /// Maximum worker restarts allowed before the job fails permanently.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRestarts")]
        public int? MaxRestarts { get; set; }

        /// <summary>
        /// Time when the import job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time when the import job was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRemoteUpload" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the remote model import job.
        /// </param>
        /// <param name="projectId">
        /// ID of the project that owns the import job.
        /// </param>
        /// <param name="modelId">
        /// ID of the registered model receiving the imported files.
        /// </param>
        /// <param name="remoteUrl">
        /// Hugging Face repository or presigned URL being imported.
        /// </param>
        /// <param name="status">
        /// Current lifecycle state of the asynchronous import job.
        /// </param>
        /// <param name="createdAt">
        /// Time when the import job was created.
        /// </param>
        /// <param name="statusMessage">
        /// Human-readable progress or failure detail for the current status.
        /// </param>
        /// <param name="restartCount">
        /// Number of times the import worker has restarted this job.
        /// </param>
        /// <param name="maxRestarts">
        /// Maximum worker restarts allowed before the job fails permanently.
        /// </param>
        /// <param name="updatedAt">
        /// Time when the import job was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRemoteUpload(
            string id,
            string projectId,
            string modelId,
            string remoteUrl,
            global::Together.DeRemoteUploadStatus status,
            global::System.DateTime createdAt,
            string? statusMessage,
            int? restartCount,
            int? maxRestarts,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.RemoteUrl = remoteUrl ?? throw new global::System.ArgumentNullException(nameof(remoteUrl));
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.RestartCount = restartCount;
            this.MaxRestarts = maxRestarts;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRemoteUpload" /> class.
        /// </summary>
        public DeRemoteUpload()
        {
        }

    }
}