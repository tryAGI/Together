
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionSpeakerSegment
    {
        /// <summary>
        /// End time of the speaker segment in seconds<br/>
        /// Example: 30.02
        /// </summary>
        /// <example>30.02</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float End { get; set; }

        /// <summary>
        /// Unique identifier for the speaker segment<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The speaker identifier<br/>
        /// Example: SPEAKER_00
        /// </summary>
        /// <example>SPEAKER_00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeakerId { get; set; }

        /// <summary>
        /// Start time of the speaker segment in seconds<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Start { get; set; }

        /// <summary>
        /// The full text spoken by this speaker in this segment<br/>
        /// Example: Hello, how are you doing today?
        /// </summary>
        /// <example>Hello, how are you doing today?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Array of words spoken by this speaker in this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionSpeakerSegment" /> class.
        /// </summary>
        /// <param name="end">
        /// End time of the speaker segment in seconds<br/>
        /// Example: 30.02
        /// </param>
        /// <param name="id">
        /// Unique identifier for the speaker segment<br/>
        /// Example: 1
        /// </param>
        /// <param name="speakerId">
        /// The speaker identifier<br/>
        /// Example: SPEAKER_00
        /// </param>
        /// <param name="start">
        /// Start time of the speaker segment in seconds<br/>
        /// Example: 0
        /// </param>
        /// <param name="text">
        /// The full text spoken by this speaker in this segment<br/>
        /// Example: Hello, how are you doing today?
        /// </param>
        /// <param name="words">
        /// Array of words spoken by this speaker in this segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionSpeakerSegment(
            float end,
            int id,
            string speakerId,
            float start,
            string text,
            global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord> words)
        {
            this.End = end;
            this.Id = id;
            this.SpeakerId = speakerId ?? throw new global::System.ArgumentNullException(nameof(speakerId));
            this.Start = start;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionSpeakerSegment" /> class.
        /// </summary>
        public AudioTranscriptionSpeakerSegment()
        {
        }
    }
}