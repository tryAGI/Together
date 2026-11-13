
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
        /// Optional target replica floor at completion. For rolling, the ladder climbs to this count one replica per rung. Must be at least 1 when set; defaults to the source deployment's replica count at create time, or to the source and target deployments' combined replica count when both already stand in the endpoint traffic split after a cancel. The completed target's autoscaling max lands at the landing ceiling, max(this value, the source max, the target's own max); the rollout may lift the target max at first wake, at the first step that needs it, or at completion unless an operator changes max mid-run. The lifted ceiling remains after completion, and PreviewRolloutDefaults reports a coming lift as ROLLOUT_WILL_RAISE_TARGET_MAX. A pre-existing target whose own autoscaling min is higher keeps that floor, reported as FINAL_BELOW_INHERITED_MIN. A target that starts stopped lands exactly at this value; if the source min was higher, PreviewRolloutDefaults reports FINAL_BELOW_SOURCE_MIN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalTargetReplicas")]
        public int? FinalTargetReplicas { get; set; }

        /// <summary>
        /// Optional maximum target replicas one canary step may add. No canary step raises the target required replica count by more than this over the previous step (the target's current count before the first). Canary steps are admitted only when every raise fits. A rejection names the step, the counts, and the smallest maxSurge that admits the plan. Autoscaler growth on either deployment is not counted against the bound. Must be between 1 and 1000 when set. When unset, no step-raise bound applies. Available on the canary strategy only for now; a rolling or blue-green rollout that sets it is rejected at create and preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSurge")]
        public int? MaxSurge { get; set; }

        /// <summary>
        /// Count of source replicas that may be missing or retired ahead of their replacements at any one time. Defaults to 0, so the rollout waits for capacity and refuses a degraded source. Spent three ways. A source already degraded at create (ready below desired by at most this many) is admitted. The engine retires source replicas ahead of a target raise to stay under maxSurge. When the target cannot be placed, it retires source replicas to make room, and only when both legs use the same GPU type; a target that cannot be placed on the source's cluster gains nothing from the retire, and the rollout then pauses naming it. It is a concurrent bound measured against the source's routed-share need, which drops after every traffic shift, so a full cluster is walked rung by rung. The last source replica is never retired before traffic moves, except at the final 100% rung, where the allowance may stop the source before the target's last replicas are ready. A 1-replica source with maxUnavailable 1 on a full cluster serves nothing while the replacement starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxUnavailable")]
        public int? MaxUnavailable { get; set; }

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
        /// Optional target replica floor at completion. For rolling, the ladder climbs to this count one replica per rung. Must be at least 1 when set; defaults to the source deployment's replica count at create time, or to the source and target deployments' combined replica count when both already stand in the endpoint traffic split after a cancel. The completed target's autoscaling max lands at the landing ceiling, max(this value, the source max, the target's own max); the rollout may lift the target max at first wake, at the first step that needs it, or at completion unless an operator changes max mid-run. The lifted ceiling remains after completion, and PreviewRolloutDefaults reports a coming lift as ROLLOUT_WILL_RAISE_TARGET_MAX. A pre-existing target whose own autoscaling min is higher keeps that floor, reported as FINAL_BELOW_INHERITED_MIN. A target that starts stopped lands exactly at this value; if the source min was higher, PreviewRolloutDefaults reports FINAL_BELOW_SOURCE_MIN.
        /// </param>
        /// <param name="maxSurge">
        /// Optional maximum target replicas one canary step may add. No canary step raises the target required replica count by more than this over the previous step (the target's current count before the first). Canary steps are admitted only when every raise fits. A rejection names the step, the counts, and the smallest maxSurge that admits the plan. Autoscaler growth on either deployment is not counted against the bound. Must be between 1 and 1000 when set. When unset, no step-raise bound applies. Available on the canary strategy only for now; a rolling or blue-green rollout that sets it is rejected at create and preview.
        /// </param>
        /// <param name="maxUnavailable">
        /// Count of source replicas that may be missing or retired ahead of their replacements at any one time. Defaults to 0, so the rollout waits for capacity and refuses a degraded source. Spent three ways. A source already degraded at create (ready below desired by at most this many) is admitted. The engine retires source replicas ahead of a target raise to stay under maxSurge. When the target cannot be placed, it retires source replicas to make room, and only when both legs use the same GPU type; a target that cannot be placed on the source's cluster gains nothing from the retire, and the rollout then pauses naming it. It is a concurrent bound measured against the source's routed-share need, which drops after every traffic shift, so a full cluster is walked rung by rung. The last source replica is never retired before traffic moves, except at the final 100% rung, where the allowance may stop the source before the target's last replicas are ready. A 1-replica source with maxUnavailable 1 on a full cluster serves nothing while the replacement starts.
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
            int? finalTargetReplicas,
            int? maxSurge,
            int? maxUnavailable)
        {
            this.SourceDeploymentId = sourceDeploymentId ?? throw new global::System.ArgumentNullException(nameof(sourceDeploymentId));
            this.TargetDeploymentId = targetDeploymentId ?? throw new global::System.ArgumentNullException(nameof(targetDeploymentId));
            this.Canary = canary;
            this.BlueGreen = blueGreen;
            this.Rolling = rolling;
            this.Metrics = metrics;
            this.FinalSourceReplicas = finalSourceReplicas;
            this.FinalTargetReplicas = finalTargetReplicas;
            this.MaxSurge = maxSurge;
            this.MaxUnavailable = maxUnavailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateRolloutRequest" /> class.
        /// </summary>
        public DeCreateRolloutRequest()
        {
        }

    }
}