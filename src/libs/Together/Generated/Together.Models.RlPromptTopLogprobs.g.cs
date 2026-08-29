
#nullable enable

namespace Together
{
    /// <summary>
    /// The most likely alternative tokens at a single prompt position, as two parallel arrays of equal length. Both are empty for a position with no conditioning context, such as position 0.
    /// </summary>
    public sealed partial class RlPromptTopLogprobs
    {
        /// <summary>
        /// Token IDs of the alternatives, ordered by descending log-probability.<br/>
        /// Example: [123, 456]
        /// </summary>
        /// <example>[123, 456]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_ids")]
        public global::System.Collections.Generic.IList<int>? TokenIds { get; set; }

        /// <summary>
        /// Log-probability of each alternative in `token_ids`, at the same index.<br/>
        /// Example: [-0.5, -2.1]
        /// </summary>
        /// <example>[-0.5, -2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<double>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlPromptTopLogprobs" /> class.
        /// </summary>
        /// <param name="tokenIds">
        /// Token IDs of the alternatives, ordered by descending log-probability.<br/>
        /// Example: [123, 456]
        /// </param>
        /// <param name="logprobs">
        /// Log-probability of each alternative in `token_ids`, at the same index.<br/>
        /// Example: [-0.5, -2.1]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlPromptTopLogprobs(
            global::System.Collections.Generic.IList<int>? tokenIds,
            global::System.Collections.Generic.IList<double>? logprobs)
        {
            this.TokenIds = tokenIds;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlPromptTopLogprobs" /> class.
        /// </summary>
        public RlPromptTopLogprobs()
        {
        }

    }
}