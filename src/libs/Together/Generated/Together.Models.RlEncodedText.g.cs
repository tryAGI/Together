
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlEncodedText
    {
        /// <summary>
        /// Pre-tokenized text input<br/>
        /// Example: [123, 456, 789]
        /// </summary>
        /// <example>[123, 456, 789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEncodedText" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Pre-tokenized text input<br/>
        /// Example: [123, 456, 789]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlEncodedText(
            global::System.Collections.Generic.IList<string>? tokens)
        {
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEncodedText" /> class.
        /// </summary>
        public RlEncodedText()
        {
        }
    }
}