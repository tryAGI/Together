
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for publishing updated policy parameters for sampling.
    /// </summary>
    public sealed partial class RlWeightsSyncBody
    {
        /// <summary>
        /// How updated parameters are made available for sampling. See `WeightSyncType` for accepted values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_sync_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlWeightSyncTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlWeightSyncType WeightSyncType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlWeightsSyncBody" /> class.
        /// </summary>
        /// <param name="weightSyncType">
        /// How updated parameters are made available for sampling. See `WeightSyncType` for accepted values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlWeightsSyncBody(
            global::Together.RlWeightSyncType weightSyncType)
        {
            this.WeightSyncType = weightSyncType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlWeightsSyncBody" /> class.
        /// </summary>
        public RlWeightsSyncBody()
        {
        }

    }
}