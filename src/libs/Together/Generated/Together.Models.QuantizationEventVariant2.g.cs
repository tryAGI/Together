
#nullable enable

namespace Together
{
    /// <summary>
    /// Event emitted by a quantization job.
    /// </summary>
    public sealed partial class QuantizationEventVariant2
    {
        /// <summary>
        /// Quantization event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.QuantizationEventVariant2TypeJsonConverter))]
        public global::Together.QuantizationEventVariant2Type? Type { get; set; }

        /// <summary>
        /// Result attached to completion events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Together.QuantizationResults? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Quantization event type.
        /// </param>
        /// <param name="result">
        /// Result attached to completion events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationEventVariant2(
            global::Together.QuantizationEventVariant2Type? type,
            global::Together.QuantizationResults? result)
        {
            this.Type = type;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationEventVariant2" /> class.
        /// </summary>
        public QuantizationEventVariant2()
        {
        }

    }
}