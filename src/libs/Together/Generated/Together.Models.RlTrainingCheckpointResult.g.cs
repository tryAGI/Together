
#nullable enable

namespace Together
{
    /// <summary>
    /// Result of a save training checkpoint operation
    /// </summary>
    public sealed partial class RlTrainingCheckpointResult
    {
        /// <summary>
        /// ID of the saved training checkpoint (use for resume via Start)<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpointResult" /> class.
        /// </summary>
        /// <param name="checkpointId">
        /// ID of the saved training checkpoint (use for resume via Start)<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingCheckpointResult(
            string checkpointId)
        {
            this.CheckpointId = checkpointId ?? throw new global::System.ArgumentNullException(nameof(checkpointId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpointResult" /> class.
        /// </summary>
        public RlTrainingCheckpointResult()
        {
        }
    }
}