
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueJobStatusResponse
    {
        /// <summary>
        /// Timestamp when a worker claimed the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimed_at")]
        public global::System.DateTime? ClaimedAt { get; set; }

        /// <summary>
        /// Timestamp when the job was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the job completed (done or failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done_at")]
        public global::System.DateTime? DoneAt { get; set; }

        /// <summary>
        /// Job metadata. Contains keys from the submit request, plus any<br/>
        /// modifications from the model or system (e.g. progress, retry<br/>
        /// history).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        public object? Info { get; set; }

        /// <summary>
        /// Freeform model input, as submitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Model identifier the job was submitted to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Freeform model output, populated when the job reaches done status. Contents are model-specific.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// Job priority. Higher values are processed first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// The request ID that was returned from the submit endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Number of times this job has been retried. Workers set a claim<br/>
        /// timeout and must send periodic status updates to keep the job alive.<br/>
        /// If no update is received within the timeout, the job is returned to<br/>
        /// the queue and retried. After 3 retries the job is permanently<br/>
        /// failed. Jobs explicitly failed by the model are not retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retries")]
        public int? Retries { get; set; }

        /// <summary>
        /// Current job status. Transitions: pending → running → done/failed. A pending job may also be canceled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.QueueJobStatusResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.QueueJobStatusResponseStatus Status { get; set; }

        /// <summary>
        /// Non-fatal messages about the request (e.g. deprecation notices)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobStatusResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// Model identifier the job was submitted to
        /// </param>
        /// <param name="requestId">
        /// The request ID that was returned from the submit endpoint
        /// </param>
        /// <param name="status">
        /// Current job status. Transitions: pending → running → done/failed. A pending job may also be canceled.
        /// </param>
        /// <param name="claimedAt">
        /// Timestamp when a worker claimed the job
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the job was created
        /// </param>
        /// <param name="doneAt">
        /// Timestamp when the job completed (done or failed)
        /// </param>
        /// <param name="info">
        /// Job metadata. Contains keys from the submit request, plus any<br/>
        /// modifications from the model or system (e.g. progress, retry<br/>
        /// history).
        /// </param>
        /// <param name="inputs">
        /// Freeform model input, as submitted
        /// </param>
        /// <param name="outputs">
        /// Freeform model output, populated when the job reaches done status. Contents are model-specific.
        /// </param>
        /// <param name="priority">
        /// Job priority. Higher values are processed first.
        /// </param>
        /// <param name="retries">
        /// Number of times this job has been retried. Workers set a claim<br/>
        /// timeout and must send periodic status updates to keep the job alive.<br/>
        /// If no update is received within the timeout, the job is returned to<br/>
        /// the queue and retried. After 3 retries the job is permanently<br/>
        /// failed. Jobs explicitly failed by the model are not retried.
        /// </param>
        /// <param name="warnings">
        /// Non-fatal messages about the request (e.g. deprecation notices)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueJobStatusResponse(
            string model,
            string requestId,
            global::Together.QueueJobStatusResponseStatus status,
            global::System.DateTime? claimedAt,
            global::System.DateTime? createdAt,
            global::System.DateTime? doneAt,
            object? info,
            object? inputs,
            object? outputs,
            int? priority,
            int? retries,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.ClaimedAt = claimedAt;
            this.CreatedAt = createdAt;
            this.DoneAt = doneAt;
            this.Info = info;
            this.Inputs = inputs;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Outputs = outputs;
            this.Priority = priority;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Retries = retries;
            this.Status = status;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobStatusResponse" /> class.
        /// </summary>
        public QueueJobStatusResponse()
        {
        }
    }
}