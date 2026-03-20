#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {

        /// <summary>
        /// Update a deployment<br/>
        /// Update an existing deployment configuration
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// deployment = client.beta.jig.update("my-deployment", gpu_count=2)<br/>
        /// print(deployment)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> EditDeploymentsByIdAsync(
            string id,

            global::Together.UpdateDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a deployment<br/>
        /// Update an existing deployment configuration
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name
        /// </param>
        /// <param name="args">
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration for the deployment. Omit or set to null to disable autoscaling
        /// </param>
        /// <param name="command">
        /// Command overrides the container's ENTRYPOINT. Provide as an array (e.g., ["/bin/sh", "-c"])
        /// </param>
        /// <param name="cpu">
        /// CPU is the number of CPU cores to allocate per container instance (e.g., 0.1 = 100 milli cores)
        /// </param>
        /// <param name="description">
        /// Description is an optional human-readable description of your deployment
        /// </param>
        /// <param name="environmentVariables">
        /// EnvironmentVariables is a list of environment variables to set in the container. This will replace all existing environment variables
        /// </param>
        /// <param name="gpuCount">
        /// GPUCount is the number of GPUs to allocate per container instance
        /// </param>
        /// <param name="gpuType">
        /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb")
        /// </param>
        /// <param name="healthCheckPath">
        /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). Set to empty string to disable health checks
        /// </param>
        /// <param name="image">
        /// Image is the container image to deploy from registry.together.ai.
        /// </param>
        /// <param name="maxReplicas">
        /// MaxReplicas is the maximum number of replicas that can be scaled up to.
        /// </param>
        /// <param name="memory">
        /// Memory is the amount of RAM to allocate per container instance in GiB (e.g., 0.5 = 512MiB)
        /// </param>
        /// <param name="minReplicas">
        /// MinReplicas is the minimum number of replicas to run
        /// </param>
        /// <param name="name">
        /// Name is the new unique identifier for your deployment. Must contain only alphanumeric characters, underscores, or hyphens (1-100 characters)
        /// </param>
        /// <param name="port">
        /// Port is the container port your application listens on (e.g., 8080 for web servers)
        /// </param>
        /// <param name="storage">
        /// Storage is the amount of ephemeral disk storage to allocate per container instance (e.g., 10 = 10GiB)
        /// </param>
        /// <param name="terminationGracePeriodSeconds">
        /// TerminationGracePeriodSeconds is the time in seconds to wait for graceful shutdown before forcefully terminating the replica
        /// </param>
        /// <param name="volumes">
        /// Volumes is a list of volume mounts to attach to the container. This will replace all existing volumes
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> EditDeploymentsByIdAsync(
            string id,
            global::System.Collections.Generic.IList<string>? args = default,
            global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? autoscaling = default,
            global::System.Collections.Generic.IList<string>? command = default,
            double? cpu = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? environmentVariables = default,
            int? gpuCount = default,
            global::Together.UpdateDeploymentRequestGpuType? gpuType = default,
            string? healthCheckPath = default,
            string? image = default,
            int? maxReplicas = default,
            double? memory = default,
            int? minReplicas = default,
            string? name = default,
            int? port = default,
            int? storage = default,
            int? terminationGracePeriodSeconds = default,
            global::System.Collections.Generic.IList<global::Together.VolumeMount>? volumes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}