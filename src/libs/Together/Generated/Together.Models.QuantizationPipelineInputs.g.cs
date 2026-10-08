
#nullable enable

namespace Together
{
    /// <summary>
    /// Adapter identifiers to prepare.<br/>
    /// Example: {"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
    /// </summary>
    public sealed partial class QuantizationPipelineInputs
    {
        /// <summary>
        /// Model object ID of the adapter to prepare.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterObjectId { get; set; }

        /// <summary>
        /// Adapter revision ID to prepare. Omit to use the adapter's current revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_revision_id")]
        public string? AdapterRevisionId { get; set; }

        /// <summary>
        /// Conversation dataset file ID to use for calibration. Upload it first with `POST /v1/files` using purpose `calibration` and file type `jsonl`. Each JSONL row must contain a `messages` array and may contain a `tools` array.<br/>
        /// When provided, the job draws half of the calibration corpus from this file and half from a general-text corpus. When omitted, the job calibrates on the general-text corpus only.<br/>
        /// The request is rejected unless the file exists in the request project, has finished uploading, has passed files API validation as a conversation dataset, is not empty, and is at most 64 MiB. A `fine-tune` purpose file is also accepted so a training file can be reused.<br/>
        /// Example: file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35
        /// </summary>
        /// <example>file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibration_file_id")]
        public string? CalibrationFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationPipelineInputs" /> class.
        /// </summary>
        /// <param name="adapterObjectId">
        /// Model object ID of the adapter to prepare.
        /// </param>
        /// <param name="adapterRevisionId">
        /// Adapter revision ID to prepare. Omit to use the adapter's current revision.
        /// </param>
        /// <param name="calibrationFileId">
        /// Conversation dataset file ID to use for calibration. Upload it first with `POST /v1/files` using purpose `calibration` and file type `jsonl`. Each JSONL row must contain a `messages` array and may contain a `tools` array.<br/>
        /// When provided, the job draws half of the calibration corpus from this file and half from a general-text corpus. When omitted, the job calibrates on the general-text corpus only.<br/>
        /// The request is rejected unless the file exists in the request project, has finished uploading, has passed files API validation as a conversation dataset, is not empty, and is at most 64 MiB. A `fine-tune` purpose file is also accepted so a training file can be reused.<br/>
        /// Example: file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationPipelineInputs(
            string adapterObjectId,
            string? adapterRevisionId,
            string? calibrationFileId)
        {
            this.AdapterObjectId = adapterObjectId ?? throw new global::System.ArgumentNullException(nameof(adapterObjectId));
            this.AdapterRevisionId = adapterRevisionId;
            this.CalibrationFileId = calibrationFileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationPipelineInputs" /> class.
        /// </summary>
        public QuantizationPipelineInputs()
        {
        }

    }
}