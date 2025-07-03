
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageResponseDataUrl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ImageResponseDataUrlTypeJsonConverter))]
        public global::Together.ImageResponseDataUrlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseDataUrl" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageResponseDataUrl(
            int index,
            string url,
            global::Together.ImageResponseDataUrlType type)
        {
            this.Index = index;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseDataUrl" /> class.
        /// </summary>
        public ImageResponseDataUrl()
        {
        }
    }
}