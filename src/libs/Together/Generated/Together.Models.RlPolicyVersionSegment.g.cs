
#nullable enable

namespace Together
{
    /// <summary>
    /// A (policy version, starting token) span within a sampled sequence. Version 0 is the initial model; each optim_step call increments the version by 1.
    /// </summary>
    public sealed partial class RlPolicyVersionSegment
    {
        /// <summary>
        /// Model version under which this segment of tokens was generated<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Index of the first token of this segment within the sampled sequence. Always 0 for the first segment.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlPolicyVersionSegment" /> class.
        /// </summary>
        /// <param name="version">
        /// Model version under which this segment of tokens was generated<br/>
        /// Example: 5
        /// </param>
        /// <param name="startToken">
        /// Index of the first token of this segment within the sampled sequence. Always 0 for the first segment.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlPolicyVersionSegment(
            int version,
            int startToken)
        {
            this.Version = version;
            this.StartToken = startToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlPolicyVersionSegment" /> class.
        /// </summary>
        public RlPolicyVersionSegment()
        {
        }

    }
}