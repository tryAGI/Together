
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlTrainingSample
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.RlLossInputs LossInputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.RlModelInput ModelInput { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSample" /> class.
        /// </summary>
        /// <param name="lossInputs"></param>
        /// <param name="modelInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSample(
            global::Together.RlLossInputs lossInputs,
            global::Together.RlModelInput modelInput)
        {
            this.LossInputs = lossInputs ?? throw new global::System.ArgumentNullException(nameof(lossInputs));
            this.ModelInput = modelInput ?? throw new global::System.ArgumentNullException(nameof(modelInput));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSample" /> class.
        /// </summary>
        public RlTrainingSample()
        {
        }
    }
}