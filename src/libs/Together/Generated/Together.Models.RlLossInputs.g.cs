
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlLossInputs
    {
        /// <summary>
        /// Target tokens for loss computation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossTargetTokens TargetTokens { get; set; }

        /// <summary>
        /// Per-token loss mask (1=compute loss, 0=ignore)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_mask")]
        public global::Together.RlLossMask? LossMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grpo_inputs")]
        public global::Together.RlGRPOLossInputs? GrpoInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossInputs" /> class.
        /// </summary>
        /// <param name="targetTokens">
        /// Target tokens for loss computation
        /// </param>
        /// <param name="lossMask">
        /// Per-token loss mask (1=compute loss, 0=ignore)
        /// </param>
        /// <param name="grpoInputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossInputs(
            global::Together.RlLossTargetTokens targetTokens,
            global::Together.RlLossMask? lossMask,
            global::Together.RlGRPOLossInputs? grpoInputs)
        {
            this.TargetTokens = targetTokens ?? throw new global::System.ArgumentNullException(nameof(targetTokens));
            this.LossMask = lossMask;
            this.GrpoInputs = grpoInputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossInputs" /> class.
        /// </summary>
        public RlLossInputs()
        {
        }
    }
}