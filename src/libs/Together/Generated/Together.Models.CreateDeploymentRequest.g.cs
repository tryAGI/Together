
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentRequest
    {
        /// <summary>
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// Autoscaling configuration as key-value pairs. Example: {"metric": "QueueBacklogPerWorker", "target": "10"} to scale based on queue backlog
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        public global::System.Collections.Generic.Dictionary<string, string>? Autoscaling { get; set; }

        /// <summary>
        /// Command overrides the container's ENTRYPOINT. Provide as an array (e.g., ["/bin/sh", "-c"])
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        /// CPU is the number of CPU cores to allocate per container instance (e.g., 0.1 = 100 milli cores)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public double? Cpu { get; set; }

        /// <summary>
        /// Description is an optional human-readable description of your deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// EnvironmentVariables is a list of environment variables to set in the container. Each must have a name and either a value or value_from_secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_variables")]
        public global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? EnvironmentVariables { get; set; }

        /// <summary>
        /// GPUCount is the number of GPUs to allocate per container instance. Defaults to 0 if not specified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_count")]
        public int? GpuCount { get; set; }

        /// <summary>
        /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.CreateDeploymentRequestGpuTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.CreateDeploymentRequestGpuType GpuType { get; set; }

        /// <summary>
        /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). If set, the platform will check this endpoint to determine container health
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_check_path")]
        public string? HealthCheckPath { get; set; }

        /// <summary>
        /// Image is the container image to deploy from registry.together.ai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// MaxReplicas is the maximum number of container instances that can be scaled up to. If not set, will be set to MinReplicas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// Memory is the amount of RAM to allocate per container instance in GiB (e.g., 0.5 = 512MiB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// MinReplicas is the minimum number of container instances to run. Defaults to 1 if not specified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Name is the unique identifier for your deployment. Must contain only alphanumeric characters, underscores, or hyphens (1-100 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Port is the container port your application listens on (e.g., 8080 for web servers). Required if your application serves traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// Storage is the amount of ephemeral disk storage to allocate per container instance (e.g., 10 = 10GiB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        public int? Storage { get; set; }

        /// <summary>
        /// TerminationGracePeriodSeconds is the time in seconds to wait for graceful shutdown before forcefully terminating the replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_grace_period_seconds")]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Volumes is a list of volume mounts to attach to the container. Each mount must reference an existing volume by name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::Together.VolumeMount>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="args">
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration as key-value pairs. Example: {"metric": "QueueBacklogPerWorker", "target": "10"} to scale based on queue backlog
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequest(
            global::Together.CreateDeploymentRequestGpuType gpuType,
            string image,
            string name,
            global::System.Collections.Generic.IList<string>? args,
            global::System.Collections.Generic.Dictionary<string, string>? autoscaling,
            global::System.Collections.Generic.IList<string>? command,
            double? cpu,
            string? description,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? environmentVariables,
            int? gpuCount,
            string? healthCheckPath,
            int? maxReplicas,
            double? memory,
            int? minReplicas,
            int? port,
            int? storage,
            int? terminationGracePeriodSeconds,
            global::System.Collections.Generic.IList<global::Together.VolumeMount>? volumes)
        {
            this.GpuType = gpuType;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Args = args;
            this.Autoscaling = autoscaling;
            this.Command = command;
            this.Cpu = cpu;
            this.Description = description;
            this.EnvironmentVariables = environmentVariables;
            this.GpuCount = gpuCount;
            this.HealthCheckPath = healthCheckPath;
            this.MaxReplicas = maxReplicas;
            this.Memory = memory;
            this.MinReplicas = minReplicas;
            this.Port = port;
            this.Storage = storage;
            this.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequest" /> class.
        /// </summary>
        public CreateDeploymentRequest()
        {
        }
    }
}