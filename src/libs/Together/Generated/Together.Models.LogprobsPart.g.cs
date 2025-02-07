
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogprobsPart
    {
        /// <summary>
        /// List of token IDs corresponding to the logprobs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_ids")]
        public global::System.Collections.Generic.IList<double>? TokenIds { get; set; }

        /// <summary>
        /// List of token log probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_logprobs")]
        public global::System.Collections.Generic.IList<double>? TokenLogprobs { get; set; }

        /// <summary>
        /// List of token strings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsPart" /> class.
        /// </summary>
        /// <param name="tokenIds">
        /// List of token IDs corresponding to the logprobs
        /// </param>
        /// <param name="tokenLogprobs">
        /// List of token log probabilities
        /// </param>
        /// <param name="tokens">
        /// List of token strings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogprobsPart(
            global::System.Collections.Generic.IList<double>? tokenIds,
            global::System.Collections.Generic.IList<double>? tokenLogprobs,
            global::System.Collections.Generic.IList<string>? tokens)
        {
            this.TokenIds = tokenIds;
            this.TokenLogprobs = tokenLogprobs;
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsPart" /> class.
        /// </summary>
        public LogprobsPart()
        {
        }
    }
}