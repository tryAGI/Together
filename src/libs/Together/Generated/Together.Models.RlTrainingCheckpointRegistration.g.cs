
#nullable enable

namespace Together
{
    /// <summary>
    /// Together model registry details for a training checkpoint
    /// </summary>
    public sealed partial class RlTrainingCheckpointRegistration
    {
        /// <summary>
        /// Together model registry object ID for the training checkpoint artifact (e.g. `ml_...`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// Together model registry revision ID for the training checkpoint artifact (e.g. `rv_...`), empty when the upload reported no revision
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_revision_id")]
        public string? ObjectRevisionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpointRegistration" /> class.
        /// </summary>
        /// <param name="objectId">
        /// Together model registry object ID for the training checkpoint artifact (e.g. `ml_...`)
        /// </param>
        /// <param name="objectRevisionId">
        /// Together model registry revision ID for the training checkpoint artifact (e.g. `rv_...`), empty when the upload reported no revision
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingCheckpointRegistration(
            string objectId,
            string? objectRevisionId)
        {
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.ObjectRevisionId = objectRevisionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpointRegistration" /> class.
        /// </summary>
        public RlTrainingCheckpointRegistration()
        {
        }

    }
}