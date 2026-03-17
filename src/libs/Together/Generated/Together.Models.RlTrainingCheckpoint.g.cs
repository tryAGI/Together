
#nullable enable

namespace Together
{
    /// <summary>
    /// Saved training checkpoint
    /// </summary>
    public sealed partial class RlTrainingCheckpoint
    {
        /// <summary>
        /// Unique identifier for the checkpoint<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Training step at time of save<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public string? Step { get; set; }

        /// <summary>
        /// Timestamp when the checkpoint was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </summary>
        /// <example>2026-01-02T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the checkpoint<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="step">
        /// Training step at time of save<br/>
        /// Example: 42
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the checkpoint was created<br/>
        /// Example: 2026-01-02T00:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingCheckpoint(
            string? id,
            string? step,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Step = step;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpoint" /> class.
        /// </summary>
        public RlTrainingCheckpoint()
        {
        }
    }
}