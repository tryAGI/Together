
#nullable enable

namespace Together
{
    /// <summary>
    /// Rolling strategy configuration for capacity-preserving batches that ramp target replicas up while draining source replicas.
    /// </summary>
    public sealed partial class DeRollingConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}