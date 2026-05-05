
#nullable enable

namespace Together
{
    /// <summary>
    /// Additional model-specific parameters that fine-tune speech generation behavior.
    /// </summary>
    public sealed partial class AudioSpeechRequestExtraParams
    {
        /// <summary>
        /// A list of pronunciation rules for specific characters or symbols. Each entry uses the format `"&lt;source&gt;/&lt;replacement&gt;"` (e.g., `["omg/oh my god"]`) to override how the model pronounces matching tokens.<br/>
        /// Example: [omg/oh my god]
        /// </summary>
        /// <example>[omg/oh my god]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict")]
        public global::System.Collections.Generic.IList<string>? PronunciationDict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechRequestExtraParams" /> class.
        /// </summary>
        /// <param name="pronunciationDict">
        /// A list of pronunciation rules for specific characters or symbols. Each entry uses the format `"&lt;source&gt;/&lt;replacement&gt;"` (e.g., `["omg/oh my god"]`) to override how the model pronounces matching tokens.<br/>
        /// Example: [omg/oh my god]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSpeechRequestExtraParams(
            global::System.Collections.Generic.IList<string>? pronunciationDict)
        {
            this.PronunciationDict = pronunciationDict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechRequestExtraParams" /> class.
        /// </summary>
        public AudioSpeechRequestExtraParams()
        {
        }
    }
}