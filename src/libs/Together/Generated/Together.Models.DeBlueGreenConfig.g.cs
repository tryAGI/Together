
#nullable enable

namespace Together
{
    /// <summary>
    /// Blue-green strategy configuration for a single cutover to the target deployment.
    /// </summary>
    public sealed partial class DeBlueGreenConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}