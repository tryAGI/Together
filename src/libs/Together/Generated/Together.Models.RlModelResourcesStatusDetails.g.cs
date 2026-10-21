
#nullable enable

namespace Together
{
    /// <summary>
    /// Details of a model resource's current status
    /// </summary>
    public sealed partial class RlModelResourcesStatusDetails
    {
        /// <summary>
        /// Estimated place of the resource in the queue: the number of older resources of the same GPU type still waiting for GPUs, plus one. Set only while the resource waits for GPUs.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_position")]
        public long? QueuePosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesStatusDetails" /> class.
        /// </summary>
        /// <param name="queuePosition">
        /// Estimated place of the resource in the queue: the number of older resources of the same GPU type still waiting for GPUs, plus one. Set only while the resource waits for GPUs.<br/>
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelResourcesStatusDetails(
            long? queuePosition)
        {
            this.QueuePosition = queuePosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesStatusDetails" /> class.
        /// </summary>
        public RlModelResourcesStatusDetails()
        {
        }

    }
}