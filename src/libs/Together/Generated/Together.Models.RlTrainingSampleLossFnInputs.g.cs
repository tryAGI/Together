
#nullable enable

namespace Together
{
    /// <summary>
    /// Per-token loss tensors keyed by name. Include `target_tokens` and the inputs required by the selected loss. Each tensor must declare `int64` or `float32`, be one-dimensional, and have the same length.
    /// </summary>
    public sealed partial class RlTrainingSampleLossFnInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}