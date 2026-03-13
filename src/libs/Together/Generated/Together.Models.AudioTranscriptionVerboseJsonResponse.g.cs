
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionVerboseJsonResponse
    {
        /// <summary>
        /// The task performed<br/>
        /// Example: transcribe
        /// </summary>
        /// <example>transcribe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioTranscriptionVerboseJsonResponseTaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AudioTranscriptionVerboseJsonResponseTask Task { get; set; }

        /// <summary>
        /// The language of the audio<br/>
        /// Example: english
        /// </summary>
        /// <example>english</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The duration of the audio in seconds<br/>
        /// Example: 3.5
        /// </summary>
        /// <example>3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Duration { get; set; }

        /// <summary>
        /// The transcribed text<br/>
        /// Example: Hello, world!
        /// </summary>
        /// <example>Hello, world!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Array of transcription segments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSegment> Segments { get; set; }

        /// <summary>
        /// Array of transcription words (only when timestamp_granularities includes 'word')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Array of transcription speaker segments (only when diarize is enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_segments")]
        public global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSpeakerSegment>? SpeakerSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionVerboseJsonResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// The task performed<br/>
        /// Example: transcribe
        /// </param>
        /// <param name="language">
        /// The language of the audio<br/>
        /// Example: english
        /// </param>
        /// <param name="duration">
        /// The duration of the audio in seconds<br/>
        /// Example: 3.5
        /// </param>
        /// <param name="text">
        /// The transcribed text<br/>
        /// Example: Hello, world!
        /// </param>
        /// <param name="segments">
        /// Array of transcription segments
        /// </param>
        /// <param name="words">
        /// Array of transcription words (only when timestamp_granularities includes 'word')
        /// </param>
        /// <param name="speakerSegments">
        /// Array of transcription speaker segments (only when diarize is enabled)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionVerboseJsonResponse(
            global::Together.AudioTranscriptionVerboseJsonResponseTask task,
            string language,
            float duration,
            string text,
            global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSegment> segments,
            global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord>? words,
            global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSpeakerSegment>? speakerSegments)
        {
            this.Task = task;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Duration = duration;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Words = words;
            this.SpeakerSegments = speakerSegments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionVerboseJsonResponse" /> class.
        /// </summary>
        public AudioTranscriptionVerboseJsonResponse()
        {
        }
    }
}