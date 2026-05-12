#nullable enable

namespace Together
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create audio generation request<br/>
        /// Generate audio from input text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.audio.speech.with_streaming_response.create(<br/>
        ///     model="cartesia/sonic-2",<br/>
        ///     input="The quick brown fox jumps over the lazy dog.",<br/>
        ///     voice="laidback woman",<br/>
        /// )<br/>
        /// with response as stream:<br/>
        ///   stream.stream_to_file("audio.wav")
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::Together.AudioSpeechStreamResponse> AudioSpeechAsync(

            global::Together.AudioSpeechRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio generation request<br/>
        /// Generate audio from input text
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Together.AudioSpeechStreamResponse> AudioSpeechAsync(
            global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string> model,
            string input,
            string voice,
            global::Together.AudioSpeechRequestResponseFormat? responseFormat = default,
            string? language = default,
            global::Together.AudioSpeechRequestResponseEncoding? responseEncoding = default,
            int? sampleRate = default,
            int? bitRate = default,
            bool? stream = default,
            global::Together.AudioSpeechRequestExtraParams? extraParams = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}