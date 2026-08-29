
#nullable enable

namespace Together
{
    /// <summary>
    /// Metadata for a saved checkpoint
    /// </summary>
    public sealed partial class RlCheckpoint
    {
        /// <summary>
        /// Unique identifier for the checkpoint<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Training session that produced the checkpoint<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Base model the checkpoint was trained from<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </summary>
        /// <example>Qwen/Qwen3-0.6B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Whether this is a training checkpoint or an inference checkpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlCheckpointTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlCheckpointType Type { get; set; }

        /// <summary>
        /// Training step at time of save<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> Step { get; set; }

        /// <summary>
        /// LoRA rank of the session that produced this checkpoint. Absent for full-weight sessions and for checkpoints saved before this field was recorded.<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// Timestamp when the checkpoint was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </summary>
        /// <example>2026-01-02T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCheckpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the checkpoint<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="sessionId">
        /// Training session that produced the checkpoint<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="baseModel">
        /// Base model the checkpoint was trained from<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </param>
        /// <param name="type">
        /// Whether this is a training checkpoint or an inference checkpoint
        /// </param>
        /// <param name="step">
        /// Training step at time of save<br/>
        /// Example: 42
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the checkpoint was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank of the session that produced this checkpoint. Absent for full-weight sessions and for checkpoints saved before this field was recorded.<br/>
        /// Example: 32
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlCheckpoint(
            string id,
            string sessionId,
            string baseModel,
            global::Together.RlCheckpointType type,
            global::Together.OneOf<string, int?> step,
            global::System.DateTime createdAt,
            int? loraRank)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.Type = type;
            this.Step = step;
            this.LoraRank = loraRank;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCheckpoint" /> class.
        /// </summary>
        public RlCheckpoint()
        {
        }

    }
}