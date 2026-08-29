
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlPPOLossParams
    {
        /// <summary>
        /// Lower absolute bound for the importance ratio in the clipped surrogate. Must be &lt;= 1.<br/>
        /// Default Value: 0.8<br/>
        /// Example: 0.8
        /// </summary>
        /// <example>0.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_low_threshold")]
        public float? ClipLowThreshold { get; set; }

        /// <summary>
        /// Upper absolute bound for the importance ratio in the clipped surrogate. Must be &gt;= 1.<br/>
        /// Default Value: 1.2<br/>
        /// Example: 1.2
        /// </summary>
        /// <example>1.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_high_threshold")]
        public float? ClipHighThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlPPOLossParams" /> class.
        /// </summary>
        /// <param name="clipLowThreshold">
        /// Lower absolute bound for the importance ratio in the clipped surrogate. Must be &lt;= 1.<br/>
        /// Default Value: 0.8<br/>
        /// Example: 0.8
        /// </param>
        /// <param name="clipHighThreshold">
        /// Upper absolute bound for the importance ratio in the clipped surrogate. Must be &gt;= 1.<br/>
        /// Default Value: 1.2<br/>
        /// Example: 1.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlPPOLossParams(
            float? clipLowThreshold,
            float? clipHighThreshold)
        {
            this.ClipLowThreshold = clipLowThreshold;
            this.ClipHighThreshold = clipHighThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlPPOLossParams" /> class.
        /// </summary>
        public RlPPOLossParams()
        {
        }

    }
}