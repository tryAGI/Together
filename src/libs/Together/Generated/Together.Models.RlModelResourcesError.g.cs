
#nullable enable

namespace Together
{
    /// <summary>
    /// Structured detail for the model resource's current error
    /// </summary>
    public sealed partial class RlModelResourcesError
    {
        /// <summary>
        /// Finite machine-readable reason code for UI branching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlModelResourcesErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlModelResourcesErrorCode Code { get; set; }

        /// <summary>
        /// User-safe human-readable detail for the current status<br/>
        /// Example: Timed out waiting for cluster capacity. Try again later.
        /// </summary>
        /// <example>Timed out waiting for cluster capacity. Try again later.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Timestamp when this error was reported<br/>
        /// Example: 2026-01-02T00:00:05Z
        /// </summary>
        /// <example>2026-01-02T00:00:05Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurred_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime OccurredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesError" /> class.
        /// </summary>
        /// <param name="code">
        /// Finite machine-readable reason code for UI branching
        /// </param>
        /// <param name="message">
        /// User-safe human-readable detail for the current status<br/>
        /// Example: Timed out waiting for cluster capacity. Try again later.
        /// </param>
        /// <param name="occurredAt">
        /// Timestamp when this error was reported<br/>
        /// Example: 2026-01-02T00:00:05Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelResourcesError(
            global::Together.RlModelResourcesErrorCode code,
            string message,
            global::System.DateTime occurredAt)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.OccurredAt = occurredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesError" /> class.
        /// </summary>
        public RlModelResourcesError()
        {
        }

    }
}