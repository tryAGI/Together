
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlSampleBody
    {
        /// <summary>
        /// Number of completions to generate for this prompt<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_samples")]
        public long? NumSamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.RlModelInput Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_params")]
        public global::Together.RlSamplingParams? SamplingParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBody" /> class.
        /// </summary>
        /// <param name="numSamples">
        /// Number of completions to generate for this prompt<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="samplingParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleBody(
            global::Together.RlModelInput prompt,
            long? numSamples,
            global::Together.RlSamplingParams? samplingParams)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NumSamples = numSamples;
            this.SamplingParams = samplingParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBody" /> class.
        /// </summary>
        public RlSampleBody()
        {
        }
    }
}