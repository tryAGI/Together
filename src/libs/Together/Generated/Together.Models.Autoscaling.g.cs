
#nullable enable

namespace Together
{
    /// <summary>
    /// Configuration for automatic scaling of replicas based on demand.
    /// </summary>
    public sealed partial class Autoscaling
    {
        /// <summary>
        /// The maximum number of replicas to scale up to under load<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxReplicas { get; set; }

        /// <summary>
        /// The minimum number of replicas to maintain, even when there is no load<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinReplicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscaling" /> class.
        /// </summary>
        /// <param name="maxReplicas">
        /// The maximum number of replicas to scale up to under load<br/>
        /// Example: 5
        /// </param>
        /// <param name="minReplicas">
        /// The minimum number of replicas to maintain, even when there is no load<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Autoscaling(
            int maxReplicas,
            int minReplicas)
        {
            this.MaxReplicas = maxReplicas;
            this.MinReplicas = minReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscaling" /> class.
        /// </summary>
        public Autoscaling()
        {
        }
    }
}