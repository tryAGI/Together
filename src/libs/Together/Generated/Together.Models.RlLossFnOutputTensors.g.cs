
#nullable enable

namespace Together
{
    /// <summary>
    /// Output tensors keyed by name. Built-in losses return `logprobs`: the model's float32 per-token log-probabilities under the current policy, one value per token of the sample's input. Positions excluded from the loss, such as zero-weight positions, are masked to zero rather than true log-probabilities.
    /// </summary>
    public sealed partial class RlLossFnOutputTensors
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}