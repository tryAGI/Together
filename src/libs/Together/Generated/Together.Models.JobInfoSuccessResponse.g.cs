
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobInfoSuccessResponse
    {
        /// <summary>
        /// Example: model_upload
        /// </summary>
        /// <example>model_upload</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Example: job-a15dad11-8d8e-4007-97c5-a211304de284
        /// </summary>
        /// <example>job-a15dad11-8d8e-4007-97c5-a211304de284</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Example: Complete
        /// </summary>
        /// <example>Complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.JobInfoSuccessResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.JobInfoSuccessResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.JobInfoSuccessResponseStatusUpdate> StatusUpdates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.JobInfoSuccessResponseArgs Args { get; set; }

        /// <summary>
        /// Example: 2025-03-11T22:05:43Z
        /// </summary>
        /// <example>2025-03-11T22:05:43Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: 2025-03-11T22:36:12Z
        /// </summary>
        /// <example>2025-03-11T22:36:12Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInfoSuccessResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: model_upload
        /// </param>
        /// <param name="jobId">
        /// Example: job-a15dad11-8d8e-4007-97c5-a211304de284
        /// </param>
        /// <param name="status">
        /// Example: Complete
        /// </param>
        /// <param name="statusUpdates"></param>
        /// <param name="args"></param>
        /// <param name="createdAt">
        /// Example: 2025-03-11T22:05:43Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2025-03-11T22:36:12Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobInfoSuccessResponse(
            string type,
            string jobId,
            global::Together.JobInfoSuccessResponseStatus status,
            global::System.Collections.Generic.IList<global::Together.JobInfoSuccessResponseStatusUpdate> statusUpdates,
            global::Together.JobInfoSuccessResponseArgs args,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.StatusUpdates = statusUpdates ?? throw new global::System.ArgumentNullException(nameof(statusUpdates));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInfoSuccessResponse" /> class.
        /// </summary>
        public JobInfoSuccessResponse()
        {
        }
    }
}