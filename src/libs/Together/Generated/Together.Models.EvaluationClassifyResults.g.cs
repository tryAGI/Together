
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationClassifyResults
    {
        /// <summary>
        /// Number of failed generations.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_fail_count")]
        public double? GenerationFailCount { get; set; }

        /// <summary>
        /// Number of invalid labels<br/>
        /// Example: 0F
        /// </summary>
        /// <example>0F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_label_count")]
        public float? InvalidLabelCount { get; set; }

        /// <summary>
        /// Number of failed judge generations<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_fail_count")]
        public double? JudgeFailCount { get; set; }

        /// <summary>
        /// JSON string representing label counts<br/>
        /// Example: {"yes": 10, "no": 0}
        /// </summary>
        /// <example>{"yes": 10, "no": 0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_counts")]
        public string? LabelCounts { get; set; }

        /// <summary>
        /// Pecentage of pass labels.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_percentage")]
        public double? PassPercentage { get; set; }

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
        /// Initializes a new instance of the <see cref="EvaluationClassifyResults" /> class.
        /// </summary>
        /// <param name="generationFailCount">
        /// Number of failed generations.<br/>
        /// Example: 0
        /// </param>
        /// <param name="invalidLabelCount">
        /// Number of invalid labels<br/>
        /// Example: 0F
        /// </param>
        /// <param name="judgeFailCount">
        /// Number of failed judge generations<br/>
        /// Example: 0
        /// </param>
        /// <param name="labelCounts">
        /// JSON string representing label counts<br/>
        /// Example: {"yes": 10, "no": 0}
        /// </param>
        /// <param name="passPercentage">
        /// Pecentage of pass labels.<br/>
        /// Example: 10
        /// </param>
        /// <param name="resultFileId">
        /// Data File ID<br/>
        /// Example: file-1234-aefd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationClassifyResults(
            double? generationFailCount,
            float? invalidLabelCount,
            double? judgeFailCount,
            string? labelCounts,
            double? passPercentage,
            string? resultFileId)
        {
            this.GenerationFailCount = generationFailCount;
            this.InvalidLabelCount = invalidLabelCount;
            this.JudgeFailCount = judgeFailCount;
            this.LabelCounts = labelCounts;
            this.PassPercentage = passPercentage;
            this.ResultFileId = resultFileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationClassifyResults" /> class.
        /// </summary>
        public EvaluationClassifyResults()
        {
        }
    }
}