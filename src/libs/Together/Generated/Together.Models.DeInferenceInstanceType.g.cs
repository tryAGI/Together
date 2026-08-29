
#nullable enable

namespace Together
{
    /// <summary>
    /// GPU hardware configuration on which one inference replica can run.
    /// </summary>
    public sealed partial class DeInferenceInstanceType
    {
        /// <summary>
        /// Stable hardware instance type identifier used by deployment configs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable instance type name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable summary of the hardware configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// GPU accelerator model, such as `H100` or `B200`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Number of GPUs in one replica of this instance type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GpuCount { get; set; }

        /// <summary>
        /// Memory available on each GPU, in GiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuMemoryGib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GpuMemoryGib { get; set; }

        /// <summary>
        /// On-demand price for one running replica, in US cents per hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceCentsPerHour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PriceCentsPerHour { get; set; }

        /// <summary>
        /// Regions where this instance type is offered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeRegion> Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeInferenceInstanceType" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable hardware instance type identifier used by deployment configs.
        /// </param>
        /// <param name="name">
        /// Human-readable instance type name.
        /// </param>
        /// <param name="description">
        /// Human-readable summary of the hardware configuration.
        /// </param>
        /// <param name="gpuType">
        /// GPU accelerator model, such as `H100` or `B200`.
        /// </param>
        /// <param name="gpuCount">
        /// Number of GPUs in one replica of this instance type.
        /// </param>
        /// <param name="gpuMemoryGib">
        /// Memory available on each GPU, in GiB.
        /// </param>
        /// <param name="priceCentsPerHour">
        /// On-demand price for one running replica, in US cents per hour.
        /// </param>
        /// <param name="regions">
        /// Regions where this instance type is offered.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeInferenceInstanceType(
            string id,
            string name,
            string description,
            string gpuType,
            int gpuCount,
            int gpuMemoryGib,
            int priceCentsPerHour,
            global::System.Collections.Generic.IList<global::Together.DeRegion> regions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.GpuCount = gpuCount;
            this.GpuMemoryGib = gpuMemoryGib;
            this.PriceCentsPerHour = priceCentsPerHour;
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeInferenceInstanceType" /> class.
        /// </summary>
        public DeInferenceInstanceType()
        {
        }

    }
}