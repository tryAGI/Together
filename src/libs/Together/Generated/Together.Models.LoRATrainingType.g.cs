
#nullable enable

namespace Together
{
    /// <summary>
    /// LoRA training configuration for a fine-tuning job.
    /// </summary>
    public sealed partial class LoRATrainingType
    {
        /// <summary>
        /// Identifies this request as a LoRA fine-tune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.LoRATrainingTypeTypeJsonConverter))]
        public global::Together.LoRATrainingTypeType Type { get; set; }

        /// <summary>
        /// Rank of the LoRA adapter matrices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_r")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LoraR { get; set; }

        /// <summary>
        /// Scaling factor applied to the LoRA adapter weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_alpha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LoraAlpha { get; set; }

        /// <summary>
        /// Dropout probability applied to LoRA adapter inputs.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_dropout")]
        public double? LoraDropout { get; set; }

        /// <summary>
        /// Comma-separated LoRA target modules. Use `all-linear` for model defaults; MoE expert modules (`w_up`, `w_gate`, `w_down`) can be combined with attention modules on compatible models. Fine-tunes that target any expert module produce adapter-only output.<br/>
        /// Default Value: all-linear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_trainable_modules")]
        public string? LoraTrainableModules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRATrainingType" /> class.
        /// </summary>
        /// <param name="loraR">
        /// Rank of the LoRA adapter matrices.
        /// </param>
        /// <param name="loraAlpha">
        /// Scaling factor applied to the LoRA adapter weights.
        /// </param>
        /// <param name="type">
        /// Identifies this request as a LoRA fine-tune.
        /// </param>
        /// <param name="loraDropout">
        /// Dropout probability applied to LoRA adapter inputs.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="loraTrainableModules">
        /// Comma-separated LoRA target modules. Use `all-linear` for model defaults; MoE expert modules (`w_up`, `w_gate`, `w_down`) can be combined with attention modules on compatible models. Fine-tunes that target any expert module produce adapter-only output.<br/>
        /// Default Value: all-linear
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoRATrainingType(
            int loraR,
            int loraAlpha,
            global::Together.LoRATrainingTypeType type,
            double? loraDropout,
            string? loraTrainableModules)
        {
            this.Type = type;
            this.LoraR = loraR;
            this.LoraAlpha = loraAlpha;
            this.LoraDropout = loraDropout;
            this.LoraTrainableModules = loraTrainableModules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRATrainingType" /> class.
        /// </summary>
        public LoRATrainingType()
        {
        }

    }
}