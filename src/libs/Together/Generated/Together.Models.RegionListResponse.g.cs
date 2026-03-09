
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegionListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Together.RegionListResponseRegion> Regions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionListResponse" /> class.
        /// </summary>
        /// <param name="regions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionListResponse(
            global::System.Collections.Generic.IList<global::Together.RegionListResponseRegion> regions)
        {
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionListResponse" /> class.
        /// </summary>
        public RegionListResponse()
        {
        }
    }
}