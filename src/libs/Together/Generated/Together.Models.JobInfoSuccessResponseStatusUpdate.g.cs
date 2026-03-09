
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobInfoSuccessResponseStatusUpdate
    {
        /// <summary>
        /// Example: Job is Complete
        /// </summary>
        /// <example>Job is Complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Example: Complete
        /// </summary>
        /// <example>Complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Example: 2025-03-11T22:36:12.0000000+00:00
        /// </summary>
        /// <example>2025-03-11T22:36:12.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInfoSuccessResponseStatusUpdate" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Job is Complete
        /// </param>
        /// <param name="status">
        /// Example: Complete
        /// </param>
        /// <param name="timestamp">
        /// Example: 2025-03-11T22:36:12.0000000+00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobInfoSuccessResponseStatusUpdate(
            string message,
            string status,
            global::System.DateTime timestamp)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInfoSuccessResponseStatusUpdate" /> class.
        /// </summary>
        public JobInfoSuccessResponseStatusUpdate()
        {
        }
    }
}