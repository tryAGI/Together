
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoRATrainingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.LoRATrainingTypeTypeJsonConverter))]
        public global::Together.LoRATrainingTypeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_r")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LoraR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_alpha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LoraAlpha { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_dropout")]
        public float? LoraDropout { get; set; } = 0F;

        /// <summary>
        /// Default Value: all-linear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_trainable_modules")]
        public string? LoraTrainableModules { get; set; } = "all-linear";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}