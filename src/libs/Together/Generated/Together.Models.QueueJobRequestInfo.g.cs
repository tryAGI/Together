
#nullable enable

namespace Together
{
    /// <summary>
    /// Arbitrary JSON metadata stored with the job. Returned in status<br/>
    /// responses, where the model and system may have added or modified<br/>
    /// keys (e.g. progress).
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