
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationCompareResults
    {
        /// <summary>
        /// Number of samples where model A was judged the winner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("A_wins")]
        public int? AWins { get; set; }

        /// <summary>
        /// Number of samples where model B was judged the winner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("B_wins")]
        public int? BWins { get; set; }

        /// <summary>
        /// Number of samples that resulted in a tie score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Ties")]
        public int? Ties { get; set; }

        /// <summary>
        /// Number of generation failures across model A and model B.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_fail_count")]
        public double? GenerationFailCount { get; set; }

        /// <summary>
        /// Number of judge inference failures. In the default two-pass mode (disable_position_bias_correction=false) this is the combined failure count from both the original-order and flipped-order judge passes.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_fail_count")]
        public double? JudgeFailCount { get; set; }

        /// <summary>
        /// File ID of the detailed output file. Each row contains the original input fields plus judge outputs. In two-pass mode the file includes both original-order and flipped-order judge fields; in single-pass mode (disable_position_bias_correction=true) only original-order fields are present.
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
        /// Number of samples where model A was judged the winner
        /// </param>
        /// <param name="bWins">
        /// Number of samples where model B was judged the winner
        /// </param>
        /// <param name="ties">
        /// Number of samples that resulted in a tie score
        /// </param>
        /// <param name="generationFailCount">
        /// Number of generation failures across model A and model B.<br/>
        /// Example: 0
        /// </param>
        /// <param name="judgeFailCount">
        /// Number of judge inference failures. In the default two-pass mode (disable_position_bias_correction=false) this is the combined failure count from both the original-order and flipped-order judge passes.<br/>
        /// Example: 0
        /// </param>
        /// <param name="resultFileId">
        /// File ID of the detailed output file. Each row contains the original input fields plus judge outputs. In two-pass mode the file includes both original-order and flipped-order judge fields; in single-pass mode (disable_position_bias_correction=true) only original-order fields are present.
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