
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationClassifyResults
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_label_count")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? InvalidLabelCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_file_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ResultFileId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_percentage")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? PassPercentage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_counts")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? LabelCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationClassifyResults" /> class.
        /// </summary>
        /// <param name="generationFailCount"></param>
        /// <param name="judgeFailCount"></param>
        /// <param name="invalidLabelCount"></param>
        /// <param name="resultFileId"></param>
        /// <param name="passPercentage"></param>
        /// <param name="labelCounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationClassifyResults(
            double? generationFailCount,
            double? judgeFailCount,
            double? invalidLabelCount,
            string? resultFileId,
            double? passPercentage,
            string? labelCounts)
        {
            this.GenerationFailCount = generationFailCount;
            this.JudgeFailCount = judgeFailCount;
            this.InvalidLabelCount = invalidLabelCount;
            this.ResultFileId = resultFileId;
            this.PassPercentage = passPercentage;
            this.LabelCounts = labelCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationClassifyResults" /> class.
        /// </summary>
        public EvaluationClassifyResults()
        {
        }

    }
}