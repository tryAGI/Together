
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Certified deployment profile for a supported model.
    /// </summary>
    public sealed partial class DeSupportedModelDeploymentProfile
    {
        /// <summary>
        /// Stable profile identifier, usually the certified config id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileId { get; set; }

        /// <summary>
        /// Certified configuration revision identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifiedConfigRevisionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CertifiedConfigRevisionId { get; set; }

        /// <summary>
        /// Certified model weight revision identifier, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifiedModelRevisionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CertifiedModelRevisionId { get; set; }

        /// <summary>
        /// GPU instance type for the profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Number of GPUs required by the profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GpuCount { get; set; }

        /// <summary>
        /// Quantization method for the profile, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantization { get; set; }

        /// <summary>
        /// Deprecated. Use `parallelism`. Legacy tensor-parallel shard count for the profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tensorParallelSize")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? TensorParallelSize { get; set; }

        /// <summary>
        /// Performance benchmarks for the profile, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performanceBenchmarks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeSupportedModelPerformanceBenchmarks PerformanceBenchmarks { get; set; }

        /// <summary>
        /// Certified config revision in the form `projects/{projectId}/configs/{configRevisionId}`. Omitted when the profile does not pin a config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Config { get; set; }

        /// <summary>
        /// Deployable model resource in the form `projects/{projectId}/models/{modelId}[/revisions/{revisionId}]`. Omitted when the profile does not pin model weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Free-form parallelism spec for the profile, such as TP8, TP4, EP, or PD; supersedes tensor_parallel_size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallelism")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Parallelism { get; set; }

        /// <summary>
        /// Fully-qualified deploy model name in the form `{projectSlug}/{modelName}`, such as `Qwen/Qwen3.5-9B-FP8`; empty when no public model is linked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelDeploymentProfile" /> class.
        /// </summary>
        /// <param name="profileId">
        /// Stable profile identifier, usually the certified config id.
        /// </param>
        /// <param name="certifiedConfigRevisionId">
        /// Certified configuration revision identifier.
        /// </param>
        /// <param name="certifiedModelRevisionId">
        /// Certified model weight revision identifier, if available.
        /// </param>
        /// <param name="gpuType">
        /// GPU instance type for the profile.
        /// </param>
        /// <param name="gpuCount">
        /// Number of GPUs required by the profile.
        /// </param>
        /// <param name="quantization">
        /// Quantization method for the profile, if available.
        /// </param>
        /// <param name="performanceBenchmarks">
        /// Performance benchmarks for the profile, if available.
        /// </param>
        /// <param name="config">
        /// Certified config revision in the form `projects/{projectId}/configs/{configRevisionId}`. Omitted when the profile does not pin a config.
        /// </param>
        /// <param name="model">
        /// Deployable model resource in the form `projects/{projectId}/models/{modelId}[/revisions/{revisionId}]`. Omitted when the profile does not pin model weights.
        /// </param>
        /// <param name="parallelism">
        /// Free-form parallelism spec for the profile, such as TP8, TP4, EP, or PD; supersedes tensor_parallel_size.
        /// </param>
        /// <param name="modelName">
        /// Fully-qualified deploy model name in the form `{projectSlug}/{modelName}`, such as `Qwen/Qwen3.5-9B-FP8`; empty when no public model is linked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeSupportedModelDeploymentProfile(
            string profileId,
            string certifiedConfigRevisionId,
            string certifiedModelRevisionId,
            string gpuType,
            int gpuCount,
            string quantization,
            global::Together.DeSupportedModelPerformanceBenchmarks performanceBenchmarks,
            string config,
            string model,
            string parallelism,
            string modelName)
        {
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.CertifiedConfigRevisionId = certifiedConfigRevisionId ?? throw new global::System.ArgumentNullException(nameof(certifiedConfigRevisionId));
            this.CertifiedModelRevisionId = certifiedModelRevisionId ?? throw new global::System.ArgumentNullException(nameof(certifiedModelRevisionId));
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.GpuCount = gpuCount;
            this.Quantization = quantization ?? throw new global::System.ArgumentNullException(nameof(quantization));
            this.PerformanceBenchmarks = performanceBenchmarks ?? throw new global::System.ArgumentNullException(nameof(performanceBenchmarks));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Parallelism = parallelism ?? throw new global::System.ArgumentNullException(nameof(parallelism));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelDeploymentProfile" /> class.
        /// </summary>
        public DeSupportedModelDeploymentProfile()
        {
        }

    }
}