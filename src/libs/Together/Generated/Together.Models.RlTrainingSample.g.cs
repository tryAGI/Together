
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
        /// Per-token loss tensors keyed by name. Include `target_tokens` and the inputs required by the selected loss. Each tensor must declare `int64` or `float32`, be one-dimensional, and have the same length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_fn_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Together.RlTensorData> LossFnInputs { get; set; }

        /// <summary>
        /// Optional MoE per-token routing captured at sample time. Replayed on every training operation, so expert selection matches the one used at sample time. Must cover the whole sample, or all but its last token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routed_experts")]
        public global::Together.RlRoutedExperts? RoutedExperts { get; set; }

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
        /// <param name="lossFnInputs">
        /// Per-token loss tensors keyed by name. Include `target_tokens` and the inputs required by the selected loss. Each tensor must declare `int64` or `float32`, be one-dimensional, and have the same length.
        /// </param>
        /// <param name="routedExperts">
        /// Optional MoE per-token routing captured at sample time. Replayed on every training operation, so expert selection matches the one used at sample time. Must cover the whole sample, or all but its last token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSample(
            global::Together.RlModelInput modelInput,
            global::System.Collections.Generic.Dictionary<string, global::Together.RlTensorData> lossFnInputs,
            global::Together.RlRoutedExperts? routedExperts)
        {
            this.ModelInput = modelInput ?? throw new global::System.ArgumentNullException(nameof(modelInput));
            this.LossFnInputs = lossFnInputs ?? throw new global::System.ArgumentNullException(nameof(lossFnInputs));
            this.RoutedExperts = routedExperts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSample" /> class.
        /// </summary>
        public RlTrainingSample()
        {
        }

    }
}