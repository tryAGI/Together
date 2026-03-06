
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlSampleResult
    {
        /// <summary>
        /// Generated completions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequences")]
        public global::System.Collections.Generic.IList<global::Together.RlSampleSequence>? Sequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleResult" /> class.
        /// </summary>
        /// <param name="sequences">
        /// Generated completions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleResult(
            global::System.Collections.Generic.IList<global::Together.RlSampleSequence>? sequences)
        {
            this.Sequences = sequences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleResult" /> class.
        /// </summary>
        public RlSampleResult()
        {
        }
    }
}