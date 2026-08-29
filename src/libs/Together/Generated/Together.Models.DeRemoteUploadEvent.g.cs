
#nullable enable

namespace Together
{
    /// <summary>
    /// Progress or diagnostic event emitted while importing remote model files.
    /// </summary>
    public sealed partial class DeRemoteUploadEvent
    {
        /// <summary>
        /// Unique event identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time when the event was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Severity of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRemoteUploadEventLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeRemoteUploadEventLevel Level { get; set; }

        /// <summary>
        /// Stable event type emitted by the importer, such as `download.started`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Human-readable progress or diagnostic message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRemoteUploadEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique event identifier.
        /// </param>
        /// <param name="createdAt">
        /// Time when the event was recorded.
        /// </param>
        /// <param name="level">
        /// Severity of the event.
        /// </param>
        /// <param name="type">
        /// Stable event type emitted by the importer, such as `download.started`.
        /// </param>
        /// <param name="message">
        /// Human-readable progress or diagnostic message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRemoteUploadEvent(
            string id,
            global::System.DateTime createdAt,
            global::Together.DeRemoteUploadEventLevel level,
            string type,
            string message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Level = level;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRemoteUploadEvent" /> class.
        /// </summary>
        public DeRemoteUploadEvent()
        {
        }

    }
}