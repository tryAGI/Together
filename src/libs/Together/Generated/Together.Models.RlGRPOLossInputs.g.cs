
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlGRPOLossInputs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advantages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossAdvantages Advantages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generator_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossLogprobs GeneratorLogprobs { get; set; }

        /// <summary>
        /// 
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
        /// <param name="advantages"></param>
        /// <param name="generatorLogprobs"></param>
        /// <param name="referenceLogprobs"></param>
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