
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlCISPOLossParams
    {
        /// <summary>
        /// Lower absolute bound for the importance ratio; the clipped ratio is applied as a detached coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_low_threshold")]
        public float? ClipLowThreshold { get; set; }

        /// <summary>
        /// Upper absolute bound for the importance ratio; the clipped ratio is applied as a detached coefficient<br/>
        /// Default Value: 4.0<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_high_threshold")]
        public float? ClipHighThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCISPOLossParams" /> class.
        /// </summary>
        /// <param name="clipLowThreshold">
        /// Lower absolute bound for the importance ratio; the clipped ratio is applied as a detached coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0
        /// </param>
        /// <param name="clipHighThreshold">
        /// Upper absolute bound for the importance ratio; the clipped ratio is applied as a detached coefficient<br/>
        /// Default Value: 4.0<br/>
        /// Example: 4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlCISPOLossParams(
            float? clipLowThreshold,
            float? clipHighThreshold)
        {
            this.ClipLowThreshold = clipLowThreshold;
            this.ClipHighThreshold = clipHighThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCISPOLossParams" /> class.
        /// </summary>
        public RlCISPOLossParams()
        {
        }

    }
}