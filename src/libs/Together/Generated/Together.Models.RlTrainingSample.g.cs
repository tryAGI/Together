
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
        /// Opaque key returned with a sampled sequence. Pass it unchanged with the corresponding training sample to reuse the same expert selections. The selections must cover the entire training sample or all but its final token. Training fails if the key is no longer available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routed_experts_key")]
        public string? RoutedExpertsKey { get; set; }

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
        /// <param name="routedExpertsKey">
        /// Opaque key returned with a sampled sequence. Pass it unchanged with the corresponding training sample to reuse the same expert selections. The selections must cover the entire training sample or all but its final token. Training fails if the key is no longer available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSample(
            global::Together.RlModelInput modelInput,
            global::System.Collections.Generic.Dictionary<string, global::Together.RlTensorData> lossFnInputs,
            string? routedExpertsKey)
        {
            this.ModelInput = modelInput ?? throw new global::System.ArgumentNullException(nameof(modelInput));
            this.LossFnInputs = lossFnInputs ?? throw new global::System.ArgumentNullException(nameof(lossFnInputs));
            this.RoutedExpertsKey = routedExpertsKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSample" /> class.
        /// </summary>
        public RlTrainingSample()
        {
        }

    }
}