
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueError
    {
        /// <summary>
        /// Machine-readable error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The parameter that caused the error, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Error category (e.g. "invalid_request_error", "not_found_error")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueError" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable error code
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="param">
        /// The parameter that caused the error, if applicable
        /// </param>
        /// <param name="type">
        /// Error category (e.g. "invalid_request_error", "not_found_error")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueError(
            string? code,
            string? message,
            string? param,
            string? type)
        {
            this.Code = code;
            this.Message = message;
            this.Param = param;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueError" /> class.
        /// </summary>
        public QueueError()
        {
        }
    }
}