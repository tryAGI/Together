
#nullable enable

namespace Together
{
    /// <summary>
    /// Limits for LoRA training.
    /// </summary>
    public sealed partial class FineTuneModelLimitsLoraTraining
    {
        /// <summary>
        /// Maximum batch size for SFT LoRA training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MaxBatchSize { get; set; } = default!;

        /// <summary>
        /// Maximum batch size for DPO LoRA training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size_dpo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MaxBatchSizeDpo { get; set; } = default!;

        /// <summary>
        /// Maximum LoRA rank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MaxRank { get; set; } = default!;

        /// <summary>
        /// Minimum batch size for LoRA training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MinBatchSize { get; set; } = default!;

        /// <summary>
        /// Available target modules for LoRA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_modules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> TargetModules { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimitsLoraTraining" /> class.
        /// </summary>
        /// <param name="maxBatchSize">
        /// Maximum batch size for SFT LoRA training.
        /// </param>
        /// <param name="maxBatchSizeDpo">
        /// Maximum batch size for DPO LoRA training.
        /// </param>
        /// <param name="maxRank">
        /// Maximum LoRA rank.
        /// </param>
        /// <param name="minBatchSize">
        /// Minimum batch size for LoRA training.
        /// </param>
        /// <param name="targetModules">
        /// Available target modules for LoRA.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneModelLimitsLoraTraining(
            int maxBatchSize,
            int maxBatchSizeDpo,
            int maxRank,
            int minBatchSize,
            global::System.Collections.Generic.IList<string> targetModules)
        {
            this.MaxBatchSize = maxBatchSize;
            this.MaxBatchSizeDpo = maxBatchSizeDpo;
            this.MaxRank = maxRank;
            this.MinBatchSize = minBatchSize;
            this.TargetModules = targetModules ?? throw new global::System.ArgumentNullException(nameof(targetModules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimitsLoraTraining" /> class.
        /// </summary>
        public FineTuneModelLimitsLoraTraining()
        {
        }
    }
}