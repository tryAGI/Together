
#nullable enable

namespace Together
{
    /// <summary>
    /// Strategy, metric gates, timing, and cleanup policy for shifting traffic between two deployments under one endpoint.
    /// </summary>
    public sealed partial class DeCreateRolloutRequest
    {
        /// <summary>
        /// Deployment that traffic shifts away from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceDeploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDeploymentId { get; set; }

        /// <summary>
        /// Deployment that traffic shifts toward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDeploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetDeploymentId { get; set; }

        /// <summary>
        /// Canary rollout strategy configuration. Mutually exclusive with blueGreen and rolling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canary")]
        public global::Together.DeCanaryConfig? Canary { get; set; }

        /// <summary>
        /// Blue-green rollout strategy configuration. Mutually exclusive with canary and rolling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueGreen")]
        public global::Together.DeBlueGreenConfig? BlueGreen { get; set; }

        /// <summary>
        /// Rolling rollout strategy configuration. Mutually exclusive with canary and blueGreen.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rolling")]
        public global::Together.DeRollingConfig? Rolling { get; set; }

        /// <summary>
        /// Optional metric gates evaluated after each step's soak. Canary only; rejected on rolling and blue-green rollouts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::Together.DeMetricRule>? Metrics { get; set; }

        /// <summary>
        /// Optional final replica count for the source deployment. Defaults to 0, which drains and stops the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalSourceReplicas")]
        public int? FinalSourceReplicas { get; set; }

        /// <summary>
        /// Optional target replica floor at completion. Must be at least 1 when set; defaults to the source deployment's replica count at create time, or to the source and target deployments' combined replica count when both already stand in the endpoint traffic split after a cancel. If this exceeds the target autoscaling max, the rollout raises that max once when first needed unless an operator changes max mid-run; the raised ceiling remains after completion. A pre-existing target whose own autoscaling min is higher keeps that floor, reported as FINAL_BELOW_INHERITED_MIN. A target that starts stopped lands exactly at this value; if the source min was higher, PreviewRolloutDefaults reports FINAL_BELOW_SOURCE_MIN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalTargetReplicas")]
        public int? FinalTargetReplicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateRolloutRequest" /> class.
        /// </summary>
        /// <param name="sourceDeploymentId">
        /// Deployment that traffic shifts away from.
        /// </param>
        /// <param name="targetDeploymentId">
        /// Deployment that traffic shifts toward.
        /// </param>
        /// <param name="canary">
        /// Canary rollout strategy configuration. Mutually exclusive with blueGreen and rolling.
        /// </param>
        /// <param name="blueGreen">
        /// Blue-green rollout strategy configuration. Mutually exclusive with canary and rolling.
        /// </param>
        /// <param name="rolling">
        /// Rolling rollout strategy configuration. Mutually exclusive with canary and blueGreen.
        /// </param>
        /// <param name="metrics">
        /// Optional metric gates evaluated after each step's soak. Canary only; rejected on rolling and blue-green rollouts.
        /// </param>
        /// <param name="finalSourceReplicas">
        /// Optional final replica count for the source deployment. Defaults to 0, which drains and stops the source.
        /// </param>
        /// <param name="finalTargetReplicas">
        /// Optional target replica floor at completion. Must be at least 1 when set; defaults to the source deployment's replica count at create time, or to the source and target deployments' combined replica count when both already stand in the endpoint traffic split after a cancel. If this exceeds the target autoscaling max, the rollout raises that max once when first needed unless an operator changes max mid-run; the raised ceiling remains after completion. A pre-existing target whose own autoscaling min is higher keeps that floor, reported as FINAL_BELOW_INHERITED_MIN. A target that starts stopped lands exactly at this value; if the source min was higher, PreviewRolloutDefaults reports FINAL_BELOW_SOURCE_MIN.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateRolloutRequest(
            string sourceDeploymentId,
            string targetDeploymentId,
            global::Together.DeCanaryConfig? canary,
            global::Together.DeBlueGreenConfig? blueGreen,
            global::Together.DeRollingConfig? rolling,
            global::System.Collections.Generic.IList<global::Together.DeMetricRule>? metrics,
            int? finalSourceReplicas,
            int? finalTargetReplicas)
        {
            this.SourceDeploymentId = sourceDeploymentId ?? throw new global::System.ArgumentNullException(nameof(sourceDeploymentId));
            this.TargetDeploymentId = targetDeploymentId ?? throw new global::System.ArgumentNullException(nameof(targetDeploymentId));
            this.Canary = canary;
            this.BlueGreen = blueGreen;
            this.Rolling = rolling;
            this.Metrics = metrics;
            this.FinalSourceReplicas = finalSourceReplicas;
            this.FinalTargetReplicas = finalTargetReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateRolloutRequest" /> class.
        /// </summary>
        public DeCreateRolloutRequest()
        {
        }

    }
}