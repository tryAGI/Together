
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationScoreParameters
    {
        /// <summary>
        /// Data file ID<br/>
        /// Example: file-01234567890123456789
        /// </summary>
        /// <example>file-01234567890123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_data_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputDataFilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EvaluationJudgeModelConfig Judge { get; set; }

        /// <summary>
        /// Maximum possible score<br/>
        /// Example: 10F
        /// </summary>
        /// <example>10F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float MaxScore { get; set; }

        /// <summary>
        /// Minimum possible score<br/>
        /// Example: 0F
        /// </summary>
        /// <example>0F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float MinScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_to_evaluate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelOrStringJsonConverter))]
        public global::Together.EvaluationModelOrString? ModelToEvaluate { get; set; }

        /// <summary>
        /// Score threshold for passing<br/>
        /// Example: 7F
        /// </summary>
        /// <example>7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float PassThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreParameters" /> class.
        /// </summary>
        /// <param name="inputDataFilePath">
        /// Data file ID<br/>
        /// Example: file-01234567890123456789
        /// </param>
        /// <param name="judge"></param>
        /// <param name="maxScore">
        /// Maximum possible score<br/>
        /// Example: 10F
        /// </param>
        /// <param name="minScore">
        /// Minimum possible score<br/>
        /// Example: 0F
        /// </param>
        /// <param name="modelToEvaluate"></param>
        /// <param name="passThreshold">
        /// Score threshold for passing<br/>
        /// Example: 7F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationScoreParameters(
            string inputDataFilePath,
            global::Together.EvaluationJudgeModelConfig judge,
            float maxScore,
            float minScore,
            float passThreshold,
            global::Together.EvaluationModelOrString? modelToEvaluate)
        {
            this.InputDataFilePath = inputDataFilePath ?? throw new global::System.ArgumentNullException(nameof(inputDataFilePath));
            this.Judge = judge ?? throw new global::System.ArgumentNullException(nameof(judge));
            this.MaxScore = maxScore;
            this.MinScore = minScore;
            this.PassThreshold = passThreshold;
            this.ModelToEvaluate = modelToEvaluate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoreParameters" /> class.
        /// </summary>
        public EvaluationScoreParameters()
        {
        }
    }
}