
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatchRequest
    {
        /// <summary>
        /// Time window for batch completion (optional)<br/>
        /// Example: 24h
        /// </summary>
        /// <example>24h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        public string? CompletionWindow { get; set; }

        /// <summary>
        /// The endpoint to use for batch processing<br/>
        /// Example: /v1/chat/completions
        /// </summary>
        /// <example>/v1/chat/completions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// ID of the uploaded input file containing batch requests<br/>
        /// Example: file-abc123def456ghi789
        /// </summary>
        /// <example>file-abc123def456ghi789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// Model to use for processing batch requests<br/>
        /// Example: meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo
        /// </summary>
        /// <example>meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Priority for batch processing (optional)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        /// <param name="completionWindow">
        /// Time window for batch completion (optional)<br/>
        /// Example: 24h
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to use for batch processing<br/>
        /// Example: /v1/chat/completions
        /// </param>
        /// <param name="inputFileId">
        /// ID of the uploaded input file containing batch requests<br/>
        /// Example: file-abc123def456ghi789
        /// </param>
        /// <param name="modelId">
        /// Model to use for processing batch requests<br/>
        /// Example: meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo
        /// </param>
        /// <param name="priority">
        /// Priority for batch processing (optional)<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchRequest(
            string endpoint,
            string inputFileId,
            string? completionWindow,
            string? modelId,
            int? priority)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow;
            this.ModelId = modelId;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        public CreateBatchRequest()
        {
        }
    }
}