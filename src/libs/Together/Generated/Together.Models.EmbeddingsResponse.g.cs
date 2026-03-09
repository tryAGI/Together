
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsResponse
    {
        /// <summary>
        /// The object type, which is always `list`.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; } = "list";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.EmbeddingsResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `list`.
        /// </param>
        /// <param name="model"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsResponse(
            string @object,
            string model,
            global::System.Collections.Generic.IList<global::Together.EmbeddingsResponseDataItem> data)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponse" /> class.
        /// </summary>
        public EmbeddingsResponse()
        {
        }
    }
}