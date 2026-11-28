
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationClassifyParameters
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
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::System.Collections.Generic.IList<string> PassLabels { get; set; }

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
        /// Initializes a new instance of the <see cref="EvaluationClassifyParameters" /> class.
        /// </summary>
        /// <param name="judge"></param>
        /// <param name="labels"></param>
        /// <param name="passLabels"></param>
        /// <param name="inputDataFilePath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationClassifyParameters(
            global::Together.EvaluationJudgeModelConfig judge,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<string> passLabels,
            string inputDataFilePath)
        {
            this.Judge = judge ?? throw new global::System.ArgumentNullException(nameof(judge));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.PassLabels = passLabels ?? throw new global::System.ArgumentNullException(nameof(passLabels));
            this.InputDataFilePath = inputDataFilePath ?? throw new global::System.ArgumentNullException(nameof(inputDataFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationClassifyParameters" /> class.
        /// </summary>
        public EvaluationClassifyParameters()
        {
        }

    }
}