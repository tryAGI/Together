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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AudioTranslationResponse> AudioTranslationsAsync(
            global::Together.AudioTranslationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create audio translation request<br/>
        /// Translates audio into English
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AudioTranslationResponse> AudioTranslationsAsync(
            global::Together.OneOf<byte[], string> file,
            string? language = default,
            global::Together.AudioTranslationRequestModel? model = default,
            string? prompt = default,
            global::Together.AudioTranslationRequestResponseFormat? responseFormat = default,
            float? temperature = default,
            global::Together.AudioTranslationRequestTimestampGranularities? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}