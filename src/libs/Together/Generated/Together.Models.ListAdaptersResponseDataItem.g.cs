
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAdaptersResponseDataItem
    {
        /// <summary>
        /// Combined endpoint:adapter identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_name")]
        public string? AdapterName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_name")]
        public string? EndpointName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAdaptersResponseDataItem" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Combined endpoint:adapter identifier
        /// </param>
        /// <param name="adapterName"></param>
        /// <param name="endpointName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAdaptersResponseDataItem(
            string? modelId,
            string? adapterName,
            string? endpointName)
        {
            this.ModelId = modelId;
            this.AdapterName = adapterName;
            this.EndpointName = endpointName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAdaptersResponseDataItem" /> class.
        /// </summary>
        public ListAdaptersResponseDataItem()
        {
        }

    }
}