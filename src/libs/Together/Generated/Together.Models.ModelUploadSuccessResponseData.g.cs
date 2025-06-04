
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelUploadSuccessResponseData
    {
        /// <summary>
        /// Example: job-a15dad11-8d8e-4007-97c5-a211304de284
        /// </summary>
        /// <example>job-a15dad11-8d8e-4007-97c5-a211304de284</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Example: model-c0e32dfc-637e-47b2-bf4e-e9b2e58c9da7
        /// </summary>
        /// <example>model-c0e32dfc-637e-47b2-bf4e-e9b2e58c9da7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Example: necolinehubner/Qwen2.5-72B-Instruct
        /// </summary>
        /// <example>necolinehubner/Qwen2.5-72B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Example: huggingface
        /// </summary>
        /// <example>huggingface</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUploadSuccessResponseData" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Example: job-a15dad11-8d8e-4007-97c5-a211304de284
        /// </param>
        /// <param name="modelId">
        /// Example: model-c0e32dfc-637e-47b2-bf4e-e9b2e58c9da7
        /// </param>
        /// <param name="modelName">
        /// Example: necolinehubner/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="modelSource">
        /// Example: huggingface
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelUploadSuccessResponseData(
            string jobId,
            string modelId,
            string modelName,
            string modelSource)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ModelSource = modelSource ?? throw new global::System.ArgumentNullException(nameof(modelSource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUploadSuccessResponseData" /> class.
        /// </summary>
        public ModelUploadSuccessResponseData()
        {
        }
    }
}