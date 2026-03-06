
#nullable enable

namespace Together
{
    /// <summary>
    /// Example: {"data":[{"created_at":"2024-02-28T21:34:35.4440000\u002B00:00","id":"endpoint-5c0c20db-62fe-4f41-8ffc-d9e4ea1a264e","model":"allenai/OLMo-7B","name":"allenai/OLMo-7B","object":"endpoint","owner":"together","state":"STARTED","type":"serverless"}],"object":"list"}
    /// </summary>
    public sealed partial class ListEndpointsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.ListEndpoint> Data { get; set; }

        /// <summary>
        /// The object type, which is always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ListEndpointsResponseObjectJsonConverter))]
        public global::Together.ListEndpointsResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object">
        /// The object type, which is always `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndpointsResponse(
            global::System.Collections.Generic.IList<global::Together.ListEndpoint> data,
            global::Together.ListEndpointsResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponse" /> class.
        /// </summary>
        public ListEndpointsResponse()
        {
        }
    }
}