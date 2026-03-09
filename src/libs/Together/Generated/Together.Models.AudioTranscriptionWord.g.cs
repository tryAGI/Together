
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionWord
    {
        /// <summary>
        /// End time of the word in seconds<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public float End { get; set; } = default!;

        /// <summary>
        /// The speaker id for the word (only when diarize is enabled)<br/>
        /// Example: SPEAKER_00
        /// </summary>
        /// <example>SPEAKER_00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// Start time of the word in seconds<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public float Start { get; set; } = default!;

        /// <summary>
        /// The word<br/>
        /// Example: Hello
        /// </summary>
        /// <example>Hello</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Word { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionWord" /> class.
        /// </summary>
        /// <param name="end">
        /// End time of the word in seconds<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="speakerId">
        /// The speaker id for the word (only when diarize is enabled)<br/>
        /// Example: SPEAKER_00
        /// </param>
        /// <param name="start">
        /// Start time of the word in seconds<br/>
        /// Example: 0
        /// </param>
        /// <param name="word">
        /// The word<br/>
        /// Example: Hello
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionWord(
            float end,
            float start,
            string word,
            string? speakerId)
        {
            this.End = end;
            this.Start = start;
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.SpeakerId = speakerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionWord" /> class.
        /// </summary>
        public AudioTranscriptionWord()
        {
        }
    }
}