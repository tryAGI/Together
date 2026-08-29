
#nullable enable

namespace Together
{
    /// <summary>
    /// Pre-tokenized text content for a model input chunk.
    /// </summary>
    public sealed partial class RlEncodedTextChunk
    {
        /// <summary>
        /// Pre-tokenized text input<br/>
        /// Example: [123, 456, 789]
        /// </summary>
        /// <example>[123, 456, 789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEncodedTextChunk" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Pre-tokenized text input<br/>
        /// Example: [123, 456, 789]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlEncodedTextChunk(
            global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> tokens)
        {
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEncodedTextChunk" /> class.
        /// </summary>
        public RlEncodedTextChunk()
        {
        }

    }
}