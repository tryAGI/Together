
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlTrainingSample
    {
        /// <summary>
        /// Model input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlModelInput ModelInput { get; set; }

        /// <summary>
        /// Loss function inputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossInputs LossInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSample" /> class.
        /// </summary>
        /// <param name="modelInput">
        /// Model input
        /// </param>
        /// <param name="lossInputs">
        /// Loss function inputs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSample(
            global::Together.RlModelInput modelInput,
            global::Together.RlLossInputs lossInputs)
        {
            this.ModelInput = modelInput ?? throw new global::System.ArgumentNullException(nameof(modelInput));
            this.LossInputs = lossInputs ?? throw new global::System.ArgumentNullException(nameof(lossInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSample" /> class.
        /// </summary>
        public RlTrainingSample()
        {
        }
    }
}