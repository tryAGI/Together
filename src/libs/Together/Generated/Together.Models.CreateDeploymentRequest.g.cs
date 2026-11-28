
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
        /// Autoscaling configuration. Example: {"metric": "QueueBacklogPerWorker", "target": 1.01} to scale based on queue backlog. Omit or set to null to disable autoscaling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>))]
        public global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? Autoscaling { get; set; }

        /// <summary>
        /// Controls how replicas above reserved capacity behave. `stable` replicas stay running after scale-up; `preemptible` replicas may be evicted during capacity contention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.CreateDeploymentRequestCapacityTypeJsonConverter))]
        public global::Together.CreateDeploymentRequestCapacityType? CapacityType { get; set; }

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
        /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). If set, the platform checks this endpoint to determine container health.
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
        /// MaxReplicas is the maximum number of container instances. Defaults to MinReplicas if not set.
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
        /// Model weights to preload from Together's model registry into the container. At most one mount is supported, and it cannot be used with volumes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_mounts")]
        public global::System.Collections.Generic.IList<global::Together.ModelMount>? ModelMounts { get; set; }

        /// <summary>
        /// ModelName is the model this deployment handles traffic for. Defaults to name of the deployment. A value used by one project as a deployment or model name is unavailable to other projects; within a project, any number of deployments may share a model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Name is the unique identifier for your deployment. Must contain lowercase letters, numbers, or hyphens, start with a lowercase letter or number, and be 4-63 characters. It cannot be changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// PlacementGroup co-locates deployments that share this value onto one cluster, so in-cluster traffic between them stays local. A member that cannot co-locate stays pending. Leave empty for no group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement_group")]
        public string? PlacementGroup { get; set; }

        /// <summary>
        /// Port is the container port your application listens on (e.g., 8080 for web servers). Required if your application serves traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// Regions confines the deployment to clusters in these regions. Each entry is an exact region or a prefix family like "us-east" that matches every "us-east-*". A deployment that cannot place in any of them stays pending. Empty means any region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

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
        /// TrafficWeight is the deployment's share of its model's traffic, relative to the other deployments of that model.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_weight")]
        public int? TrafficWeight { get; set; }

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
        /// <param name="gpuType">
        /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb").
        /// </param>
        /// <param name="image">
        /// Image is the container image to deploy from registry.together.ai.
        /// </param>
        /// <param name="name">
        /// Name is the unique identifier for your deployment. Must contain lowercase letters, numbers, or hyphens, start with a lowercase letter or number, and be 4-63 characters. It cannot be changed.
        /// </param>
        /// <param name="args">
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration. Example: {"metric": "QueueBacklogPerWorker", "target": 1.01} to scale based on queue backlog. Omit or set to null to disable autoscaling
        /// </param>
        /// <param name="capacityType">
        /// Controls how replicas above reserved capacity behave. `stable` replicas stay running after scale-up; `preemptible` replicas may be evicted during capacity contention.
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
        /// <param name="healthCheckPath">
        /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). If set, the platform checks this endpoint to determine container health.
        /// </param>
        /// <param name="maxReplicas">
        /// MaxReplicas is the maximum number of container instances. Defaults to MinReplicas if not set.
        /// </param>
        /// <param name="memory">
        /// Memory is the amount of RAM to allocate per container instance in GiB (e.g., 0.5 = 512MiB)
        /// </param>
        /// <param name="minReplicas">
        /// MinReplicas is the minimum number of container instances to run. Defaults to 1 if not specified
        /// </param>
        /// <param name="modelMounts">
        /// Model weights to preload from Together's model registry into the container. At most one mount is supported, and it cannot be used with volumes.
        /// </param>
        /// <param name="modelName">
        /// ModelName is the model this deployment handles traffic for. Defaults to name of the deployment. A value used by one project as a deployment or model name is unavailable to other projects; within a project, any number of deployments may share a model name
        /// </param>
        /// <param name="placementGroup">
        /// PlacementGroup co-locates deployments that share this value onto one cluster, so in-cluster traffic between them stays local. A member that cannot co-locate stays pending. Leave empty for no group
        /// </param>
        /// <param name="port">
        /// Port is the container port your application listens on (e.g., 8080 for web servers). Required if your application serves traffic
        /// </param>
        /// <param name="regions">
        /// Regions confines the deployment to clusters in these regions. Each entry is an exact region or a prefix family like "us-east" that matches every "us-east-*". A deployment that cannot place in any of them stays pending. Empty means any region
        /// </param>
        /// <param name="storage">
        /// Storage is the amount of ephemeral disk storage to allocate per container instance (e.g., 10 = 10GiB)
        /// </param>
        /// <param name="terminationGracePeriodSeconds">
        /// TerminationGracePeriodSeconds is the time in seconds to wait for graceful shutdown before forcefully terminating the replica
        /// </param>
        /// <param name="trafficWeight">
        /// TrafficWeight is the deployment's share of its model's traffic, relative to the other deployments of that model.<br/>
        /// Default Value: 100
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
            global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? autoscaling,
            global::Together.CreateDeploymentRequestCapacityType? capacityType,
            global::System.Collections.Generic.IList<string>? command,
            double? cpu,
            string? description,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? environmentVariables,
            int? gpuCount,
            string? healthCheckPath,
            int? maxReplicas,
            double? memory,
            int? minReplicas,
            global::System.Collections.Generic.IList<global::Together.ModelMount>? modelMounts,
            string? modelName,
            string? placementGroup,
            int? port,
            global::System.Collections.Generic.IList<string>? regions,
            int? storage,
            int? terminationGracePeriodSeconds,
            int? trafficWeight,
            global::System.Collections.Generic.IList<global::Together.VolumeMount>? volumes)
        {
            this.Args = args;
            this.Autoscaling = autoscaling;
            this.CapacityType = capacityType;
            this.Command = command;
            this.Cpu = cpu;
            this.Description = description;
            this.EnvironmentVariables = environmentVariables;
            this.GpuCount = gpuCount;
            this.GpuType = gpuType;
            this.HealthCheckPath = healthCheckPath;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.MaxReplicas = maxReplicas;
            this.Memory = memory;
            this.MinReplicas = minReplicas;
            this.ModelMounts = modelMounts;
            this.ModelName = modelName;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PlacementGroup = placementGroup;
            this.Port = port;
            this.Regions = regions;
            this.Storage = storage;
            this.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            this.TrafficWeight = trafficWeight;
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