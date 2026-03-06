
#nullable enable

namespace Together
{
    /// <summary>
    /// Arbitrary JSON metadata stored with the job and returned in status<br/>
    /// responses. The model and system may add or update keys during<br/>
    /// processing.
    /// </summary>
    public sealed partial class QueueJobRequestInfo
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}