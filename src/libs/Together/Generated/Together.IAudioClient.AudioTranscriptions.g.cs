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
        /// <param name="model">
        /// Model to use for transcription<br/>
        /// Default Value: openai/whisper-large-v3
        /// </param>
        /// <param name="language">
        /// Optional ISO 639-1 language code. If `auto` is provided, language is auto-detected.<br/>
        /// Default Value: en<br/>
        /// Example: en
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
        /// Default Value: 0.0
        /// </param>
        /// <param name="timestampGranularities">
        /// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json. Can be a single granularity or an array to get multiple levels.<br/>
        /// Default Value: segment<br/>
        /// Example: [word, segment]
        /// </param>
        /// <param name="diarize">
        /// Whether to enable speaker diarization. When enabled, you will get the speaker id for each word in the transcription. In the response, in the words array, you will get the speaker id for each word. In addition, we also return the speaker_segments array which contains the speaker id for each speaker segment along with the start and end time of the segment along with all the words in the segment.   For eg - ... "speaker_segments": [<br/>
        ///   "speaker_id": "SPEAKER_00",<br/>
        ///   "start": 0,<br/>
        ///   "end": 30.02,<br/>
        ///   "words": [<br/>
        ///     {<br/>
        ///       "id": 0,<br/>
        ///       "word": "Tijana",<br/>
        ///       "start": 0,<br/>
        ///       "end": 11.475,<br/>
        ///       "speaker_id": "SPEAKER_00"<br/>
        ///     },<br/>
        ///     ...<br/>
        /// Default Value: false
        /// </param>
        /// <param name="minSpeakers">
        /// Minimum number of speakers expected in the audio. Used to improve diarization accuracy when the approximate number of speakers is known.
        /// </param>
        /// <param name="maxSpeakers">
        /// Maximum number of speakers expected in the audio. Used to improve diarization accuracy when the approximate number of speakers is known.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AudioTranscriptionResponse> AudioTranscriptionsAsync(
            global::Together.OneOf<byte[], string> file,
            global::Together.AudioTranscriptionRequestModel? model = default,
            string? language = default,
            string? prompt = default,
            global::Together.AudioTranscriptionRequestResponseFormat? responseFormat = default,
            float? temperature = default,
            global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>? timestampGranularities = default,
            bool? diarize = default,
            int? minSpeakers = default,
            int? maxSpeakers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}