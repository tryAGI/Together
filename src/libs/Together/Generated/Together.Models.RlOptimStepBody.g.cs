
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for an optimizer step.
    /// </summary>
    public sealed partial class RlOptimStepBody
    {
        /// <summary>
        /// Adam optimizer overrides for this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adam_params")]
        public global::Together.RlAdamParams? AdamParams { get; set; }

        /// <summary>
        /// Muon optimizer overrides for this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("muon_params")]
        public global::Together.RlMuonParams? MuonParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimStepBody" /> class.
        /// </summary>
        /// <param name="adamParams">
        /// Adam optimizer overrides for this step.
        /// </param>
        /// <param name="muonParams">
        /// Muon optimizer overrides for this step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlOptimStepBody(
            global::Together.RlAdamParams? adamParams,
            global::Together.RlMuonParams? muonParams)
        {
            this.AdamParams = adamParams;
            this.MuonParams = muonParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimStepBody" /> class.
        /// </summary>
        public RlOptimStepBody()
        {
        }

    }
}