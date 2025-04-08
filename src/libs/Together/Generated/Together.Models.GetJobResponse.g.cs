
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GetJobResponseArgs Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GetJobResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.GetJobResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.GetJobResponseStatusUpdate> StatusUpdates { get; set; }

        /// <summary>
        /// Example: model_upload
        /// </summary>
        /// <example>model_upload</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetJobResponse" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="createdAt"></param>
        /// <param name="jobId">
        /// Example: job-a15dad11-8d8e-4007-97c5-a211304de284
        /// </param>
        /// <param name="status">
        /// Example: Complete
        /// </param>
        /// <param name="statusUpdates"></param>
        /// <param name="type">
        /// Example: model_upload
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetJobResponse(
            global::Together.GetJobResponseArgs args,
            global::System.DateTime createdAt,
            string jobId,
            global::Together.GetJobResponseStatus status,
            global::System.Collections.Generic.IList<global::Together.GetJobResponseStatusUpdate> statusUpdates,
            string type,
            global::System.DateTime updatedAt)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.CreatedAt = createdAt;
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.StatusUpdates = statusUpdates ?? throw new global::System.ArgumentNullException(nameof(statusUpdates));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetJobResponse" /> class.
        /// </summary>
        public GetJobResponse()
        {
        }
    }
}