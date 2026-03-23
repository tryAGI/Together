
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDeploymentRequest
    {
        /// <summary>
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// Autoscaling configuration for the deployment. Set to {} to disable autoscaling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>))]
        public global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? Autoscaling { get; set; }

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
        /// EnvironmentVariables is a list of environment variables to set in the container. This will replace all existing environment variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_variables")]
        public global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? EnvironmentVariables { get; set; }

        /// <summary>
        /// GPUCount is the number of GPUs to allocate per container instance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_count")]
        public int? GpuCount { get; set; }

        /// <summary>
        /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeJsonConverter))]
        public global::Together.UpdateDeploymentRequestGpuType? GpuType { get; set; }

        /// <summary>
        /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). Set to empty string to disable health checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_check_path")]
        public string? HealthCheckPath { get; set; }

        /// <summary>
        /// Image is the container image to deploy from registry.together.ai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// MaxReplicas is the maximum number of replicas that can be scaled up to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// Memory is the amount of RAM to allocate per container instance in GiB (e.g., 0.5 = 512MiB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// MinReplicas is the minimum number of replicas to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Name is the new unique identifier for your deployment. Must contain only alphanumeric characters, underscores, or hyphens (1-100 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Port is the container port your application listens on (e.g., 8080 for web servers)
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
        /// Volumes is a list of volume mounts to attach to the container. This will replace all existing volumes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::Together.VolumeMount>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="args">
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration for the deployment. Set to {} to disable autoscaling
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeploymentRequest(
            global::System.Collections.Generic.IList<string>? args,
            global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? autoscaling,
            global::System.Collections.Generic.IList<string>? command,
            double? cpu,
            string? description,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? environmentVariables,
            int? gpuCount,
            global::Together.UpdateDeploymentRequestGpuType? gpuType,
            string? healthCheckPath,
            string? image,
            int? maxReplicas,
            double? memory,
            int? minReplicas,
            string? name,
            int? port,
            int? storage,
            int? terminationGracePeriodSeconds,
            global::System.Collections.Generic.IList<global::Together.VolumeMount>? volumes)
        {
            this.Args = args;
            this.Autoscaling = autoscaling;
            this.Command = command;
            this.Cpu = cpu;
            this.Description = description;
            this.EnvironmentVariables = environmentVariables;
            this.GpuCount = gpuCount;
            this.GpuType = gpuType;
            this.HealthCheckPath = healthCheckPath;
            this.Image = image;
            this.MaxReplicas = maxReplicas;
            this.Memory = memory;
            this.MinReplicas = minReplicas;
            this.Name = name;
            this.Port = port;
            this.Storage = storage;
            this.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequest" /> class.
        /// </summary>
        public UpdateDeploymentRequest()
        {
        }
    }
}