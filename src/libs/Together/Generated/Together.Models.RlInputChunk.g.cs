
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlInputChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded_text")]
        public global::Together.RlEncodedText? EncodedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInputChunk" /> class.
        /// </summary>
        /// <param name="encodedText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlInputChunk(
            global::Together.RlEncodedText? encodedText)
        {
            this.EncodedText = encodedText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInputChunk" /> class.
        /// </summary>
        public RlInputChunk()
        {
        }
    }
}