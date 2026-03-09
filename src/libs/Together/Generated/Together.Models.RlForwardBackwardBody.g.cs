
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlForwardBackwardBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.RlLossConfig Loss { get; set; } = default!;

        /// <summary>
        /// Batch of training samples to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Together.RlTrainingSample> Samples { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardBody" /> class.
        /// </summary>
        /// <param name="loss"></param>
        /// <param name="samples">
        /// Batch of training samples to process
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlForwardBackwardBody(
            global::Together.RlLossConfig loss,
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples)
        {
            this.Loss = loss ?? throw new global::System.ArgumentNullException(nameof(loss));
            this.Samples = samples ?? throw new global::System.ArgumentNullException(nameof(samples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardBody" /> class.
        /// </summary>
        public RlForwardBackwardBody()
        {
        }
    }
}