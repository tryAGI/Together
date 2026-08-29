
#nullable enable

namespace Together
{
    /// <summary>
    /// A single chunk of model input content.
    /// </summary>
    public sealed partial class RlModelInputChunk
    {
        /// <summary>
        /// Pre-tokenized text content for this input chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlEncodedTextChunk EncodedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelInputChunk" /> class.
        /// </summary>
        /// <param name="encodedText">
        /// Pre-tokenized text content for this input chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelInputChunk(
            global::Together.RlEncodedTextChunk encodedText)
        {
            this.EncodedText = encodedText ?? throw new global::System.ArgumentNullException(nameof(encodedText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelInputChunk" /> class.
        /// </summary>
        public RlModelInputChunk()
        {
        }

    }
}