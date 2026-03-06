
#nullable enable

namespace Together
{
    /// <summary>
    /// Job metadata. Contains keys from the submit request, plus any<br/>
    /// modifications from the model or system (e.g. progress, retry<br/>
    /// history).
    /// </summary>
    public sealed partial class QueueJobStatusResponseInfo
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}