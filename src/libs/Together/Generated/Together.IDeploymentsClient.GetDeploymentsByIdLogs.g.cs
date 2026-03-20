#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get logs for a deployment<br/>
        /// Retrieve logs from a deployment, optionally filtered by replica ID.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name
        /// </param>
        /// <param name="replicaId">
        /// Replica ID to filter logs
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeploymentLogs> GetDeploymentsByIdLogsAsync(
            string id,
            string? replicaId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}