
#nullable enable

namespace Together
{
    /// <summary>
    /// Progress information for a fine-tuning job
    /// </summary>
    public sealed partial class FineTuneProgress
    {
        /// <summary>
        /// Whether time estimate is available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimate_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EstimateAvailable { get; set; }

        /// <summary>
        /// Estimated time remaining in seconds for the fine-tuning job to next state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds_remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SecondsRemaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneProgress" /> class.
        /// </summary>
        /// <param name="estimateAvailable">
        /// Whether time estimate is available
        /// </param>
        /// <param name="secondsRemaining">
        /// Estimated time remaining in seconds for the fine-tuning job to next state
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneProgress(
            bool estimateAvailable,
            int secondsRemaining)
        {
            this.EstimateAvailable = estimateAvailable;
            this.SecondsRemaining = secondsRemaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneProgress" /> class.
        /// </summary>
        public FineTuneProgress()
        {
        }
    }
}