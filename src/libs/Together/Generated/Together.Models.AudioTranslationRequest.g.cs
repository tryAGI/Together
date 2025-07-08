
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranslationRequest
    {
        /// <summary>
        /// Audio file upload or public HTTP/HTTPS URL. Supported formats .wav, .mp3, .m4a, .webm, .flac.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<byte[], string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<byte[], string> File { get; set; }

        /// <summary>
        /// Target output language. Optional ISO 639-1 language code. If omitted, language is set to English.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Model to use for translation<br/>
        /// Default Value: openai/whisper-large-v3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioTranslationRequestModelJsonConverter))]
        public global::Together.AudioTranslationRequestModel? Model { get; set; }

        /// <summary>
        /// Optional text to bias decoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The format of the response<br/>
        /// Default Value: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioTranslationRequestResponseFormatJsonConverter))]
        public global::Together.AudioTranslationRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Sampling temperature between 0.0 and 1.0<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json.<br/>
        /// Default Value: segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesJsonConverter))]
        public global::Together.AudioTranslationRequestTimestampGranularities? TimestampGranularities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranslationRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Audio file upload or public HTTP/HTTPS URL. Supported formats .wav, .mp3, .m4a, .webm, .flac.
        /// </param>
        /// <param name="language">
        /// Target output language. Optional ISO 639-1 language code. If omitted, language is set to English.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </param>
        /// <param name="model">
        /// Model to use for translation<br/>
        /// Default Value: openai/whisper-large-v3
        /// </param>
        /// <param name="prompt">
        /// Optional text to bias decoding.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the response<br/>
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0.0 and 1.0<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="timestampGranularities">
        /// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json.<br/>
        /// Default Value: segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranslationRequest(
            global::Together.OneOf<byte[], string> file,
            string? language,
            global::Together.AudioTranslationRequestModel? model,
            string? prompt,
            global::Together.AudioTranslationRequestResponseFormat? responseFormat,
            float? temperature,
            global::Together.AudioTranslationRequestTimestampGranularities? timestampGranularities)
        {
            this.File = file;
            this.Language = language;
            this.Model = model;
            this.Prompt = prompt;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.TimestampGranularities = timestampGranularities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranslationRequest" /> class.
        /// </summary>
        public AudioTranslationRequest()
        {
        }
    }
}