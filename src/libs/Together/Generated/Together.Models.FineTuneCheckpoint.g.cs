
#nullable enable

namespace Together
{
    /// <summary>
    /// A checkpoint available for a fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneCheckpoint
    {
        /// <summary>
        /// Step represented by the checkpoint; final checkpoints use the shipped model step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Step { get; set; }

        /// <summary>
        /// Timestamp when the checkpoint was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Storage path for the checkpoint artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Display label for the checkpoint, including the final or intermediate checkpoint step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointType { get; set; }

        /// <summary>
        /// Canonical artifact selector for checkpoint download requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FineTuneCheckpointCheckpointJsonConverter))]
        public global::Together.FineTuneCheckpointCheckpoint? Checkpoint { get; set; }

        /// <summary>
        /// Together model registry object ID for the checkpoint artifact (e.g. `ml_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// Together model registry name for the checkpoint artifact, formatted as `&lt;project_slug&gt;/&lt;checkpoint_name&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_name")]
        public string? ObjectName { get; set; }

        /// <summary>
        /// Together model registry revision ID for the checkpoint artifact (e.g. `rv_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_revision_id")]
        public string? ObjectRevisionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneCheckpoint" /> class.
        /// </summary>
        /// <param name="step">
        /// Step represented by the checkpoint; final checkpoints use the shipped model step.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the checkpoint was created.
        /// </param>
        /// <param name="path">
        /// Storage path for the checkpoint artifact.
        /// </param>
        /// <param name="checkpointType">
        /// Display label for the checkpoint, including the final or intermediate checkpoint step.
        /// </param>
        /// <param name="checkpoint">
        /// Canonical artifact selector for checkpoint download requests.
        /// </param>
        /// <param name="objectId">
        /// Together model registry object ID for the checkpoint artifact (e.g. `ml_...`).
        /// </param>
        /// <param name="objectName">
        /// Together model registry name for the checkpoint artifact, formatted as `&lt;project_slug&gt;/&lt;checkpoint_name&gt;`.
        /// </param>
        /// <param name="objectRevisionId">
        /// Together model registry revision ID for the checkpoint artifact (e.g. `rv_...`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneCheckpoint(
            int step,
            string createdAt,
            string path,
            string checkpointType,
            global::Together.FineTuneCheckpointCheckpoint? checkpoint,
            string? objectId,
            string? objectName,
            string? objectRevisionId)
        {
            this.Step = step;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.CheckpointType = checkpointType ?? throw new global::System.ArgumentNullException(nameof(checkpointType));
            this.Checkpoint = checkpoint;
            this.ObjectId = objectId;
            this.ObjectName = objectName;
            this.ObjectRevisionId = objectRevisionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneCheckpoint" /> class.
        /// </summary>
        public FineTuneCheckpoint()
        {
        }

    }
}