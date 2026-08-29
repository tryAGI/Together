
#nullable enable

namespace Together
{
    /// <summary>
    /// Architecture, size, precision, and speculative-decoding metadata for model weights.
    /// </summary>
    public sealed partial class DeModelWeights
    {
        /// <summary>
        /// Role of the weights: full model, speculative draft model, or LoRA adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeModelWeightsTypeJsonConverter))]
        public global::Together.DeModelWeightsType? Type { get; set; }

        /// <summary>
        /// Speculative decoding mechanism for speculator weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculatorMechanism")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeModelWeightsSpeculatorMechanismJsonConverter))]
        public global::Together.DeModelWeightsSpeculatorMechanism? SpeculatorMechanism { get; set; }

        /// <summary>
        /// Draft-model speculator family for draft speculative decoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draftSpeculatorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeModelWeightsDraftSpeculatorTypeJsonConverter))]
        public global::Together.DeModelWeightsDraftSpeculatorType? DraftSpeculatorType { get; set; }

        /// <summary>
        /// Model architecture detected from the weight metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        /// Maximum context length reported by the model metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextLength")]
        public string? ContextLength { get; set; }

        /// <summary>
        /// Total parameter count and breakdown by numerical data type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::Together.DeModelParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelWeights" /> class.
        /// </summary>
        /// <param name="type">
        /// Role of the weights: full model, speculative draft model, or LoRA adapter.
        /// </param>
        /// <param name="speculatorMechanism">
        /// Speculative decoding mechanism for speculator weights.
        /// </param>
        /// <param name="draftSpeculatorType">
        /// Draft-model speculator family for draft speculative decoding.
        /// </param>
        /// <param name="architecture">
        /// Model architecture detected from the weight metadata.
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length reported by the model metadata.
        /// </param>
        /// <param name="parameters">
        /// Total parameter count and breakdown by numerical data type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeModelWeights(
            global::Together.DeModelWeightsType? type,
            global::Together.DeModelWeightsSpeculatorMechanism? speculatorMechanism,
            global::Together.DeModelWeightsDraftSpeculatorType? draftSpeculatorType,
            string? architecture,
            string? contextLength,
            global::Together.DeModelParameters? parameters)
        {
            this.Type = type;
            this.SpeculatorMechanism = speculatorMechanism;
            this.DraftSpeculatorType = draftSpeculatorType;
            this.Architecture = architecture;
            this.ContextLength = contextLength;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelWeights" /> class.
        /// </summary>
        public DeModelWeights()
        {
        }

    }
}