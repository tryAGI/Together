
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionSegment
    {
        /// <summary>
        /// Unique identifier for the segment<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Start time of the segment in seconds<br/>
        /// Example: 0.0
        /// </summary>
        /// <example>0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Start { get; set; }

        /// <summary>
        /// End time of the segment in seconds<br/>
        /// Example: 3.5
        /// </summary>
        /// <example>3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float End { get; set; }

        /// <summary>
        /// The text content of the segment<br/>
        /// Example: Hello, world!
        /// </summary>
        /// <example>Hello, world!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the segment<br/>
        /// Example: 0
        /// </param>
        /// <param name="start">
        /// Start time of the segment in seconds<br/>
        /// Example: 0.0
        /// </param>
        /// <param name="end">
        /// End time of the segment in seconds<br/>
        /// Example: 3.5
        /// </param>
        /// <param name="text">
        /// The text content of the segment<br/>
        /// Example: Hello, world!
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionSegment(
            int id,
            float start,
            float end,
            string text)
        {
            this.Id = id;
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionSegment" /> class.
        /// </summary>
        public AudioTranscriptionSegment()
        {
        }
    }
}