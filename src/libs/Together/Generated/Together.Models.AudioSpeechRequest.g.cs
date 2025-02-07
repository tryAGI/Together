
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioSpeechRequest
    {
        /// <summary>
        /// Input text to generate the audio for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Language of input text<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioSpeechRequestLanguageJsonConverter))]
        public global::Together.AudioSpeechRequestLanguage? Language { get; set; }

        /// <summary>
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#audio-models)<br/>
        /// Example: cartesia/sonic
        /// </summary>
        /// <example>cartesia/sonic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.AudioSpeechRequestModel?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string> Model { get; set; }

        /// <summary>
        /// Audio encoding of response<br/>
        /// Default Value: pcm_f32le
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioSpeechRequestResponseEncodingJsonConverter))]
        public global::Together.AudioSpeechRequestResponseEncoding? ResponseEncoding { get; set; }

        /// <summary>
        /// The format of audio output<br/>
        /// Default Value: wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioSpeechRequestResponseFormatJsonConverter))]
        public global::Together.AudioSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Sampling rate to use for the output audio<br/>
        /// Default Value: 44100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// If true, output is streamed for several characters at a time instead of waiting for the full response. The stream terminates with `data: [DONE]`. If false, return the encoded audio as octet stream<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The voice to use for generating the audio. [View all supported voices here](https://docs.together.ai/docs/text-to-speech#voices-available).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.AudioSpeechRequestVoice?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.AudioSpeechRequestVoice?, string> Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Input text to generate the audio for
        /// </param>
        /// <param name="language">
        /// Language of input text<br/>
        /// Default Value: en
        /// </param>
        /// <param name="model">
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#audio-models)<br/>
        /// Example: cartesia/sonic
        /// </param>
        /// <param name="responseEncoding">
        /// Audio encoding of response<br/>
        /// Default Value: pcm_f32le
        /// </param>
        /// <param name="responseFormat">
        /// The format of audio output<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="sampleRate">
        /// Sampling rate to use for the output audio<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="stream">
        /// If true, output is streamed for several characters at a time instead of waiting for the full response. The stream terminates with `data: [DONE]`. If false, return the encoded audio as octet stream<br/>
        /// Default Value: false
        /// </param>
        /// <param name="voice">
        /// The voice to use for generating the audio. [View all supported voices here](https://docs.together.ai/docs/text-to-speech#voices-available).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSpeechRequest(
            string input,
            global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string> model,
            global::Together.AnyOf<global::Together.AudioSpeechRequestVoice?, string> voice,
            global::Together.AudioSpeechRequestLanguage? language,
            global::Together.AudioSpeechRequestResponseEncoding? responseEncoding,
            global::Together.AudioSpeechRequestResponseFormat? responseFormat,
            double? sampleRate,
            bool? stream)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.Voice = voice;
            this.Language = language;
            this.ResponseEncoding = responseEncoding;
            this.ResponseFormat = responseFormat;
            this.SampleRate = sampleRate;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechRequest" /> class.
        /// </summary>
        public AudioSpeechRequest()
        {
        }
    }
}