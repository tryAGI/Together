
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicaEvent
    {
        /// <summary>
        /// Image is the container image used for this replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// ReplicaReadySince is the timestamp when the replica became ready to serve traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_ready_since")]
        public string? ReplicaReadySince { get; set; }

        /// <summary>
        /// ReplicaStatus is the current status of the replica (e.g., "Running", "Waiting", "Terminated")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_status")]
        public string? ReplicaStatus { get; set; }

        /// <summary>
        /// ReplicaStatusMessage provides a human-readable message explaining the replica's status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_status_message")]
        public string? ReplicaStatusMessage { get; set; }

        /// <summary>
        /// ReplicaStatusReason provides a brief machine-readable reason for the replica's status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_status_reason")]
        public string? ReplicaStatusReason { get; set; }

        /// <summary>
        /// RevisionID is the deployment revision ID associated with this replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_id")]
        public string? RevisionId { get; set; }

        /// <summary>
        /// VolumePreloadCompletedAt is the timestamp when the volume preload completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_preload_completed_at")]
        public string? VolumePreloadCompletedAt { get; set; }

        /// <summary>
        /// VolumePreloadStartedAt is the timestamp when the volume preload started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_preload_started_at")]
        public string? VolumePreloadStartedAt { get; set; }

        /// <summary>
        /// VolumePreloadStatus is the status of the volume preload (e.g., "InProgress", "Completed", "Failed")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_preload_status")]
        public string? VolumePreloadStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaEvent" /> class.
        /// </summary>
        /// <param name="image">
        /// Image is the container image used for this replica
        /// </param>
        /// <param name="replicaReadySince">
        /// ReplicaReadySince is the timestamp when the replica became ready to serve traffic
        /// </param>
        /// <param name="replicaStatus">
        /// ReplicaStatus is the current status of the replica (e.g., "Running", "Waiting", "Terminated")
        /// </param>
        /// <param name="replicaStatusMessage">
        /// ReplicaStatusMessage provides a human-readable message explaining the replica's status
        /// </param>
        /// <param name="replicaStatusReason">
        /// ReplicaStatusReason provides a brief machine-readable reason for the replica's status
        /// </param>
        /// <param name="revisionId">
        /// RevisionID is the deployment revision ID associated with this replica
        /// </param>
        /// <param name="volumePreloadCompletedAt">
        /// VolumePreloadCompletedAt is the timestamp when the volume preload completed
        /// </param>
        /// <param name="volumePreloadStartedAt">
        /// VolumePreloadStartedAt is the timestamp when the volume preload started
        /// </param>
        /// <param name="volumePreloadStatus">
        /// VolumePreloadStatus is the status of the volume preload (e.g., "InProgress", "Completed", "Failed")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicaEvent(
            string? image,
            string? replicaReadySince,
            string? replicaStatus,
            string? replicaStatusMessage,
            string? replicaStatusReason,
            string? revisionId,
            string? volumePreloadCompletedAt,
            string? volumePreloadStartedAt,
            string? volumePreloadStatus)
        {
            this.Image = image;
            this.ReplicaReadySince = replicaReadySince;
            this.ReplicaStatus = replicaStatus;
            this.ReplicaStatusMessage = replicaStatusMessage;
            this.ReplicaStatusReason = replicaStatusReason;
            this.RevisionId = revisionId;
            this.VolumePreloadCompletedAt = volumePreloadCompletedAt;
            this.VolumePreloadStartedAt = volumePreloadStartedAt;
            this.VolumePreloadStatus = volumePreloadStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaEvent" /> class.
        /// </summary>
        public ReplicaEvent()
        {
        }
    }
}