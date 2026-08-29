
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for a forward pass.
    /// </summary>
    public sealed partial class RlForwardBody
    {
        /// <summary>
        /// Batch of training samples for which to compute per-token log-probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlTrainingSample> Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBody" /> class.
        /// </summary>
        /// <param name="samples">
        /// Batch of training samples for which to compute per-token log-probabilities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlForwardBody(
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples)
        {
            this.Samples = samples ?? throw new global::System.ArgumentNullException(nameof(samples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBody" /> class.
        /// </summary>
        public RlForwardBody()
        {
        }

    }
}