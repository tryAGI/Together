#nullable enable

namespace Together
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create audio translation request<br/>
        /// Translates audio into English
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// file = open("audio.wav", "rb")<br/>
        /// response = client.audio.translations.create(<br/>
        ///     model="openai/whisper-large-v3",<br/>
        ///     file=file,<br/>
        ///     language="es",<br/>
        /// )<br/>
        /// print(response.text)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AudioTranslationResponse> AudioTranslationsAsync(

            global::Together.AudioTranslationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio translation request<br/>
        /// Translates audio into English
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// file = open("audio.wav", "rb")<br/>
        /// response = client.audio.translations.create(<br/>
        ///     model="openai/whisper-large-v3",<br/>
        ///     file=file,<br/>
        ///     language="es",<br/>
        /// )<br/>
        /// print(response.text)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.AudioTranslationResponse>> AudioTranslationsAsResponseAsync(

            global::Together.AudioTranslationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio translation request<br/>
        /// Translates audio into English
        /// </summary>
        /// <param name="file">
        /// Audio file upload or public HTTP/HTTPS URL. Supported formats: .wav, .mp3, .m4a, .webm, .flac, .ogg, .opus, .aac. Maximum duration 4 hours; longer audio is rejected with `audio_too_long`. Binary uploads are additionally capped at 80 MB (HTTP 413); URL-fetched audio is capped at 1 GB.
        /// </param>
        /// <param name="model">
        /// Model to use for translation<br/>
        /// Default Value: openai/whisper-large-v3
        /// </param>
        /// <param name="language">
        /// Target output language. Optional ISO 639-1 language code. If omitted, language is set to English.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </param>
        /// <param name="prompt">
        /// Optional text to bias decoding. Supported only on Whisper-family models (e.g. `openai/whisper-large-v3`). Other STT models (e.g. `nvidia/parakeet-tdt-0.6b-v3`) accept the field for API compatibility but ignore it.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the response<br/>
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0.0 and 1.0<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="timestampGranularities">
        /// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json. Can be a single granularity or an array to get multiple levels.<br/>
        /// Default Value: segment<br/>
        /// Example: [word, segment]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AudioTranslationResponse> AudioTranslationsAsync(
            global::Together.OneOf<byte[], string> file,
            global::Together.AudioTranslationRequestModel? model = default,
            string? language = default,
            string? prompt = default,
            global::Together.AudioTranslationRequestResponseFormat? responseFormat = default,
            double? temperature = default,
            global::Together.OneOf<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>? timestampGranularities = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}