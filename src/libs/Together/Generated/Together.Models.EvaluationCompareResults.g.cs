
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationCompareResults
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("A_wins")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? AWins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("B_wins")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? BWins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Ties")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Ties { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("result_file_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ResultFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCompareResults" /> class.
        /// </summary>
        /// <param name="aWins"></param>
        /// <param name="bWins"></param>
        /// <param name="ties"></param>
        /// <param name="generationFailCount"></param>
        /// <param name="judgeFailCount"></param>
        /// <param name="resultFileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCompareResults(
            int? aWins,
            int? bWins,
            int? ties,
            double? generationFailCount,
            double? judgeFailCount,
            string? resultFileId)
        {
            this.AWins = aWins;
            this.BWins = bWins;
            this.Ties = ties;
            this.GenerationFailCount = generationFailCount;
            this.JudgeFailCount = judgeFailCount;
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