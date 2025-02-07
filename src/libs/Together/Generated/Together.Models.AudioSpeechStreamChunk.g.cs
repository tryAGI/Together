
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioSpeechStreamChunk
    {
        /// <summary>
        /// base64 encoded audio stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64 { get; set; }

        /// <summary>
        /// Example: cartesia/sonic
        /// </summary>
        /// <example>cartesia/sonic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioSpeechStreamChunkObjectJsonConverter))]
        public global::Together.AudioSpeechStreamChunkObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechStreamChunk" /> class.
        /// </summary>
        /// <param name="b64">
        /// base64 encoded audio stream
        /// </param>
        /// <param name="model">
        /// Example: cartesia/sonic
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSpeechStreamChunk(
            string b64,
            string model,
            global::Together.AudioSpeechStreamChunkObject @object)
        {
            this.B64 = b64 ?? throw new global::System.ArgumentNullException(nameof(b64));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechStreamChunk" /> class.
        /// </summary>
        public AudioSpeechStreamChunk()
        {
        }
    }
}