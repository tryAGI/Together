
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionRequest
    {
        /// <summary>
        /// Audio file upload or public HTTP/HTTPS URL. Supported formats .wav, .mp3, .m4a, .webm, .flac.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<byte[], string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<byte[], string> File { get; set; }

        /// <summary>
        /// Model to use for transcription<br/>
        /// Default Value: openai/whisper-large-v3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioTranscriptionRequestModelJsonConverter))]
        public global::Together.AudioTranscriptionRequestModel? Model { get; set; }

        /// <summary>
        /// Optional ISO 639-1 language code. If `auto` is provided, language is auto-detected.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatJsonConverter))]
        public global::Together.AudioTranscriptionRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Sampling temperature between 0.0 and 1.0<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json. Can be a single granularity or an array to get multiple levels.<br/>
        /// Default Value: segment<br/>
        /// Example: [word, segment]
        /// </summary>
        /// <example>[word, segment]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>))]
        public global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>? TimestampGranularities { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarize")]
        public bool? Diarize { get; set; }

        /// <summary>
        /// Minimum number of speakers expected in the audio. Used to improve diarization accuracy when the approximate number of speakers is known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_speakers")]
        public int? MinSpeakers { get; set; }

        /// <summary>
        /// Maximum number of speakers expected in the audio. Used to improve diarization accuracy when the approximate number of speakers is known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_speakers")]
        public int? MaxSpeakers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionRequest(
            global::Together.OneOf<byte[], string> file,
            global::Together.AudioTranscriptionRequestModel? model,
            string? language,
            string? prompt,
            global::Together.AudioTranscriptionRequestResponseFormat? responseFormat,
            float? temperature,
            global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>? timestampGranularities,
            bool? diarize,
            int? minSpeakers,
            int? maxSpeakers)
        {
            this.File = file;
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.TimestampGranularities = timestampGranularities;
            this.Diarize = diarize;
            this.MinSpeakers = minSpeakers;
            this.MaxSpeakers = maxSpeakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequest" /> class.
        /// </summary>
        public AudioTranscriptionRequest()
        {
        }
    }
}