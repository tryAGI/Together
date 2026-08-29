
#nullable enable

namespace Together
{
    /// <summary>
    /// Model limits for fine-tuning.
    /// </summary>
    public sealed partial class FineTuneModelLimits
    {
        /// <summary>
        /// The name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Limits for full training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_training")]
        public global::Together.FineTuneModelLimitsFullTraining? FullTraining { get; set; }

        /// <summary>
        /// Limits for LoRA training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_training")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FineTuneModelLimitsLoraTraining LoraTraining { get; set; }

        /// <summary>
        /// Maximum number of training epochs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_epochs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxNumEpochs { get; set; }

        /// <summary>
        /// Maximum number of evaluations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_evals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxNumEvals { get; set; }

        /// <summary>
        /// Maximum learning rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_learning_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxLearningRate { get; set; }

        /// <summary>
        /// Minimum learning rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_learning_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinLearningRate { get; set; }

        /// <summary>
        /// Whether the model supports full (non-LoRA) fine-tuning. When false, only LoRA fine-tuning is available and the full_training limits are reported as zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_full_training")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsFullTraining { get; set; }

        /// <summary>
        /// Whether the model supports vision/multimodal inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_vision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsVision { get; set; }

        /// <summary>
        /// Whether the model supports tool/function calling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsTools { get; set; }

        /// <summary>
        /// Whether the model supports reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsReasoning { get; set; }

        /// <summary>
        /// Whether a merged checkpoint (the base model with the trained LoRA adapter fused in) is produced for LoRA fine-tunes of this model, in addition to the standalone adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_output_lora")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MergeOutputLora { get; set; }

        /// <summary>
        /// Default gradient accumulation steps used when a fine-tune request omits the value or sets it to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gradient_accumulation_steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DefaultGradientAccumulationSteps { get; set; }

        /// <summary>
        /// Maximum number of checkpoints that can be saved during a fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_checkpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxNumCheckpoints { get; set; }

        /// <summary>
        /// Minimum value allowed for the max_seq_length hyperparameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_max_seq_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinMaxSeqLength { get; set; }

        /// <summary>
        /// Maximum sequence length supported for SFT training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_length_sft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSeqLengthSft { get; set; }

        /// <summary>
        /// Maximum sequence length supported for DPO training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_length_dpo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSeqLengthDpo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimits" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model.
        /// </param>
        /// <param name="loraTraining">
        /// Limits for LoRA training.
        /// </param>
        /// <param name="maxNumEpochs">
        /// Maximum number of training epochs.
        /// </param>
        /// <param name="maxNumEvals">
        /// Maximum number of evaluations.
        /// </param>
        /// <param name="maxLearningRate">
        /// Maximum learning rate.
        /// </param>
        /// <param name="minLearningRate">
        /// Minimum learning rate.
        /// </param>
        /// <param name="supportsFullTraining">
        /// Whether the model supports full (non-LoRA) fine-tuning. When false, only LoRA fine-tuning is available and the full_training limits are reported as zero.
        /// </param>
        /// <param name="supportsVision">
        /// Whether the model supports vision/multimodal inputs.
        /// </param>
        /// <param name="supportsTools">
        /// Whether the model supports tool/function calling.
        /// </param>
        /// <param name="supportsReasoning">
        /// Whether the model supports reasoning.
        /// </param>
        /// <param name="mergeOutputLora">
        /// Whether a merged checkpoint (the base model with the trained LoRA adapter fused in) is produced for LoRA fine-tunes of this model, in addition to the standalone adapter.
        /// </param>
        /// <param name="defaultGradientAccumulationSteps">
        /// Default gradient accumulation steps used when a fine-tune request omits the value or sets it to 0.
        /// </param>
        /// <param name="maxNumCheckpoints">
        /// Maximum number of checkpoints that can be saved during a fine-tuning job.
        /// </param>
        /// <param name="minMaxSeqLength">
        /// Minimum value allowed for the max_seq_length hyperparameter.
        /// </param>
        /// <param name="maxSeqLengthSft">
        /// Maximum sequence length supported for SFT training.
        /// </param>
        /// <param name="maxSeqLengthDpo">
        /// Maximum sequence length supported for DPO training.
        /// </param>
        /// <param name="fullTraining">
        /// Limits for full training.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneModelLimits(
            string modelName,
            global::Together.FineTuneModelLimitsLoraTraining loraTraining,
            int maxNumEpochs,
            int maxNumEvals,
            double maxLearningRate,
            double minLearningRate,
            bool supportsFullTraining,
            bool supportsVision,
            bool supportsTools,
            bool supportsReasoning,
            bool mergeOutputLora,
            int defaultGradientAccumulationSteps,
            int maxNumCheckpoints,
            int minMaxSeqLength,
            int maxSeqLengthSft,
            int maxSeqLengthDpo,
            global::Together.FineTuneModelLimitsFullTraining? fullTraining)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.FullTraining = fullTraining;
            this.LoraTraining = loraTraining ?? throw new global::System.ArgumentNullException(nameof(loraTraining));
            this.MaxNumEpochs = maxNumEpochs;
            this.MaxNumEvals = maxNumEvals;
            this.MaxLearningRate = maxLearningRate;
            this.MinLearningRate = minLearningRate;
            this.SupportsFullTraining = supportsFullTraining;
            this.SupportsVision = supportsVision;
            this.SupportsTools = supportsTools;
            this.SupportsReasoning = supportsReasoning;
            this.MergeOutputLora = mergeOutputLora;
            this.DefaultGradientAccumulationSteps = defaultGradientAccumulationSteps;
            this.MaxNumCheckpoints = maxNumCheckpoints;
            this.MinMaxSeqLength = minMaxSeqLength;
            this.MaxSeqLengthSft = maxSeqLengthSft;
            this.MaxSeqLengthDpo = maxSeqLengthDpo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimits" /> class.
        /// </summary>
        public FineTuneModelLimits()
        {
        }

    }
}