
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegionListResponseRegion
    {
        /// <summary>
        /// Identifiable name of the region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// List of supported identifiable driver versions available in the region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DriverVersions { get; set; }

        /// <summary>
        /// List of supported identifiable gpus available in the region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_instance_types")]
        public global::System.Collections.Generic.IList<string>? SupportedInstanceTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionListResponseRegion" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifiable name of the region.
        /// </param>
        /// <param name="driverVersions">
        /// List of supported identifiable driver versions available in the region.
        /// </param>
        /// <param name="supportedInstanceTypes">
        /// List of supported identifiable gpus available in the region.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionListResponseRegion(
            string name,
            global::System.Collections.Generic.IList<string> driverVersions,
            global::System.Collections.Generic.IList<string>? supportedInstanceTypes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DriverVersions = driverVersions ?? throw new global::System.ArgumentNullException(nameof(driverVersions));
            this.SupportedInstanceTypes = supportedInstanceTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionListResponseRegion" /> class.
        /// </summary>
        public RegionListResponseRegion()
        {
        }
    }
}