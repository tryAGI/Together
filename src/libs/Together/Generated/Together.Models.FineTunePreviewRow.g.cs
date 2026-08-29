
#nullable enable

namespace Together
{
    /// <summary>
    /// Tokenized representation of one sampled fine-tuning row.
    /// </summary>
    public sealed partial class FineTunePreviewRow
    {
        /// <summary>
        /// Token IDs produced for the sampled row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InputIds { get; set; }

        /// <summary>
        /// Raw token strings produced for the sampled row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tokens { get; set; }

        /// <summary>
        /// Training labels for each token; masked tokens use -100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Labels { get; set; }

        /// <summary>
        /// Half-open token index ranges that contribute to training loss.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> TrainedSpans { get; set; }

        /// <summary>
        /// Total number of tokens in the preview row after truncation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTokens { get; set; }

        /// <summary>
        /// Number of tokens in the row that contribute to training loss.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_trained_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTrainedTokens { get; set; }

        /// <summary>
        /// Whether the row was truncated to the model maximum sequence length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewRow" /> class.
        /// </summary>
        /// <param name="inputIds">
        /// Token IDs produced for the sampled row.
        /// </param>
        /// <param name="tokens">
        /// Raw token strings produced for the sampled row.
        /// </param>
        /// <param name="labels">
        /// Training labels for each token; masked tokens use -100.
        /// </param>
        /// <param name="trainedSpans">
        /// Half-open token index ranges that contribute to training loss.
        /// </param>
        /// <param name="numTokens">
        /// Total number of tokens in the preview row after truncation.
        /// </param>
        /// <param name="numTrainedTokens">
        /// Number of tokens in the row that contribute to training loss.
        /// </param>
        /// <param name="truncated">
        /// Whether the row was truncated to the model maximum sequence length.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTunePreviewRow(
            global::System.Collections.Generic.IList<int> inputIds,
            global::System.Collections.Generic.IList<string> tokens,
            global::System.Collections.Generic.IList<int> labels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> trainedSpans,
            int numTokens,
            int numTrainedTokens,
            bool truncated)
        {
            this.InputIds = inputIds ?? throw new global::System.ArgumentNullException(nameof(inputIds));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.TrainedSpans = trainedSpans ?? throw new global::System.ArgumentNullException(nameof(trainedSpans));
            this.NumTokens = numTokens;
            this.NumTrainedTokens = numTrainedTokens;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewRow" /> class.
        /// </summary>
        public FineTunePreviewRow()
        {
        }

    }
}