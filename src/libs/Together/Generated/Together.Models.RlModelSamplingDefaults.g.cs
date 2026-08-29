
#nullable enable

namespace Together
{
    /// <summary>
    /// Default sampling parameters used for a Sample request.
    /// </summary>
    public sealed partial class RlModelSamplingDefaults
    {
        /// <summary>
        /// Number of completions per prompt<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int N { get; set; }

        /// <summary>
        /// Maximum tokens generated per completion<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        /// Sampling temperature<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// Number of logprobs to return per token<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelSamplingDefaults" /> class.
        /// </summary>
        /// <param name="n">
        /// Number of completions per prompt<br/>
        /// Example: 1
        /// </param>
        /// <param name="maxTokens">
        /// Maximum tokens generated per completion<br/>
        /// Example: 512
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature<br/>
        /// Example: 1
        /// </param>
        /// <param name="logprobs">
        /// Number of logprobs to return per token<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelSamplingDefaults(
            int n,
            int maxTokens,
            double temperature,
            int logprobs)
        {
            this.N = n;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelSamplingDefaults" /> class.
        /// </summary>
        public RlModelSamplingDefaults()
        {
        }

    }
}