
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneCheckpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneCheckpoint" /> class.
        /// </summary>
        /// <param name="checkpointType"></param>
        /// <param name="createdAt"></param>
        /// <param name="path"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneCheckpoint(
            string checkpointType,
            string createdAt,
            string path,
            int step)
        {
            this.CheckpointType = checkpointType ?? throw new global::System.ArgumentNullException(nameof(checkpointType));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneCheckpoint" /> class.
        /// </summary>
        public FineTuneCheckpoint()
        {
        }
    }
}