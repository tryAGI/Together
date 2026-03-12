
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranslationVerboseJsonResponse
    {
        /// <summary>
        /// The task performed<br/>
        /// Example: translate
        /// </summary>
        /// <example>translate</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AudioTranslationVerboseJsonResponseTaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AudioTranslationVerboseJsonResponseTask Task { get; set; }

        /// <summary>
        /// The target language of the translation<br/>
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
        /// The translated text<br/>
        /// Example: Hello, world!
        /// </summary>
        /// <example>Hello, world!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Array of translation segments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSegment> Segments { get; set; }

        /// <summary>
        /// Array of translation words (only when timestamp_granularities includes 'word')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranslationVerboseJsonResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// The task performed<br/>
        /// Example: translate
        /// </param>
        /// <param name="language">
        /// The target language of the translation<br/>
        /// Example: english
        /// </param>
        /// <param name="duration">
        /// The duration of the audio in seconds<br/>
        /// Example: 3.5
        /// </param>
        /// <param name="text">
        /// The translated text<br/>
        /// Example: Hello, world!
        /// </param>
        /// <param name="segments">
        /// Array of translation segments
        /// </param>
        /// <param name="words">
        /// Array of translation words (only when timestamp_granularities includes 'word')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranslationVerboseJsonResponse(
            global::Together.AudioTranslationVerboseJsonResponseTask task,
            string language,
            float duration,
            string text,
            global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSegment> segments,
            global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord>? words)
        {
            this.Task = task;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Duration = duration;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranslationVerboseJsonResponse" /> class.
        /// </summary>
        public AudioTranslationVerboseJsonResponse()
        {
        }
    }
}