
#nullable enable

namespace Together
{
    /// <summary>
    /// Model limits for fine-tuning.
    /// </summary>
    public sealed partial class FineTuneModelLimits
    {
        /// <summary>
        /// Limits for full training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_training")]
        public global::Together.FineTuneModelLimitsFullTraining? FullTraining { get; set; }

        /// <summary>
        /// Limits for LoRA training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_training")]
        public global::Together.FineTuneModelLimitsLoraTraining? LoraTraining { get; set; }

        /// <summary>
        /// Maximum learning rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_learning_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxLearningRate { get; set; }

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
        /// Whether to merge the output LoRA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_output_lora")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MergeOutputLora { get; set; }

        /// <summary>
        /// Minimum learning rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_learning_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinLearningRate { get; set; }

        /// <summary>
        /// The name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Whether the model supports reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsReasoning { get; set; }

        /// <summary>
        /// Whether the model supports tool/function calling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsTools { get; set; }

        /// <summary>
        /// Whether the model supports vision/multimodal inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_vision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsVision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimits" /> class.
        /// </summary>
        /// <param name="fullTraining">
        /// Limits for full training.
        /// </param>
        /// <param name="loraTraining">
        /// Limits for LoRA training.
        /// </param>
        /// <param name="maxLearningRate">
        /// Maximum learning rate.
        /// </param>
        /// <param name="maxNumEpochs">
        /// Maximum number of training epochs.
        /// </param>
        /// <param name="maxNumEvals">
        /// Maximum number of evaluations.
        /// </param>
        /// <param name="mergeOutputLora">
        /// Whether to merge the output LoRA.
        /// </param>
        /// <param name="minLearningRate">
        /// Minimum learning rate.
        /// </param>
        /// <param name="modelName">
        /// The name of the model.
        /// </param>
        /// <param name="supportsReasoning">
        /// Whether the model supports reasoning.
        /// </param>
        /// <param name="supportsTools">
        /// Whether the model supports tool/function calling.
        /// </param>
        /// <param name="supportsVision">
        /// Whether the model supports vision/multimodal inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneModelLimits(
            double maxLearningRate,
            int maxNumEpochs,
            int maxNumEvals,
            bool mergeOutputLora,
            double minLearningRate,
            string modelName,
            bool supportsReasoning,
            bool supportsTools,
            bool supportsVision,
            global::Together.FineTuneModelLimitsFullTraining? fullTraining,
            global::Together.FineTuneModelLimitsLoraTraining? loraTraining)
        {
            this.MaxLearningRate = maxLearningRate;
            this.MaxNumEpochs = maxNumEpochs;
            this.MaxNumEvals = maxNumEvals;
            this.MergeOutputLora = mergeOutputLora;
            this.MinLearningRate = minLearningRate;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.SupportsReasoning = supportsReasoning;
            this.SupportsTools = supportsTools;
            this.SupportsVision = supportsVision;
            this.FullTraining = fullTraining;
            this.LoraTraining = loraTraining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneModelLimits" /> class.
        /// </summary>
        public FineTuneModelLimits()
        {
        }
    }
}