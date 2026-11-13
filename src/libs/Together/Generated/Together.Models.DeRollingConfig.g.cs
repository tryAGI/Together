
#nullable enable

namespace Together
{
    /// <summary>
    /// Rolling strategy configuration. The target ramps up one replica per rung while the source shrinks to what its remaining traffic share needs.
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