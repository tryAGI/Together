
#nullable enable

namespace Together
{
    /// <summary>
    /// Configuration for automatic scaling of replicas based on demand.
    /// </summary>
    public sealed partial class Autoscaling
    {
        /// <summary>
        /// The minimum number of replicas to maintain, even when there is no load
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinReplicas { get; set; }

        /// <summary>
        /// The maximum number of replicas to scale up to under load
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxReplicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscaling" /> class.
        /// </summary>
        /// <param name="minReplicas">
        /// The minimum number of replicas to maintain, even when there is no load
        /// </param>
        /// <param name="maxReplicas">
        /// The maximum number of replicas to scale up to under load
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Autoscaling(
            int minReplicas,
            int maxReplicas)
        {
            this.MinReplicas = minReplicas;
            this.MaxReplicas = maxReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscaling" /> class.
        /// </summary>
        public Autoscaling()
        {
        }
    }
}