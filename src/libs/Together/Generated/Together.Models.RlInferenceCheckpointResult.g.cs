
#nullable enable

namespace Together
{
    /// <summary>
    /// Result of an inference checkpoint operation
    /// </summary>
    public sealed partial class RlInferenceCheckpointResult
    {
        /// <summary>
        /// The checkpoint this operation created. The training session lists the same checkpoint in `inference_checkpoints`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlInferenceCheckpoint Checkpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointResult" /> class.
        /// </summary>
        /// <param name="checkpoint">
        /// The checkpoint this operation created. The training session lists the same checkpoint in `inference_checkpoints`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlInferenceCheckpointResult(
            global::Together.RlInferenceCheckpoint checkpoint)
        {
            this.Checkpoint = checkpoint ?? throw new global::System.ArgumentNullException(nameof(checkpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointResult" /> class.
        /// </summary>
        public RlInferenceCheckpointResult()
        {
        }

    }
}