
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlSampleBody
    {
        /// <summary>
        /// Input prompts as tokenized chunks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlModelInput> Prompts { get; set; }

        /// <summary>
        /// Optional sampling parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_params")]
        public global::Together.RlSamplingParams? SamplingParams { get; set; }

        /// <summary>
        /// Number of completions to generate per prompt<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_samples")]
        public long? NumSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBody" /> class.
        /// </summary>
        /// <param name="prompts">
        /// Input prompts as tokenized chunks
        /// </param>
        /// <param name="samplingParams">
        /// Optional sampling parameters
        /// </param>
        /// <param name="numSamples">
        /// Number of completions to generate per prompt<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleBody(
            global::System.Collections.Generic.IList<global::Together.RlModelInput> prompts,
            global::Together.RlSamplingParams? samplingParams,
            long? numSamples)
        {
            this.Prompts = prompts ?? throw new global::System.ArgumentNullException(nameof(prompts));
            this.SamplingParams = samplingParams;
            this.NumSamples = numSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBody" /> class.
        /// </summary>
        public RlSampleBody()
        {
        }
    }
}