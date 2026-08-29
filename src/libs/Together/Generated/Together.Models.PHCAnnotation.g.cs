
#nullable enable

namespace Together
{
    /// <summary>
    /// Typed content parsed from passive health check alert annotations.
    /// </summary>
    public sealed partial class PHCAnnotation
    {
        /// <summary>
        /// Alert title from the Alertmanager summary annotation.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Static explanation for the alert.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Per-firing summary line parsed from the evidence annotation.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_line")]
        public string SummaryLine { get; set; } = default!;

        /// <summary>
        /// Xid-specific details when the alert was caused by NVIDIA Xid errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xid")]
        public global::Together.XidDetail? Xid { get; set; }

        /// <summary>
        /// Slurm node details when the alert was caused by unavailable Slurm nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_node_unavailable")]
        public global::Together.SlurmNodeUnavailableDetail? SlurmNodeUnavailable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PHCAnnotation" /> class.
        /// </summary>
        /// <param name="xid">
        /// Xid-specific details when the alert was caused by NVIDIA Xid errors.
        /// </param>
        /// <param name="slurmNodeUnavailable">
        /// Slurm node details when the alert was caused by unavailable Slurm nodes.
        /// </param>
        /// <param name="title">
        /// Alert title from the Alertmanager summary annotation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Static explanation for the alert.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="summaryLine">
        /// Per-firing summary line parsed from the evidence annotation.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PHCAnnotation(
            global::Together.XidDetail? xid,
            global::Together.SlurmNodeUnavailableDetail? slurmNodeUnavailable,
            string title = default!,
            string description = default!,
            string summaryLine = default!)
        {
            this.Title = title;
            this.Description = description;
            this.SummaryLine = summaryLine;
            this.Xid = xid;
            this.SlurmNodeUnavailable = slurmNodeUnavailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PHCAnnotation" /> class.
        /// </summary>
        public PHCAnnotation()
        {
        }

    }
}