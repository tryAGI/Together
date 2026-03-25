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
        /// The voice to use for generating the audio. The voices supported are different for each model. For eg - for canopylabs/orpheus-3b-0.1-ft, one of the voices supported is tara, for hexgrad/Kokoro-82M, one of the voices supported is af_alloy and for cartesia/sonic, one of the voices supported is "friendly sidekick".   You can view the voices supported for each model using the /v1/voices endpoint sending the model name as the query parameter. [View all supported voices here](https://docs.together.ai/docs/text-to-speech#supported-voices).
        /// </param>
        /// <param name="responseFormat">
        /// The format of audio output. Supported formats are mp3, wav, raw if streaming is false. If streaming is true, the only supported format is raw.<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="language">
        /// Language of input text.<br/>
        /// Default Value: en
        /// </param>
        /// <param name="responseEncoding">
        /// Audio encoding of response<br/>
        /// Default Value: pcm_f32le
        /// </param>
        /// <param name="sampleRate">
        /// Sampling rate to use for the output audio. The default sampling rate for canopylabs/orpheus-3b-0.1-ft and hexgrad/Kokoro-82M is 24000 and for cartesia/sonic is 44100.<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="stream">
        /// If true, output is streamed for several characters at a time instead of waiting for the full response. The stream terminates with `data: [DONE]`. If false, return the encoded audio as octet stream<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Together.AudioSpeechStreamResponse> AudioSpeechAsync(
            global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string> model,
            string input,
            string voice,
            global::Together.AudioSpeechRequestResponseFormat? responseFormat = default,
            global::Together.AudioSpeechRequestLanguage? language = default,
            global::Together.AudioSpeechRequestResponseEncoding? responseEncoding = default,
            int? sampleRate = default,
            bool? stream = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}