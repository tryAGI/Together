
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlSamplingParams
    {
        /// <summary>
        /// Maximum number of tokens to generate per completion<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Random seed for reproducibility<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public string? Seed { get; set; }

        /// <summary>
        /// Generation stops when any of these strings is produced<br/>
        /// Example: [, END]
        /// </summary>
        /// <example>[, END]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Sampling temperature<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Top-k sampling limit<br/>
        /// Default Value: -1<br/>
        /// Example: -1
        /// </summary>
        /// <example>-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Nucleus sampling probability threshold<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSamplingParams" /> class.
        /// </summary>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate per completion<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility<br/>
        /// Example: 42
        /// </param>
        /// <param name="stop">
        /// Generation stops when any of these strings is produced<br/>
        /// Example: [, END]
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </param>
        /// <param name="topK">
        /// Top-k sampling limit<br/>
        /// Default Value: -1<br/>
        /// Example: -1
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability threshold<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSamplingParams(
            int? maxTokens,
            string? seed,
            global::System.Collections.Generic.IList<string>? stop,
            float? temperature,
            int? topK,
            float? topP)
        {
            this.MaxTokens = maxTokens;
            this.Seed = seed;
            this.Stop = stop;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSamplingParams" /> class.
        /// </summary>
        public RlSamplingParams()
        {
        }
    }
}