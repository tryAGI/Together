
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: /v1/chat/completions
        /// </summary>
        /// <example>/v1/chat/completions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Example: file-errors456def789jkl
        /// </summary>
        /// <example>file-errors456def789jkl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// Size of input file in bytes<br/>
        /// Example: 1048576L
        /// </summary>
        /// <example>1048576L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size_bytes")]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// Example: 01234567-8901-2345-6789-012345678901
        /// </summary>
        /// <example>01234567-8901-2345-6789-012345678901</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Example: file-input123abc456def
        /// </summary>
        /// <example>file-input123abc456def</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        public string? InputFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_deadline")]
        public global::System.DateTime? JobDeadline { get; set; }

        /// <summary>
        /// Model used for processing requests<br/>
        /// Example: meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo
        /// </summary>
        /// <example>meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Example: file-output789xyz012ghi
        /// </summary>
        /// <example>file-output789xyz012ghi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// Completion progress (0.0 to 100)<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// Current status of the batch job<br/>
        /// Example: IN_PROGRESS
        /// </summary>
        /// <example>IN_PROGRESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.BatchJobStatusJsonConverter))]
        public global::Together.BatchJobStatus? Status { get; set; }

        /// <summary>
        /// Example: user_789xyz012
        /// </summary>
        /// <example>user_789xyz012</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJob" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="endpoint">
        /// Example: /v1/chat/completions
        /// </param>
        /// <param name="error"></param>
        /// <param name="errorFileId">
        /// Example: file-errors456def789jkl
        /// </param>
        /// <param name="fileSizeBytes">
        /// Size of input file in bytes<br/>
        /// Example: 1048576L
        /// </param>
        /// <param name="id">
        /// Example: 01234567-8901-2345-6789-012345678901
        /// </param>
        /// <param name="inputFileId">
        /// Example: file-input123abc456def
        /// </param>
        /// <param name="jobDeadline"></param>
        /// <param name="modelId">
        /// Model used for processing requests<br/>
        /// Example: meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo
        /// </param>
        /// <param name="outputFileId">
        /// Example: file-output789xyz012ghi
        /// </param>
        /// <param name="progress">
        /// Completion progress (0.0 to 100)<br/>
        /// Example: 75
        /// </param>
        /// <param name="status">
        /// Current status of the batch job<br/>
        /// Example: IN_PROGRESS
        /// </param>
        /// <param name="userId">
        /// Example: user_789xyz012
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJob(
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? endpoint,
            string? error,
            string? errorFileId,
            long? fileSizeBytes,
            global::System.Guid? id,
            string? inputFileId,
            global::System.DateTime? jobDeadline,
            string? modelId,
            string? outputFileId,
            double? progress,
            global::Together.BatchJobStatus? status,
            string? userId)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Endpoint = endpoint;
            this.Error = error;
            this.ErrorFileId = errorFileId;
            this.FileSizeBytes = fileSizeBytes;
            this.Id = id;
            this.InputFileId = inputFileId;
            this.JobDeadline = jobDeadline;
            this.ModelId = modelId;
            this.OutputFileId = outputFileId;
            this.Progress = progress;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJob" /> class.
        /// </summary>
        public BatchJob()
        {
        }
    }
}