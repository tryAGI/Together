
#nullable enable

namespace Together
{
    /// <summary>
    /// Optimizer configuration
    /// </summary>
    public sealed partial class RlOptimizerConfig
    {
        /// <summary>
        /// Use the Adam optimizer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adam")]
        public global::Together.RlAdamConfig? Adam { get; set; }

        /// <summary>
        /// Use the Muon optimizer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("muon")]
        public global::Together.RlMuonConfig? Muon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimizerConfig" /> class.
        /// </summary>
        /// <param name="adam">
        /// Use the Adam optimizer.
        /// </param>
        /// <param name="muon">
        /// Use the Muon optimizer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlOptimizerConfig(
            global::Together.RlAdamConfig? adam,
            global::Together.RlMuonConfig? muon)
        {
            this.Adam = adam;
            this.Muon = muon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimizerConfig" /> class.
        /// </summary>
        public RlOptimizerConfig()
        {
        }

    }
}