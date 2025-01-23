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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> AudioSpeechAsync(
            global::Together.AudioSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create audio generation request<br/>
        /// Generate audio from input text
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> AudioSpeechAsync(
            string input,
            global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string> model,
            global::Together.AnyOf<global::Together.AudioSpeechRequestVoice?, string> voice,
            global::Together.AudioSpeechRequestLanguage? language = default,
            global::Together.AudioSpeechRequestResponseEncoding? responseEncoding = default,
            global::Together.AudioSpeechRequestResponseFormat? responseFormat = default,
            double? sampleRate = default,
            bool? stream = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}