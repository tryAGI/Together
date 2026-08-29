
#nullable enable

namespace Together
{
    /// <summary>
    /// Validation outcome for a fine-tune training file, produced by the<br/>
    /// file validation pipeline.
    /// </summary>
    public sealed partial class FileValidationReport
    {
        /// <summary>
        /// Whether the file passed validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Detected dataset format (e.g. `CONVERSATION`, `INSTRUCTION`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_format")]
        public string? DatasetFormat { get; set; }

        /// <summary>
        /// Whether the dataset carries per-sample weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_has_sample_weights")]
        public bool? DatasetHasSampleWeights { get; set; }

        /// <summary>
        /// Whether the dataset carries per-message weights (only possible for `CONVERSATION` format).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_has_message_weights")]
        public bool? DatasetHasMessageWeights { get; set; }

        /// <summary>
        /// Whether the dataset contains multimodal content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_is_multimodal")]
        public bool? DatasetIsMultimodal { get; set; }

        /// <summary>
        /// Whether the dataset contains tool-use messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_has_tools")]
        public bool? DatasetHasTools { get; set; }

        /// <summary>
        /// Whether the dataset contains parallel tool-use messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_has_parallel_tool_calls")]
        public bool? DatasetHasParallelToolCalls { get; set; }

        /// <summary>
        /// Whether the dataset contains reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_has_reasoning")]
        public bool? DatasetHasReasoning { get; set; }

        /// <summary>
        /// Number of lines (records) in the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nlines")]
        public int? Nlines { get; set; }

        /// <summary>
        /// ID of the file this report describes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Category of validation failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileValidationReportErrorTypeJsonConverter))]
        public global::Together.FileValidationReportErrorType? ErrorType { get; set; }

        /// <summary>
        /// Human-readable validation error message. Only present when<br/>
        /// `error_type` is set (i.e. user-correctable failures).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileValidationReport" /> class.
        /// </summary>
        /// <param name="valid">
        /// Whether the file passed validation.
        /// </param>
        /// <param name="datasetFormat">
        /// Detected dataset format (e.g. `CONVERSATION`, `INSTRUCTION`).
        /// </param>
        /// <param name="datasetHasSampleWeights">
        /// Whether the dataset carries per-sample weights.
        /// </param>
        /// <param name="datasetHasMessageWeights">
        /// Whether the dataset carries per-message weights (only possible for `CONVERSATION` format).
        /// </param>
        /// <param name="datasetIsMultimodal">
        /// Whether the dataset contains multimodal content.
        /// </param>
        /// <param name="datasetHasTools">
        /// Whether the dataset contains tool-use messages.
        /// </param>
        /// <param name="datasetHasParallelToolCalls">
        /// Whether the dataset contains parallel tool-use messages.
        /// </param>
        /// <param name="datasetHasReasoning">
        /// Whether the dataset contains reasoning content.
        /// </param>
        /// <param name="nlines">
        /// Number of lines (records) in the dataset.
        /// </param>
        /// <param name="fileId">
        /// ID of the file this report describes.
        /// </param>
        /// <param name="errorType">
        /// Category of validation failure.
        /// </param>
        /// <param name="error">
        /// Human-readable validation error message. Only present when<br/>
        /// `error_type` is set (i.e. user-correctable failures).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileValidationReport(
            bool valid,
            string? datasetFormat,
            bool? datasetHasSampleWeights,
            bool? datasetHasMessageWeights,
            bool? datasetIsMultimodal,
            bool? datasetHasTools,
            bool? datasetHasParallelToolCalls,
            bool? datasetHasReasoning,
            int? nlines,
            string? fileId,
            global::Together.FileValidationReportErrorType? errorType,
            string? error)
        {
            this.Valid = valid;
            this.DatasetFormat = datasetFormat;
            this.DatasetHasSampleWeights = datasetHasSampleWeights;
            this.DatasetHasMessageWeights = datasetHasMessageWeights;
            this.DatasetIsMultimodal = datasetIsMultimodal;
            this.DatasetHasTools = datasetHasTools;
            this.DatasetHasParallelToolCalls = datasetHasParallelToolCalls;
            this.DatasetHasReasoning = datasetHasReasoning;
            this.Nlines = nlines;
            this.FileId = fileId;
            this.ErrorType = errorType;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileValidationReport" /> class.
        /// </summary>
        public FileValidationReport()
        {
        }

    }
}