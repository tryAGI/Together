
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationScoreResultsAggregatedScores
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean_score")]
        public float? MeanScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_percentage")]
        public float? PassPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("std_score")]
        public float? StdScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreResultsAggregatedScores" /> class.
        /// </summary>
        /// <param name="meanScore"></param>
        /// <param name="passPercentage"></param>
        /// <param name="stdScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationScoreResultsAggregatedScores(
            float? meanScore,
            float? passPercentage,
            float? stdScore)
        {
            this.MeanScore = meanScore;
            this.PassPercentage = passPercentage;
            this.StdScore = stdScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreResultsAggregatedScores" /> class.
        /// </summary>
        public EvaluationScoreResultsAggregatedScores()
        {
        }
    }
}