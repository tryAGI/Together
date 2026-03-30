
#nullable enable

namespace Together
{
    /// <summary>
    /// Completions generated for a single prompt
    /// </summary>
    public sealed partial class RlSampleRollout
    {
        /// <summary>
        /// Completions generated for one prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlSampleSequence> Sequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleRollout" /> class.
        /// </summary>
        /// <param name="sequences">
        /// Completions generated for one prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleRollout(
            global::System.Collections.Generic.IList<global::Together.RlSampleSequence> sequences)
        {
            this.Sequences = sequences ?? throw new global::System.ArgumentNullException(nameof(sequences));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleRollout" /> class.
        /// </summary>
        public RlSampleRollout()
        {
        }
    }
}