
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlLossInputs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grpo_inputs")]
        public global::Together.RlGRPOLossInputs? GrpoInputs { get; set; }

        /// <summary>
        /// Per-token loss mask (1=compute loss, 0=ignore)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_mask")]
        public global::Together.RlLossMask? LossMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_tokens")]
        public global::Together.RlLossTargetTokens? TargetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossInputs" /> class.
        /// </summary>
        /// <param name="grpoInputs"></param>
        /// <param name="lossMask">
        /// Per-token loss mask (1=compute loss, 0=ignore)
        /// </param>
        /// <param name="targetTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossInputs(
            global::Together.RlGRPOLossInputs? grpoInputs,
            global::Together.RlLossMask? lossMask,
            global::Together.RlLossTargetTokens? targetTokens)
        {
            this.GrpoInputs = grpoInputs;
            this.LossMask = lossMask;
            this.TargetTokens = targetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossInputs" /> class.
        /// </summary>
        public RlLossInputs()
        {
        }
    }
}