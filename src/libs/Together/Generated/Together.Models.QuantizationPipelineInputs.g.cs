
#nullable enable

namespace Together
{
    /// <summary>
    /// The model to prepare: an adapter or a full model. A request names it by the `model_*` fields or the deprecated `adapter_*` fields, never a mix of the two, and gives a revision only beside the ID it belongs to. A job returns both names, with the same values.<br/>
    /// Example: {"model_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","model_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
    /// </summary>
    public sealed partial class QuantizationPipelineInputs
    {
        /// <summary>
        /// Model object ID of the model to prepare. It names the input model; it is not the `results.model_object_id` of a job, which names the model the job produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_object_id")]
        public string? ModelObjectId { get; set; }

        /// <summary>
        /// Revision ID of the model to prepare. Omit to use the model's current revision. Only valid with `model_object_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_revision_id")]
        public string? ModelRevisionId { get; set; }

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
        /// <param name="modelObjectId">
        /// Model object ID of the model to prepare. It names the input model; it is not the `results.model_object_id` of a job, which names the model the job produced.
        /// </param>
        /// <param name="modelRevisionId">
        /// Revision ID of the model to prepare. Omit to use the model's current revision. Only valid with `model_object_id`.
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
            string? modelObjectId,
            string? modelRevisionId,
            string? calibrationFileId)
        {
            this.ModelObjectId = modelObjectId;
            this.ModelRevisionId = modelRevisionId;
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