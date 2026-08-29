
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for previewing tokenized fine-tuning data.
    /// </summary>
    public sealed partial class FineTunePreviewRequest
    {
        /// <summary>
        /// Name of the base model whose tokenizer and chat template will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// File-ID of the uploaded JSONL training file to sample for preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// Fine-tuning method to preview. Only supervised fine-tuning is currently supported.<br/>
        /// Default Value: sft
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FineTunePreviewRequestTrainingMethodJsonConverter))]
        public global::Together.FineTunePreviewRequestTrainingMethod? TrainingMethod { get; set; }

        /// <summary>
        /// Whether prompt or user-message tokens should contribute to training loss in the preview.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_on_inputs")]
        public bool? TrainOnInputs { get; set; }

        /// <summary>
        /// Maximum number of rows from the start of the training file to tokenize.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Name of the base model whose tokenizer and chat template will be used.
        /// </param>
        /// <param name="trainingFile">
        /// File-ID of the uploaded JSONL training file to sample for preview.
        /// </param>
        /// <param name="trainingMethod">
        /// Fine-tuning method to preview. Only supervised fine-tuning is currently supported.<br/>
        /// Default Value: sft
        /// </param>
        /// <param name="trainOnInputs">
        /// Whether prompt or user-message tokens should contribute to training loss in the preview.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topK">
        /// Maximum number of rows from the start of the training file to tokenize.<br/>
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTunePreviewRequest(
            string model,
            string trainingFile,
            global::Together.FineTunePreviewRequestTrainingMethod? trainingMethod,
            bool? trainOnInputs,
            int? topK)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.TrainingMethod = trainingMethod;
            this.TrainOnInputs = trainOnInputs;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewRequest" /> class.
        /// </summary>
        public FineTunePreviewRequest()
        {
        }

    }
}