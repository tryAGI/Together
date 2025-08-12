
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioFileBinary
    {
        /// <summary>
        /// Audio file to transcribe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Data { get; set; }

        /// <summary>
        /// Audio file to transcribe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioFileBinaryTypeJsonConverter))]
        public global::Together.AudioFileBinaryType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFileBinary" /> class.
        /// </summary>
        /// <param name="data">
        /// Audio file to transcribe
        /// </param>
        /// <param name="dataname">
        /// Audio file to transcribe
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioFileBinary(
            byte[] data,
            string dataname,
            global::Together.AudioFileBinaryType type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dataname = dataname ?? throw new global::System.ArgumentNullException(nameof(dataname));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFileBinary" /> class.
        /// </summary>
        public AudioFileBinary()
        {
        }
    }
}