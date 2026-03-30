
#nullable enable

namespace Together
{
    /// <summary>
    /// Result of a sample operation
    /// </summary>
    public sealed partial class RlSampleResult
    {
        /// <summary>
        /// Completions grouped by prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlSampleRollout> Rollouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleResult" /> class.
        /// </summary>
        /// <param name="rollouts">
        /// Completions grouped by prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleResult(
            global::System.Collections.Generic.IList<global::Together.RlSampleRollout> rollouts)
        {
            this.Rollouts = rollouts ?? throw new global::System.ArgumentNullException(nameof(rollouts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleResult" /> class.
        /// </summary>
        public RlSampleResult()
        {
        }
    }
}