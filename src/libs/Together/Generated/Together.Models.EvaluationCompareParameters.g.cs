
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationCompareParameters
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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_a")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.OneOf<global::Together.EvaluationModelRequest, string>? ModelA { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_b")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.OneOf<global::Together.EvaluationModelRequest, string>? ModelB { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_data_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string InputDataFilePath { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_position_bias_correction")]
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// <param name="inputDataFilePath"></param>
        /// <param name="modelA"></param>
        /// <param name="modelB"></param>
        /// <param name="disablePositionBiasCorrection">
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