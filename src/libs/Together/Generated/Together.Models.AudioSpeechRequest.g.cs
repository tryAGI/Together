
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioSpeechRequest
    {
        /// <summary>
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#audio-models) The current supported tts models are: - cartesia/sonic - hexgrad/Kokoro-82M - canopylabs/orpheus-3b-0.1-ft<br/>
        /// Example: canopylabs/orpheus-3b-0.1-ft
        /// </summary>
        /// <example>canopylabs/orpheus-3b-0.1-ft</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.AudioSpeechRequestModel?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string> Model { get; set; }

        /// <summary>
        /// Input text to generate the audio for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The voice to use for generating the audio. The voices supported are different for each model. For eg - for canopylabs/orpheus-3b-0.1-ft, one of the voices supported is tara, for hexgrad/Kokoro-82M, one of the voices supported is af_alloy and for cartesia/sonic, one of the voices supported is "friendly sidekick".   You can view the voices supported for each model using the /v1/voices endpoint sending the model name as the query parameter. [View all supported voices here](https://docs.together.ai/docs/text-to-speech#supported-voices).   `hexgrad/Kokoro-82M` additionally supports voice mixing, where two or more voices are combined into a single blended voice by joining their names with `+` (e.g. `af_bella+af_heart`). Optional per-voice weights can be provided in parentheses (e.g. `af_bella(2)+af_heart(1)`). Other models require a single voice name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// The format of audio output. Supported formats are mp3, wav, raw if streaming is false. If streaming is true, the only supported format is raw.<br/>
        /// Default Value: wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioSpeechRequestResponseFormatJsonConverter))]
        public global::Together.AudioSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Language or locale of input text. Accepts ISO 639-1 language codes (e.g., `en`, `fr`, `es`, `zh`) as well as locale codes for region-specific variants. Locale codes must be lowercase (e.g., `zh-hk` for Cantonese).<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Audio encoding of response. Only applicable when response_format is raw or pcm. Cartesia models respect this parameter and support all values. Orpheus, Kokoro, and Minimax models always return pcm_s16le regardless of this setting.<br/>
        /// Default Value: pcm_f32le
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioSpeechRequestResponseEncodingJsonConverter))]
        public global::Together.AudioSpeechRequestResponseEncoding? ResponseEncoding { get; set; }

        /// <summary>
        /// Sampling rate in Hz for the output audio. Cartesia and Minimax models respect this parameter. Orpheus and Kokoro models always output at 24000 Hz regardless of this setting.<br/>
        /// Default Value: 44100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Bitrate of the MP3 audio output in bits per second. Only applicable when response_format is mp3. Higher values produce better audio quality at larger file sizes. Default is 128000. Currently supported on Cartesia models.<br/>
        /// Default Value: 128000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_rate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// If true, output is streamed for several characters at a time instead of waiting for the full response. The stream terminates with `data: [DONE]`. If false, return the encoded audio as octet stream<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional model-specific parameters that fine-tune speech generation behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public global::Together.AudioSpeechRequestExtraParams? ExtraParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the model to query.  [See all of Together AI's chat models](https://docs.together.ai/docs/serverless-models#audio-models) The current supported tts models are: - cartesia/sonic - hexgrad/Kokoro-82M - canopylabs/orpheus-3b-0.1-ft<br/>
        /// Example: canopylabs/orpheus-3b-0.1-ft
        /// </param>
        /// <param name="input">
        /// Input text to generate the audio for
        /// </param>
        /// <param name="voice">
        /// The voice to use for generating the audio. The voices supported are different for each model. For eg - for canopylabs/orpheus-3b-0.1-ft, one of the voices supported is tara, for hexgrad/Kokoro-82M, one of the voices supported is af_alloy and for cartesia/sonic, one of the voices supported is "friendly sidekick".   You can view the voices supported for each model using the /v1/voices endpoint sending the model name as the query parameter. [View all supported voices here](https://docs.together.ai/docs/text-to-speech#supported-voices).   `hexgrad/Kokoro-82M` additionally supports voice mixing, where two or more voices are combined into a single blended voice by joining their names with `+` (e.g. `af_bella+af_heart`). Optional per-voice weights can be provided in parentheses (e.g. `af_bella(2)+af_heart(1)`). Other models require a single voice name.
        /// </param>
        /// <param name="responseFormat">
        /// The format of audio output. Supported formats are mp3, wav, raw if streaming is false. If streaming is true, the only supported format is raw.<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="language">
        /// Language or locale of input text. Accepts ISO 639-1 language codes (e.g., `en`, `fr`, `es`, `zh`) as well as locale codes for region-specific variants. Locale codes must be lowercase (e.g., `zh-hk` for Cantonese).<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </param>
        /// <param name="responseEncoding">
        /// Audio encoding of response. Only applicable when response_format is raw or pcm. Cartesia models respect this parameter and support all values. Orpheus, Kokoro, and Minimax models always return pcm_s16le regardless of this setting.<br/>
        /// Default Value: pcm_f32le
        /// </param>
        /// <param name="sampleRate">
        /// Sampling rate in Hz for the output audio. Cartesia and Minimax models respect this parameter. Orpheus and Kokoro models always output at 24000 Hz regardless of this setting.<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="bitRate">
        /// Bitrate of the MP3 audio output in bits per second. Only applicable when response_format is mp3. Higher values produce better audio quality at larger file sizes. Default is 128000. Currently supported on Cartesia models.<br/>
        /// Default Value: 128000
        /// </param>
        /// <param name="stream">
        /// If true, output is streamed for several characters at a time instead of waiting for the full response. The stream terminates with `data: [DONE]`. If false, return the encoded audio as octet stream<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extraParams">
        /// Additional model-specific parameters that fine-tune speech generation behavior.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSpeechRequest(
            global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string> model,
            string input,
            string voice,
            global::Together.AudioSpeechRequestResponseFormat? responseFormat,
            string? language,
            global::Together.AudioSpeechRequestResponseEncoding? responseEncoding,
            int? sampleRate,
            int? bitRate,
            bool? stream,
            global::Together.AudioSpeechRequestExtraParams? extraParams)
        {
            this.Model = model;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.ResponseFormat = responseFormat;
            this.Language = language;
            this.ResponseEncoding = responseEncoding;
            this.SampleRate = sampleRate;
            this.BitRate = bitRate;
            this.Stream = stream;
            this.ExtraParams = extraParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechRequest" /> class.
        /// </summary>
        public AudioSpeechRequest()
        {
        }
    }
}