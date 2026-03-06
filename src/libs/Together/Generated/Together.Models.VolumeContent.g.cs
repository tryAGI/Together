
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VolumeContent
    {
        /// <summary>
        /// Files is the list of files that will be preloaded into the volume, if the volume content type is "files"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Together.FileInfo>? Files { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VolumeContentTypeJsonConverter))]
        public global::Together.VolumeContentType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeContent" /> class.
        /// </summary>
        /// <param name="files">
        /// Files is the list of files that will be preloaded into the volume, if the volume content type is "files"
        /// </param>
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
        public VolumeContent(
            global::System.Collections.Generic.IList<global::Together.FileInfo>? files,
            string? sourcePrefix,
            global::Together.VolumeContentType? type)
        {
            this.Files = files;
            this.SourcePrefix = sourcePrefix;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeContent" /> class.
        /// </summary>
        public VolumeContent()
        {
        }
    }
}