
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationCompareParameters
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EvaluationJudgeModelConfig Judge { get; set; }

        /// <summary>
        /// Either an EvaluationModelRequest for generation or a string column name from the dataset (when responses are pre-generated). When both model_a and model_b are EvaluationModelRequest objects, their inference runs execute in parallel to reduce total wall-clock time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_a")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>))]
        public global::Together.OneOf<global::Together.EvaluationModelRequest, string>? ModelA { get; set; }

        /// <summary>
        /// Either an EvaluationModelRequest for generation or a string column name from the dataset (when responses are pre-generated). When both model_a and model_b are EvaluationModelRequest objects, their inference runs execute in parallel to reduce total wall-clock time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_b")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>))]
        public global::Together.OneOf<global::Together.EvaluationModelRequest, string>? ModelB { get; set; }

        /// <summary>
        /// Data file ID<br/>
        /// Example: file-01234567890123456789
        /// </summary>
        /// <example>file-01234567890123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_data_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputDataFilePath { get; set; }

        /// <summary>
        /// When false (default), the judge runs twice per sample: once with model A's response first (original order) and once with model B's response first (flipped order). The two verdicts are reconciled to cancel out position bias. When true, only the original-order pass is run, halving judge cost and latency at the expense of position-bias correction. The result file will not contain flipped-order judge fields when this is true.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_position_bias_correction")]
        public bool? DisablePositionBiasCorrection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCompareParameters" /> class.
        /// </summary>
        /// <param name="judge"></param>
        /// <param name="inputDataFilePath">
        /// Data file ID<br/>
        /// Example: file-01234567890123456789
        /// </param>
        /// <param name="modelA">
        /// Either an EvaluationModelRequest for generation or a string column name from the dataset (when responses are pre-generated). When both model_a and model_b are EvaluationModelRequest objects, their inference runs execute in parallel to reduce total wall-clock time.
        /// </param>
        /// <param name="modelB">
        /// Either an EvaluationModelRequest for generation or a string column name from the dataset (when responses are pre-generated). When both model_a and model_b are EvaluationModelRequest objects, their inference runs execute in parallel to reduce total wall-clock time.
        /// </param>
        /// <param name="disablePositionBiasCorrection">
        /// When false (default), the judge runs twice per sample: once with model A's response first (original order) and once with model B's response first (flipped order). The two verdicts are reconciled to cancel out position bias. When true, only the original-order pass is run, halving judge cost and latency at the expense of position-bias correction. The result file will not contain flipped-order judge fields when this is true.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCompareParameters(
            global::Together.EvaluationJudgeModelConfig judge,
            string inputDataFilePath,
            global::Together.OneOf<global::Together.EvaluationModelRequest, string>? modelA,
            global::Together.OneOf<global::Together.EvaluationModelRequest, string>? modelB,
            bool? disablePositionBiasCorrection)
        {
            this.Judge = judge ?? throw new global::System.ArgumentNullException(nameof(judge));
            this.ModelA = modelA;
            this.ModelB = modelB;
            this.InputDataFilePath = inputDataFilePath ?? throw new global::System.ArgumentNullException(nameof(inputDataFilePath));
            this.DisablePositionBiasCorrection = disablePositionBiasCorrection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCompareParameters" /> class.
        /// </summary>
        public EvaluationCompareParameters()
        {
        }

    }
}