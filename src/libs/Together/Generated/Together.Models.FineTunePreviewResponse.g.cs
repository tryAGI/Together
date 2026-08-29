
#nullable enable

namespace Together
{
    /// <summary>
    /// Tokenized preview for sampled rows from a fine-tuning training file.
    /// </summary>
    public sealed partial class FineTunePreviewResponse
    {
        /// <summary>
        /// Name of the base model used to tokenize the sampled rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Detected SFT dataset format for the sampled rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FineTunePreviewResponseDatasetFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FineTunePreviewResponseDatasetFormat DatasetFormat { get; set; }

        /// <summary>
        /// Maximum sequence length configured for the requested model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSeqLength { get; set; }

        /// <summary>
        /// Whether prompt or user-message tokens contribute to training loss.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_on_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TrainOnInputs { get; set; }

        /// <summary>
        /// Tokenized preview rows, in the same order as the sampled training file rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.FineTunePreviewRow> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// Name of the base model used to tokenize the sampled rows.
        /// </param>
        /// <param name="datasetFormat">
        /// Detected SFT dataset format for the sampled rows.
        /// </param>
        /// <param name="maxSeqLength">
        /// Maximum sequence length configured for the requested model.
        /// </param>
        /// <param name="trainOnInputs">
        /// Whether prompt or user-message tokens contribute to training loss.
        /// </param>
        /// <param name="rows">
        /// Tokenized preview rows, in the same order as the sampled training file rows.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTunePreviewResponse(
            string model,
            global::Together.FineTunePreviewResponseDatasetFormat datasetFormat,
            int maxSeqLength,
            bool trainOnInputs,
            global::System.Collections.Generic.IList<global::Together.FineTunePreviewRow> rows)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.DatasetFormat = datasetFormat;
            this.MaxSeqLength = maxSeqLength;
            this.TrainOnInputs = trainOnInputs;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewResponse" /> class.
        /// </summary>
        public FineTunePreviewResponse()
        {
        }

    }
}