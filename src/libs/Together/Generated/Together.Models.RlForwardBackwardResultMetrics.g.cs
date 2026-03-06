
#nullable enable

namespace Together
{
    /// <summary>
    /// Loss-specific metrics (e.g., KL divergence, clip fraction for GRPO)
    /// </summary>
    public sealed partial class RlForwardBackwardResultMetrics
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}