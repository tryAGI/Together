
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationCompareParameters
    {
        /// <summary>
        /// Data file name
        /// </summary>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_a")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelOrStringJsonConverter))]
        public global::Together.EvaluationModelOrString? ModelA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_b")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelOrStringJsonConverter))]
        public global::Together.EvaluationModelOrString? ModelB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCompareParameters" /> class.
        /// </summary>
        /// <param name="inputDataFilePath">
        /// Data file name
        /// </param>
        /// <param name="judge"></param>
        /// <param name="modelA"></param>
        /// <param name="modelB"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCompareParameters(
            string inputDataFilePath,
            global::Together.EvaluationJudgeModelConfig judge,
            global::Together.EvaluationModelOrString? modelA,
            global::Together.EvaluationModelOrString? modelB)
        {
            this.InputDataFilePath = inputDataFilePath ?? throw new global::System.ArgumentNullException(nameof(inputDataFilePath));
            this.Judge = judge ?? throw new global::System.ArgumentNullException(nameof(judge));
            this.ModelA = modelA;
            this.ModelB = modelB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCompareParameters" /> class.
        /// </summary>
        public EvaluationCompareParameters()
        {
        }
    }
}