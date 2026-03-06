
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVolumeRequest
    {
        /// <summary>
        /// Content specifies the new content that will be preloaded to this volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Together.VolumeContentRequest? Content { get; set; }

        /// <summary>
        /// Name is the new unique identifier for the volume within the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Type is the new volume type (currently only "readOnly" is supported)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VolumeTypeJsonConverter))]
        public global::Together.VolumeType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVolumeRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// Content specifies the new content that will be preloaded to this volume
        /// </param>
        /// <param name="name">
        /// Name is the new unique identifier for the volume within the project
        /// </param>
        /// <param name="type">
        /// Type is the new volume type (currently only "readOnly" is supported)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVolumeRequest(
            global::Together.VolumeContentRequest? content,
            string? name,
            global::Together.VolumeType? type)
        {
            this.Content = content;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVolumeRequest" /> class.
        /// </summary>
        public UpdateVolumeRequest()
        {
        }
    }
}