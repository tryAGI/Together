
#nullable enable

namespace Together
{
    /// <summary>
    /// Capacity weight assigned to one deployment in an endpoint's live traffic split.
    /// </summary>
    public sealed partial class DeTrafficSplitEntry
    {
        /// <summary>
        /// ID of a deployment under the endpoint that can receive live traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Non-negative, finite weight applied to each ready replica. A deployment's<br/>
        /// effective routing capacity is `weight * readyReplicas`, and requests are<br/>
        /// distributed in proportion to that capacity. Set to `0` to remove the<br/>
        /// deployment from the live traffic split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeTrafficSplitEntry" /> class.
        /// </summary>
        /// <param name="deploymentId">
        /// ID of a deployment under the endpoint that can receive live traffic.
        /// </param>
        /// <param name="weight">
        /// Non-negative, finite weight applied to each ready replica. A deployment's<br/>
        /// effective routing capacity is `weight * readyReplicas`, and requests are<br/>
        /// distributed in proportion to that capacity. Set to `0` to remove the<br/>
        /// deployment from the live traffic split.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeTrafficSplitEntry(
            string deploymentId,
            double weight)
        {
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeTrafficSplitEntry" /> class.
        /// </summary>
        public DeTrafficSplitEntry()
        {
        }

    }
}