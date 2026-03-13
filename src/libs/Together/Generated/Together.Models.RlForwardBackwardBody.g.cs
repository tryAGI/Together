
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlForwardBackwardBody(
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::Together.RlLossConfig loss)
        {
            this.Samples = samples ?? throw new global::System.ArgumentNullException(nameof(samples));
            this.Loss = loss ?? throw new global::System.ArgumentNullException(nameof(loss));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardBody" /> class.
        /// </summary>
        public RlForwardBackwardBody()
        {
        }
    }
}