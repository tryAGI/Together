#nullable enable

namespace Together
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create audio transcription request<br/>
        /// Transcribes audio into text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AudioTranscriptionResponse> AudioTranscriptionsAsync(
            global::Together.AudioTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create audio transcription request<br/>
        /// Transcribes audio into text
        /// </summary>
        /// <param name="file">
        /// Audio file upload or public HTTP/HTTPS URL. Supported formats .wav, .mp3, .m4a, .webm, .flac.
        /// </param>
        /// <param name="language">
        /// Optional ISO 639-1 language code. If `auto` is provided, language is auto-detected.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </param>
        /// <param name="model">
        /// Model to use for transcription<br/>
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
        /// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json. Can be a single granularity or an array to get multiple levels.<br/>
        /// Default Value: segment<br/>
        /// Example: word
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AudioTranscriptionResponse> AudioTranscriptionsAsync(
            global::Together.File file,
            string? language = default,
            global::Together.AudioTranscriptionRequestModel? model = default,
            string? prompt = default,
            global::Together.AudioTranscriptionRequestResponseFormat? responseFormat = default,
            float? temperature = default,
            global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}