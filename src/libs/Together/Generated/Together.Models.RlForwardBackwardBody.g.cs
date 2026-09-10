
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlForwardBackwardBody
    {
        /// <summary>
        /// Batch of training samples to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlTrainingSample> Samples { get; set; }

        /// <summary>
        /// Loss function configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossConfig Loss { get; set; }

        /// <summary>
        /// Return the loss function's per-sample output tensors alongside the loss and metrics. Defaults to false. Enabling it increases the response size substantially for large batches and reduces step throughput, so leave it unset for ordinary training steps.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_loss_fn_outputs")]
        public bool? ReturnLossFnOutputs { get; set; }

        /// <summary>
        /// Run the forward pass only: report the loss and metrics, and the per-sample outputs when requested, without accumulating gradients. Defaults to false. Pair it with `return_loss_fn_outputs` to score a batch and read back its per-token log-probabilities.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forward_only")]
        public bool? ForwardOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardBody" /> class.
        /// </summary>
        /// <param name="samples">
        /// Batch of training samples to process
        /// </param>
        /// <param name="loss">
        /// Loss function configuration
        /// </param>
        /// <param name="returnLossFnOutputs">
        /// Return the loss function's per-sample output tensors alongside the loss and metrics. Defaults to false. Enabling it increases the response size substantially for large batches and reduces step throughput, so leave it unset for ordinary training steps.<br/>
        /// Example: true
        /// </param>
        /// <param name="forwardOnly">
        /// Run the forward pass only: report the loss and metrics, and the per-sample outputs when requested, without accumulating gradients. Defaults to false. Pair it with `return_loss_fn_outputs` to score a batch and read back its per-token log-probabilities.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlForwardBackwardBody(
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::Together.RlLossConfig loss,
            bool? returnLossFnOutputs,
            bool? forwardOnly)
        {
            this.Samples = samples ?? throw new global::System.ArgumentNullException(nameof(samples));
            this.Loss = loss ?? throw new global::System.ArgumentNullException(nameof(loss));
            this.ReturnLossFnOutputs = returnLossFnOutputs;
            this.ForwardOnly = forwardOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardBody" /> class.
        /// </summary>
        public RlForwardBackwardBody()
        {
        }

    }
}