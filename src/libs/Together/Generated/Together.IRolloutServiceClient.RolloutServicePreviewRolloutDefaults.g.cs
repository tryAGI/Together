#nullable enable

namespace Together
{
    public partial interface IRolloutServiceClient
    {
        /// <summary>
        /// Preview rollout defaults<br/>
        /// Returns the values a create request would pick for any field left unset, plus the capacity context needed to display them, without creating a rollout. Responses are display state only and re-validated authoritatively at create and start; do not copy response values back into a create request.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// # Returns the values a create request would use for unset fields,<br/>
        /// # without creating a rollout.<br/>
        /// defaults = client.endpoints.rollouts.preview_defaults(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     source_deployment_id="dep_abc123",<br/>
        ///     target_deployment_id="dep_def456",<br/>
        ///     canary={"steps": [{"traffic": 25}, {"traffic": 100}]},<br/>
        /// )<br/>
        /// print(defaults)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeRolloutDefaultsPreview> RolloutServicePreviewRolloutDefaultsAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview rollout defaults<br/>
        /// Returns the values a create request would pick for any field left unset, plus the capacity context needed to display them, without creating a rollout. Responses are display state only and re-validated authoritatively at create and start; do not copy response values back into a create request.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// # Returns the values a create request would use for unset fields,<br/>
        /// # without creating a rollout.<br/>
        /// defaults = client.endpoints.rollouts.preview_defaults(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     source_deployment_id="dep_abc123",<br/>
        ///     target_deployment_id="dep_def456",<br/>
        ///     canary={"steps": [{"traffic": 25}, {"traffic": 100}]},<br/>
        /// )<br/>
        /// print(defaults)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeRolloutDefaultsPreview>> RolloutServicePreviewRolloutDefaultsAsResponseAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview rollout defaults<br/>
        /// Returns the values a create request would pick for any field left unset, plus the capacity context needed to display them, without creating a rollout. Responses are display state only and re-validated authoritatively at create and start; do not copy response values back into a create request.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRolloutDefaultsPreview> RolloutServicePreviewRolloutDefaultsAsync(
            string projectId,
            string endpointId,
            string sourceDeploymentId,
            string targetDeploymentId,
            global::Together.DeCanaryConfig? canary = default,
            global::Together.DeBlueGreenConfig? blueGreen = default,
            global::Together.DeRollingConfig? rolling = default,
            global::System.Collections.Generic.IList<global::Together.DeMetricRule>? metrics = default,
            int? finalSourceReplicas = default,
            int? finalTargetReplicas = default,
            int? maxSurge = default,
            int? maxUnavailable = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}