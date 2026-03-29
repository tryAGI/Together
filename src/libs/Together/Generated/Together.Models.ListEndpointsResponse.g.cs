
#nullable enable

namespace Together
{
    /// <summary>
    /// Example: {"object":"list","data":[{"object":"endpoint","id":"endpoint-5c0c20db-62fe-4f41-8ffc-d9e4ea1a264e","name":"allenai/OLMo-7B","model":"allenai/OLMo-7B","type":"serverless","owner":"together","state":"STARTED","created_at":"2024-02-28T21:34:35.444Z"}]}
    /// </summary>
    public sealed partial class ListEndpointsResponse
    {
        /// <summary>
        /// The object type, which is always `list`.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.ListEndpoint> Data { get; set; }

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
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponse" /> class.
        /// </summary>
        public ListEndpointsResponse()
        {
        }
    }
}