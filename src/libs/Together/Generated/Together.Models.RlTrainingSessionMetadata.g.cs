
#nullable enable

namespace Together
{
    /// <summary>
    /// Auxiliary metadata associated with a training session
    /// </summary>
    public sealed partial class RlTrainingSessionMetadata
    {
        /// <summary>
        /// Weights &amp; Biases details associated with the training session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb")]
        public global::Together.RlWandbMetadata? Wandb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSessionMetadata" /> class.
        /// </summary>
        /// <param name="wandb">
        /// Weights &amp; Biases details associated with the training session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSessionMetadata(
            global::Together.RlWandbMetadata? wandb)
        {
            this.Wandb = wandb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSessionMetadata" /> class.
        /// </summary>
        public RlTrainingSessionMetadata()
        {
        }

    }
}