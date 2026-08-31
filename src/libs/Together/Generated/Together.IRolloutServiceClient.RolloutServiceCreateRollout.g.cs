#nullable enable

namespace Together
{
    public partial interface IRolloutServiceClient
    {
        /// <summary>
        /// Create a rollout<br/>
        /// Creates a rollout in the pending state without shifting traffic. Start the rollout in a separate request after reviewing its strategy and metric gates.
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
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServiceCreateRolloutAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a rollout<br/>
        /// Creates a rollout in the pending state without shifting traffic. Start the rollout in a separate request after reviewing its strategy and metric gates.
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
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeRollout>> RolloutServiceCreateRolloutAsResponseAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a rollout<br/>
        /// Creates a rollout in the pending state without shifting traffic. Start the rollout in a separate request after reviewing its strategy and metric gates.
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
        /// Optional target replica floor at completion. Must be at least 1 when set; defaults to the source deployment's replica count at create time, or to the source and target deployments' combined replica count when both already stand in the endpoint traffic split after a cancel. If this exceeds the target autoscaling max, the rollout raises that max once when first needed unless an operator changes max mid-run; the raised ceiling remains after completion. A pre-existing target whose own autoscaling min is higher keeps that floor, reported as FINAL_BELOW_INHERITED_MIN. A target that starts stopped lands exactly at this value; if the source min was higher, PreviewRolloutDefaults reports FINAL_BELOW_SOURCE_MIN.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServiceCreateRolloutAsync(
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
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}