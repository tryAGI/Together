
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for updating an adapter.
    /// </summary>
    public sealed partial class DeUpdateAdapterRequest
    {
        /// <summary>
        /// New adapter revision to pin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterRevisionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterRevisionId { get; set; }

        /// <summary>
        /// Row-level etag from a prior AddAdapter, UpdateAdapter, GetAdapter, or ListAdapters response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateAdapterRequest" /> class.
        /// </summary>
        /// <param name="adapterRevisionId">
        /// New adapter revision to pin.
        /// </param>
        /// <param name="etag">
        /// Row-level etag from a prior AddAdapter, UpdateAdapter, GetAdapter, or ListAdapters response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeUpdateAdapterRequest(
            string adapterRevisionId,
            string etag)
        {
            this.AdapterRevisionId = adapterRevisionId ?? throw new global::System.ArgumentNullException(nameof(adapterRevisionId));
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateAdapterRequest" /> class.
        /// </summary>
        public DeUpdateAdapterRequest()
        {
        }

    }
}