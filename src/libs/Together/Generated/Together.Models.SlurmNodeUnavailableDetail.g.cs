
#nullable enable

namespace Together
{
    /// <summary>
    /// Details for a Slurm node unavailable passive health check alert.
    /// </summary>
    public sealed partial class SlurmNodeUnavailableDetail
    {
        /// <summary>
        /// Drain reason reported for the unavailable Slurm node.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlurmNodeUnavailableDetail" /> class.
        /// </summary>
        /// <param name="reason">
        /// Drain reason reported for the unavailable Slurm node.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlurmNodeUnavailableDetail(
            string reason = default!)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlurmNodeUnavailableDetail" /> class.
        /// </summary>
        public SlurmNodeUnavailableDetail()
        {
        }

    }
}