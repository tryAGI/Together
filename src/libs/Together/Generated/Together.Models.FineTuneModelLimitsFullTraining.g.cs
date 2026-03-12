
#nullable enable

namespace Together
{
    /// <summary>
    /// Limits for full training.
    /// </summary>
    public sealed partial class FineTuneModelLimitsFullTraining
    {
        /// <summary>
        /// Maximum batch size for SFT full training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBatchSize { get; set; }

        /// <summary>
        /// Maximum batch size for DPO full training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size_dpo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBatchSizeDpo { get; set; }

        /// <summary>
        /// Minimum batch size for full training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinBatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimitsFullTraining" /> class.
        /// </summary>
        /// <param name="maxBatchSize">
        /// Maximum batch size for SFT full training.
        /// </param>
        /// <param name="maxBatchSizeDpo">
        /// Maximum batch size for DPO full training.
        /// </param>
        /// <param name="minBatchSize">
        /// Minimum batch size for full training.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneModelLimitsFullTraining(
            int maxBatchSize,
            int maxBatchSizeDpo,
            int minBatchSize)
        {
            this.MaxBatchSize = maxBatchSize;
            this.MaxBatchSizeDpo = maxBatchSizeDpo;
            this.MinBatchSize = minBatchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimitsFullTraining" /> class.
        /// </summary>
        public FineTuneModelLimitsFullTraining()
        {
        }
    }
}