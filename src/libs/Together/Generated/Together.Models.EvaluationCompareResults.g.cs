
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationCompareResults
    {
        /// <summary>
        /// Number of times model A won
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("A_wins")]
        public int? AWins { get; set; }

        /// <summary>
        /// Number of times model B won
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("B_wins")]
        public int? BWins { get; set; }

        /// <summary>
        /// Number of ties
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Ties")]
        public int? Ties { get; set; }

        /// <summary>
        /// Number of failed generations.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_fail_count")]
        public double? GenerationFailCount { get; set; }

        /// <summary>
        /// Number of failed judge generations<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_fail_count")]
        public double? JudgeFailCount { get; set; }

        /// <summary>
        /// Total number of samples compared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_samples")]
        public int? NumSamples { get; set; }

        /// <summary>
        /// Data File ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_file_id")]
        public string? ResultFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCompareResults" /> class.
        /// </summary>
        /// <param name="aWins">
        /// Number of times model A won
        /// </param>
        /// <param name="bWins">
        /// Number of times model B won
        /// </param>
        /// <param name="ties">
        /// Number of ties
        /// </param>
        /// <param name="generationFailCount">
        /// Number of failed generations.<br/>
        /// Example: 0
        /// </param>
        /// <param name="judgeFailCount">
        /// Number of failed judge generations<br/>
        /// Example: 0
        /// </param>
        /// <param name="numSamples">
        /// Total number of samples compared
        /// </param>
        /// <param name="resultFileId">
        /// Data File ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCompareResults(
            int? aWins,
            int? bWins,
            int? ties,
            double? generationFailCount,
            double? judgeFailCount,
            int? numSamples,
            string? resultFileId)
        {
            this.AWins = aWins;
            this.BWins = bWins;
            this.Ties = ties;
            this.GenerationFailCount = generationFailCount;
            this.JudgeFailCount = judgeFailCount;
            this.NumSamples = numSamples;
            this.ResultFileId = resultFileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCompareResults" /> class.
        /// </summary>
        public EvaluationCompareResults()
        {
        }
    }
}