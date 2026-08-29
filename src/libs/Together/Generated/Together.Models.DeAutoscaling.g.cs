
#nullable enable

namespace Together
{
    /// <summary>
    /// Autoscaling configuration for a deployment.
    /// </summary>
    public sealed partial class DeAutoscaling
    {
        /// <summary>
        /// Minimum number of replicas. Omit on update to preserve the current value. Set both `minReplicas` and `maxReplicas` to `0` to stop the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minReplicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Maximum number of replicas. Defaults to `minReplicas`; omitting it on update preserves the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxReplicas")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// Time a lower replica recommendation must remain stable before scaling down. Defaults to `5m`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaleDownWindow")]
        public string? ScaleDownWindow { get; set; }

        /// <summary>
        /// Stabilization window before scaling up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaleUpWindow")]
        public string? ScaleUpWindow { get; set; }

        /// <summary>
        /// Idle period after which the deployment automatically stops and releases its replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaleToZeroWindow")]
        public string? ScaleToZeroWindow { get; set; }

        /// <summary>
        /// Metrics and targets that drive replica recommendations. When omitted, the platform uses concurrent in-flight requests per replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scalingMetrics")]
        public global::System.Collections.Generic.IList<global::Together.DeScalingMetric>? ScalingMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAutoscaling" /> class.
        /// </summary>
        /// <param name="minReplicas">
        /// Minimum number of replicas. Omit on update to preserve the current value. Set both `minReplicas` and `maxReplicas` to `0` to stop the deployment.
        /// </param>
        /// <param name="maxReplicas">
        /// Maximum number of replicas. Defaults to `minReplicas`; omitting it on update preserves the current value.
        /// </param>
        /// <param name="scaleDownWindow">
        /// Time a lower replica recommendation must remain stable before scaling down. Defaults to `5m`.
        /// </param>
        /// <param name="scaleUpWindow">
        /// Stabilization window before scaling up.
        /// </param>
        /// <param name="scaleToZeroWindow">
        /// Idle period after which the deployment automatically stops and releases its replicas.
        /// </param>
        /// <param name="scalingMetrics">
        /// Metrics and targets that drive replica recommendations. When omitted, the platform uses concurrent in-flight requests per replica.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeAutoscaling(
            int? minReplicas,
            int? maxReplicas,
            string? scaleDownWindow,
            string? scaleUpWindow,
            string? scaleToZeroWindow,
            global::System.Collections.Generic.IList<global::Together.DeScalingMetric>? scalingMetrics)
        {
            this.MinReplicas = minReplicas;
            this.MaxReplicas = maxReplicas;
            this.ScaleDownWindow = scaleDownWindow;
            this.ScaleUpWindow = scaleUpWindow;
            this.ScaleToZeroWindow = scaleToZeroWindow;
            this.ScalingMetrics = scalingMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAutoscaling" /> class.
        /// </summary>
        public DeAutoscaling()
        {
        }

    }
}