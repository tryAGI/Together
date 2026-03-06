
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSecretsResponse
    {
        /// <summary>
        /// Data is the array of secret items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Together.SecretResponseItem>? Data { get; set; }

        /// <summary>
        /// The object type, which is always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ListSecretsResponseObjectJsonConverter))]
        public global::Together.ListSecretsResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSecretsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Data is the array of secret items
        /// </param>
        /// <param name="object">
        /// The object type, which is always `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSecretsResponse(
            global::System.Collections.Generic.IList<global::Together.SecretResponseItem>? data,
            global::Together.ListSecretsResponseObject? @object)
        {
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSecretsResponse" /> class.
        /// </summary>
        public ListSecretsResponse()
        {
        }
    }
}