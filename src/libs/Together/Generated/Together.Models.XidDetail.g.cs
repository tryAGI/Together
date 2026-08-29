
#nullable enable

namespace Together
{
    /// <summary>
    /// Details for a DmesgXidError passive health check alert.
    /// </summary>
    public sealed partial class XidDetail
    {
        /// <summary>
        /// Xid events observed during the alert window.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Together.XidEvent> Events { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XidDetail" /> class.
        /// </summary>
        /// <param name="events">
        /// Xid events observed during the alert window.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XidDetail(
            global::System.Collections.Generic.IList<global::Together.XidEvent> events = default!)
        {
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XidDetail" /> class.
        /// </summary>
        public XidDetail()
        {
        }

    }
}