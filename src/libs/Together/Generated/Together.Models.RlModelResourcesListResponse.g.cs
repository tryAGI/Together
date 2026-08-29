
#nullable enable

namespace Together
{
    /// <summary>
    /// Paginated list of model resources
    /// </summary>
    public sealed partial class RlModelResourcesListResponse
    {
        /// <summary>
        /// List of model resources
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlModelResources> Data { get; set; }

        /// <summary>
        /// Pagination metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlListMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of model resources
        /// </param>
        /// <param name="meta">
        /// Pagination metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelResourcesListResponse(
            global::System.Collections.Generic.IList<global::Together.RlModelResources> data,
            global::Together.RlListMeta meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesListResponse" /> class.
        /// </summary>
        public RlModelResourcesListResponse()
        {
        }

    }
}