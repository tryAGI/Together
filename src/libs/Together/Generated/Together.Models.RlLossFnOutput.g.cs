
#nullable enable

namespace Together
{
    /// <summary>
    /// Output tensors produced by the loss function for one sample.
    /// </summary>
    public sealed partial class RlLossFnOutput
    {
        /// <summary>
        /// Output tensors keyed by name. Built-in losses return `logprobs`: the model's float32 per-token log-probabilities under the current policy, one value per token of the sample's input. Values at positions excluded from the loss are unspecified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tensors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Together.RlTensorData> Tensors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossFnOutput" /> class.
        /// </summary>
        /// <param name="tensors">
        /// Output tensors keyed by name. Built-in losses return `logprobs`: the model's float32 per-token log-probabilities under the current policy, one value per token of the sample's input. Values at positions excluded from the loss are unspecified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossFnOutput(
            global::System.Collections.Generic.Dictionary<string, global::Together.RlTensorData> tensors)
        {
            this.Tensors = tensors ?? throw new global::System.ArgumentNullException(nameof(tensors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossFnOutput" /> class.
        /// </summary>
        public RlLossFnOutput()
        {
        }

    }
}