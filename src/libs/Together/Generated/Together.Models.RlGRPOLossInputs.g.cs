
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlGRPOLossInputs
    {
        /// <summary>
        /// Per-token advantages for GRPO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advantages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossAdvantages Advantages { get; set; }

        /// <summary>
        /// Generator log probabilities for GRPO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generator_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossLogprobs GeneratorLogprobs { get; set; }

        /// <summary>
        /// Reference model log probabilities (required if beta &gt; 0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_logprobs")]
        public global::Together.RlLossLogprobs? ReferenceLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlGRPOLossInputs" /> class.
        /// </summary>
        /// <param name="advantages">
        /// Per-token advantages for GRPO
        /// </param>
        /// <param name="generatorLogprobs">
        /// Generator log probabilities for GRPO
        /// </param>
        /// <param name="referenceLogprobs">
        /// Reference model log probabilities (required if beta &gt; 0)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlGRPOLossInputs(
            global::Together.RlLossAdvantages advantages,
            global::Together.RlLossLogprobs generatorLogprobs,
            global::Together.RlLossLogprobs? referenceLogprobs)
        {
            this.Advantages = advantages ?? throw new global::System.ArgumentNullException(nameof(advantages));
            this.GeneratorLogprobs = generatorLogprobs ?? throw new global::System.ArgumentNullException(nameof(generatorLogprobs));
            this.ReferenceLogprobs = referenceLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlGRPOLossInputs" /> class.
        /// </summary>
        public RlGRPOLossInputs()
        {
        }
    }
}