
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for a custom forward-backward pass.
    /// </summary>
    public sealed partial class RlCustomForwardBackwardBody
    {
        /// <summary>
        /// Batch of training samples
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlTrainingSample> Samples { get; set; }

        /// <summary>
        /// Per-sample per-token gradients of the loss with respect to log-probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gradients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlTargetLogprobGradients> Gradients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCustomForwardBackwardBody" /> class.
        /// </summary>
        /// <param name="samples">
        /// Batch of training samples
        /// </param>
        /// <param name="gradients">
        /// Per-sample per-token gradients of the loss with respect to log-probabilities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlCustomForwardBackwardBody(
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::System.Collections.Generic.IList<global::Together.RlTargetLogprobGradients> gradients)
        {
            this.Samples = samples ?? throw new global::System.ArgumentNullException(nameof(samples));
            this.Gradients = gradients ?? throw new global::System.ArgumentNullException(nameof(gradients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCustomForwardBackwardBody" /> class.
        /// </summary>
        public RlCustomForwardBackwardBody()
        {
        }

    }
}