
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationScoreResults
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregated_scores")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.EvaluationScoreResultsAggregatedScores? AggregatedScores { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_fail_count")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? GenerationFailCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_fail_count")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? JudgeFailCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_score_count")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? InvalidScoreCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_samples")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? FailedSamples { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_file_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ResultFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreResults" /> class.
        /// </summary>
        /// <param name="aggregatedScores"></param>
        /// <param name="generationFailCount"></param>
        /// <param name="judgeFailCount"></param>
        /// <param name="invalidScoreCount"></param>
        /// <param name="failedSamples"></param>
        /// <param name="resultFileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationScoreResults(
            global::Together.EvaluationScoreResultsAggregatedScores? aggregatedScores,
            double? generationFailCount,
            double? judgeFailCount,
            double? invalidScoreCount,
            double? failedSamples,
            string? resultFileId)
        {
            this.AggregatedScores = aggregatedScores;
            this.GenerationFailCount = generationFailCount;
            this.JudgeFailCount = judgeFailCount;
            this.InvalidScoreCount = invalidScoreCount;
            this.FailedSamples = failedSamples;
            this.ResultFileId = resultFileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreResults" /> class.
        /// </summary>
        public EvaluationScoreResults()
        {
        }

    }
}