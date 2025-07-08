
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
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float End { get; set; }

        /// <summary>
        /// Start time of the word in seconds<br/>
        /// Example: 0F
        /// </summary>
        /// <example>0F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Start { get; set; }

        /// <summary>
        /// The word<br/>
        /// Example: Hello
        /// </summary>
        /// <example>Hello</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

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
        /// Example: 0.5F
        /// </param>
        /// <param name="start">
        /// Start time of the word in seconds<br/>
        /// Example: 0F
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
            string word)
        {
            this.End = end;
            this.Start = start;
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionWord" /> class.
        /// </summary>
        public AudioTranscriptionWord()
        {
        }
    }
}