
#nullable enable

namespace Together
{
    /// <summary>
    /// Autoscaling configuration as key-value pairs. Example: {"metric": "QueueBacklogPerWorker", "target": "10"} to scale based on queue backlog
    /// </summary>
    public sealed partial class UpdateDeploymentRequestAutoscaling
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}