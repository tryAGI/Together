
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationClassifyParameters
    {
        /// <summary>
        /// Data file ID<br/>
        /// Example: file-1234-aefd
        /// </summary>
        /// <example>file-1234-aefd</example>
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
        /// List of possible classification labels<br/>
        /// Example: [yes, no]
        /// </summary>
        /// <example>[yes, no]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_to_evaluate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelOrStringJsonConverter))]
        public global::Together.EvaluationModelOrString? ModelToEvaluate { get; set; }

        /// <summary>
        /// List of labels that are considered passing<br/>
        /// Example: [yes]
        /// </summary>
        /// <example>[yes]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PassLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationClassifyParameters" /> class.
        /// </summary>
        /// <param name="inputDataFilePath">
        /// Data file ID<br/>
        /// Example: file-1234-aefd
        /// </param>
        /// <param name="judge"></param>
        /// <param name="labels">
        /// List of possible classification labels<br/>
        /// Example: [yes, no]
        /// </param>
        /// <param name="modelToEvaluate"></param>
        /// <param name="passLabels">
        /// List of labels that are considered passing<br/>
        /// Example: [yes]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationClassifyParameters(
            string inputDataFilePath,
            global::Together.EvaluationJudgeModelConfig judge,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<string> passLabels,
            global::Together.EvaluationModelOrString? modelToEvaluate)
        {
            this.InputDataFilePath = inputDataFilePath ?? throw new global::System.ArgumentNullException(nameof(inputDataFilePath));
            this.Judge = judge ?? throw new global::System.ArgumentNullException(nameof(judge));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.PassLabels = passLabels ?? throw new global::System.ArgumentNullException(nameof(passLabels));
            this.ModelToEvaluate = modelToEvaluate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationClassifyParameters" /> class.
        /// </summary>
        public EvaluationClassifyParameters()
        {
        }
    }
}