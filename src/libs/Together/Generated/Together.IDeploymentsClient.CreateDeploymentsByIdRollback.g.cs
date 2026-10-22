#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Roll back a deployment to a previous revision<br/>
        /// Re-applies the spec of a previous revision. Pods running the target revision will be retained. Other pods will be drained and restarted with the target revision.<br/>
        /// Only the 50 most recent revisions per deployment can be rolled back to; older targets return 404.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # Pass a revision number or a revision ID.<br/>
        /// deployment = client.beta.jig.rollback(<br/>
        ///     "my-deployment", revision_identifier="3"<br/>
        /// )<br/>
        /// print(deployment.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> CreateDeploymentsByIdRollbackAsync(
            string id,

            global::Together.RollbackDeploymentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Roll back a deployment to a previous revision<br/>
        /// Re-applies the spec of a previous revision. Pods running the target revision will be retained. Other pods will be drained and restarted with the target revision.<br/>
        /// Only the 50 most recent revisions per deployment can be rolled back to; older targets return 404.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # Pass a revision number or a revision ID.<br/>
        /// deployment = client.beta.jig.rollback(<br/>
        ///     "my-deployment", revision_identifier="3"<br/>
        /// )<br/>
        /// print(deployment.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeploymentResponseItem>> CreateDeploymentsByIdRollbackAsResponseAsync(
            string id,

            global::Together.RollbackDeploymentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Roll back a deployment to a previous revision<br/>
        /// Re-applies the spec of a previous revision. Pods running the target revision will be retained. Other pods will be drained and restarted with the target revision.<br/>
        /// Only the 50 most recent revisions per deployment can be rolled back to; older targets return 404.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name.
        /// </param>
        /// <param name="revisionIdentifier">
        /// Revision number or revision ID to roll back to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> CreateDeploymentsByIdRollbackAsync(
            string id,
            string revisionIdentifier,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}