
#nullable enable

namespace Together
{
    /// <summary>
    /// Training config. Each sub-mode is present only when the model supports that training mode.
    /// </summary>
    public sealed partial class RlModelTrainerConfig
    {
        /// <summary>
        /// Full-weight training config. Set when the model supports full-weight training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full")]
        public global::Together.RlModelFullModeConfig? Full { get; set; }

        /// <summary>
        /// LoRA training config. Set when the model supports LoRA training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora")]
        public global::Together.RlModelLoraModeConfig? Lora { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelTrainerConfig" /> class.
        /// </summary>
        /// <param name="full">
        /// Full-weight training config. Set when the model supports full-weight training.
        /// </param>
        /// <param name="lora">
        /// LoRA training config. Set when the model supports LoRA training.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelTrainerConfig(
            global::Together.RlModelFullModeConfig? full,
            global::Together.RlModelLoraModeConfig? lora)
        {
            this.Full = full;
            this.Lora = lora;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelTrainerConfig" /> class.
        /// </summary>
        public RlModelTrainerConfig()
        {
        }

    }
}