
#nullable enable

namespace Together
{
    /// <summary>
    /// One NVIDIA Xid code observed during the alert window.
    /// </summary>
    public sealed partial class XidEvent
    {
        /// <summary>
        /// NVIDIA Xid code, such as `79`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("xid_code")]
        public string XidCode { get; set; } = default!;

        /// <summary>
        /// Driver mnemonic for the Xid code when metadata is available.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mnemonic")]
        public string Mnemonic { get; set; } = default!;

        /// <summary>
        /// Number of times this Xid code appeared in the alert window.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XidEvent" /> class.
        /// </summary>
        /// <param name="xidCode">
        /// NVIDIA Xid code, such as `79`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="mnemonic">
        /// Driver mnemonic for the Xid code when metadata is available.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="count">
        /// Number of times this Xid code appeared in the alert window.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XidEvent(
            string xidCode = default!,
            string mnemonic = default!,
            int count = default!)
        {
            this.XidCode = xidCode;
            this.Mnemonic = mnemonic;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XidEvent" /> class.
        /// </summary>
        public XidEvent()
        {
        }

    }
}