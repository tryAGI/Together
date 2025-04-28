
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteRequestFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Encoding of the file content. Use `string` for text files such as code, and `base64` for binary files, such as images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ExecuteRequestFileEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ExecuteRequestFileEncoding Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteRequestFile" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encoding">
        /// Encoding of the file content. Use `string` for text files such as code, and `base64` for binary files, such as images.
        /// </param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteRequestFile(
            string content,
            global::Together.ExecuteRequestFileEncoding encoding,
            string name)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Encoding = encoding;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteRequestFile" /> class.
        /// </summary>
        public ExecuteRequestFile()
        {
        }
    }
}