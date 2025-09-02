
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationScoreResults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregated_scores")]
        public global::Together.EvaluationScoreResultsAggregatedScores? AggregatedScores { get; set; }

        /// <summary>
        /// number of failed samples generated from model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_samples")]
        public double? FailedSamples { get; set; }

        /// <summary>
        /// Number of failed generations.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_fail_count")]
        public double? GenerationFailCount { get; set; }

        /// <summary>
        /// number of invalid scores generated from model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_score_count")]
        public double? InvalidScoreCount { get; set; }

        /// <summary>
        /// Number of failed judge generations<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_fail_count")]
        public double? JudgeFailCount { get; set; }

        /// <summary>
        /// Data File ID<br/>
        /// Example: file-1234-aefd
        /// </summary>
        /// <example>file-1234-aefd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_file_id")]
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
        /// <param name="failedSamples">
        /// number of failed samples generated from model
        /// </param>
        /// <param name="generationFailCount">
        /// Number of failed generations.<br/>
        /// Example: 0
        /// </param>
        /// <param name="invalidScoreCount">
        /// number of invalid scores generated from model
        /// </param>
        /// <param name="judgeFailCount">
        /// Number of failed judge generations<br/>
        /// Example: 0
        /// </param>
        /// <param name="resultFileId">
        /// Data File ID<br/>
        /// Example: file-1234-aefd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationScoreResults(
            global::Together.EvaluationScoreResultsAggregatedScores? aggregatedScores,
            double? failedSamples,
            double? generationFailCount,
            double? invalidScoreCount,
            double? judgeFailCount,
            string? resultFileId)
        {
            this.AggregatedScores = aggregatedScores;
            this.FailedSamples = failedSamples;
            this.GenerationFailCount = generationFailCount;
            this.InvalidScoreCount = invalidScoreCount;
            this.JudgeFailCount = judgeFailCount;
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