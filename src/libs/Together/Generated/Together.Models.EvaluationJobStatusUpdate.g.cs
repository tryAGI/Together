
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationJobStatusUpdate
    {
        /// <summary>
        /// Additional message for this update<br/>
        /// Example: Job is pending evaluation
        /// </summary>
        /// <example>Job is pending evaluation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The status at this update<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// When this update occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJobStatusUpdate" /> class.
        /// </summary>
        /// <param name="message">
        /// Additional message for this update<br/>
        /// Example: Job is pending evaluation
        /// </param>
        /// <param name="status">
        /// The status at this update<br/>
        /// Example: pending
        /// </param>
        /// <param name="timestamp">
        /// When this update occurred
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationJobStatusUpdate(
            string? message,
            string? status,
            global::System.DateTime? timestamp)
        {
            this.Message = message;
            this.Status = status;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJobStatusUpdate" /> class.
        /// </summary>
        public EvaluationJobStatusUpdate()
        {
        }
    }
}