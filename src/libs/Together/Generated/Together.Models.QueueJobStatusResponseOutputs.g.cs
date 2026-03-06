
#nullable enable

namespace Together
{
    /// <summary>
    /// Freeform model output, populated when the job reaches done status. Contents are model-specific.
    /// </summary>
    public sealed partial class QueueJobStatusResponseOutputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}