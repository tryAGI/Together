
#nullable enable

namespace Together
{
    /// <summary>
    /// Rolling strategy configuration for small batches that ramp target replicas up while shrinking source replicas to what their remaining traffic share needs.
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