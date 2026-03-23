#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Create a new deployment<br/>
        /// Create a new deployment with specified configuration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// deployment = client.beta.jig.deploy(<br/>
        ///   name="my-deployment",<br/>
        ///   gpu_type="h100-80gb",<br/>
        ///   image="registry.together.xyz/proj_abcdefg1234567890/my-image:latest"<br/>
        /// )<br/>
        /// print(deployment)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> CreateDeploymentsAsync(

            global::Together.CreateDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new deployment<br/>
        /// Create a new deployment with specified configuration
        /// </summary>
        /// <param name="args">
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration. Example: {"metric": "QueueBacklogPerWorker", "target": 1.01} to scale based on queue backlog. Omit or set to null to disable autoscaling
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
        /// EnvironmentVariables is a list of environment variables to set in the container. Each must have a name and either a value or value_from_secret
        /// </param>
        /// <param name="gpuCount">
        /// GPUCount is the number of GPUs to allocate per container instance. Defaults to 0 if not specified
        /// </param>
        /// <param name="gpuType">
        /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb").
        /// </param>
        /// <param name="healthCheckPath">
        /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). If set, the platform will check this endpoint to determine container health
        /// </param>
        /// <param name="image">
        /// Image is the container image to deploy from registry.together.ai.
        /// </param>
        /// <param name="maxReplicas">
        /// MaxReplicas is the maximum number of container instances that can be scaled up to. If not set, will be set to MinReplicas
        /// </param>
        /// <param name="memory">
        /// Memory is the amount of RAM to allocate per container instance in GiB (e.g., 0.5 = 512MiB)
        /// </param>
        /// <param name="minReplicas">
        /// MinReplicas is the minimum number of container instances to run. Defaults to 1 if not specified
        /// </param>
        /// <param name="name">
        /// Name is the unique identifier for your deployment. Must contain only alphanumeric characters, underscores, or hyphens (1-100 characters)
        /// </param>
        /// <param name="port">
        /// Port is the container port your application listens on (e.g., 8080 for web servers). Required if your application serves traffic
        /// </param>
        /// <param name="storage">
        /// Storage is the amount of ephemeral disk storage to allocate per container instance (e.g., 10 = 10GiB)
        /// </param>
        /// <param name="terminationGracePeriodSeconds">
        /// TerminationGracePeriodSeconds is the time in seconds to wait for graceful shutdown before forcefully terminating the replica
        /// </param>
        /// <param name="volumes">
        /// Volumes is a list of volume mounts to attach to the container. Each mount must reference an existing volume by name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> CreateDeploymentsAsync(
            string image,
            string name,
            global::System.Collections.Generic.IList<string>? args = default,
            global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? autoscaling = default,
            global::System.Collections.Generic.IList<string>? command = default,
            double? cpu = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? environmentVariables = default,
            int? gpuCount = default,
            global::Together.CreateDeploymentRequestGpuType gpuType = default,
            string? healthCheckPath = default,
            int? maxReplicas = default,
            double? memory = default,
            int? minReplicas = default,
            int? port = default,
            int? storage = default,
            int? terminationGracePeriodSeconds = default,
            global::System.Collections.Generic.IList<global::Together.VolumeMount>? volumes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}