
#nullable enable

namespace Together
{
    /// <summary>
    /// Public fields common to shaping events.
    /// </summary>
    public sealed partial class BaseShapingEvent
    {
        /// <summary>
        /// Object type, always `shaping`.
        /// </summary>
        /// <default>"shaping"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "shaping";

        /// <summary>
        /// Time when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Event severity level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EventLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EventLevel Level { get; set; }

        /// <summary>
        /// Human-readable event message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Event hash used for deduplication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseShapingEvent" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Time when the event was created.
        /// </param>
        /// <param name="level">
        /// Event severity level.
        /// </param>
        /// <param name="message">
        /// Human-readable event message.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
        /// <param name="hash">
        /// Event hash used for deduplication.
        /// </param>
        /// <param name="object">
        /// Object type, always `shaping`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseShapingEvent(
            global::System.DateTime createdAt,
            global::Together.EventLevel level,
            string message,
            string type,
            string? hash,
            string @object = "shaping")
        {
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Level = level;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Hash = hash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseShapingEvent" /> class.
        /// </summary>
        public BaseShapingEvent()
        {
        }

    }
}