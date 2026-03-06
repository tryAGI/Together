
#nullable enable

namespace Together
{
    /// <summary>
    /// Content specifies the new content that will be preloaded to this volume
    /// </summary>
    public sealed partial class VolumeContentRequest
    {
        /// <summary>
        /// SourcePrefix is the file path prefix for the content to be preloaded into the volume<br/>
        /// Example: models/
        /// </summary>
        /// <example>models/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_prefix")]
        public string? SourcePrefix { get; set; }

        /// <summary>
        /// Type is the content type (currently only "files" is supported which allows preloading files uploaded via Files API into the volume)<br/>
        /// Example: files
        /// </summary>
        /// <example>files</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VolumeContentRequestTypeJsonConverter))]
        public global::Together.VolumeContentRequestType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeContentRequest" /> class.
        /// </summary>
        /// <param name="sourcePrefix">
        /// SourcePrefix is the file path prefix for the content to be preloaded into the volume<br/>
        /// Example: models/
        /// </param>
        /// <param name="type">
        /// Type is the content type (currently only "files" is supported which allows preloading files uploaded via Files API into the volume)<br/>
        /// Example: files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeContentRequest(
            string? sourcePrefix,
            global::Together.VolumeContentRequestType? type)
        {
            this.SourcePrefix = sourcePrefix;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeContentRequest" /> class.
        /// </summary>
        public VolumeContentRequest()
        {
        }
    }
}