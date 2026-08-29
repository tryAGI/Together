
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
        /// Default Value: 512<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Sampling temperature<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling probability threshold<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Top-k sampling limit<br/>
        /// Default Value: -1<br/>
        /// Example: -1
        /// </summary>
        /// <example>-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Generation stops when any of these strings is produced<br/>
        /// Example: [, END]
        /// </summary>
        /// <example>[, END]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Random seed for reproducible sampling for the same prompt and model state. Per-completion seeds remain stable if the request is split across generator replicas.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::Together.OneOf<string, int?>? Seed { get; set; }

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
        /// Default Value: 512<br/>
        /// Example: 512
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability threshold<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1
        /// </param>
        /// <param name="topK">
        /// Top-k sampling limit<br/>
        /// Default Value: -1<br/>
        /// Example: -1
        /// </param>
        /// <param name="stop">
        /// Generation stops when any of these strings is produced<br/>
        /// Example: [, END]
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible sampling for the same prompt and model state. Per-completion seeds remain stable if the request is split across generator replicas.<br/>
        /// Example: 42
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSamplingParams(
            int? maxTokens,
            double? temperature,
            double? topP,
            int? topK,
            global::System.Collections.Generic.IList<string>? stop,
            global::Together.OneOf<string, int?>? seed)
        {
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Stop = stop;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSamplingParams" /> class.
        /// </summary>
        public RlSamplingParams()
        {
        }

    }
}