
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationScoreParameters
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::Together.EvaluationJudgeModelConfig Judge { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required double MinScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required double MaxScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required double PassThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_to_evaluate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelOrStringJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.EvaluationModelOrString? ModelToEvaluate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_data_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string InputDataFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreParameters" /> class.
        /// </summary>
        /// <param name="judge"></param>
        /// <param name="minScore"></param>
        /// <param name="maxScore"></param>
        /// <param name="passThreshold"></param>
        /// <param name="inputDataFilePath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationScoreParameters(
            global::Together.EvaluationJudgeModelConfig judge,
            double minScore,
            double maxScore,
            double passThreshold,
            string inputDataFilePath)
        {
            this.Judge = judge ?? throw new global::System.ArgumentNullException(nameof(judge));
            this.MinScore = minScore;
            this.MaxScore = maxScore;
            this.PassThreshold = passThreshold;
            this.InputDataFilePath = inputDataFilePath ?? throw new global::System.ArgumentNullException(nameof(inputDataFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreParameters" /> class.
        /// </summary>
        public EvaluationScoreParameters()
        {
        }

    }
}