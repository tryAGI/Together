
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlSampleBody
    {
        /// <summary>
        /// Model inputs to sample from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlModelInput> ModelInputs { get; set; }

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
        public int? NumSamples { get; set; }

        /// <summary>
        /// When true, also compute teacher-forced log-probabilities for the model input tokens and return them in `SampleResult.prompt_logprobs`.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_logprobs")]
        public bool? PromptLogprobs { get; set; }

        /// <summary>
        /// Number of most likely alternative tokens to return per model input token in `SampleResult.topk_prompt_logprobs`. 0 disables top-k prompt log-probabilities. Maximum 20.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topk_prompt_logprobs")]
        public int? TopkPromptLogprobs { get; set; }

        /// <summary>
        /// When true, enable reuse of the expert selections from sampled sequences during training. Only supported for mixture-of-experts models; ignored for other models.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_routed_experts")]
        public bool? ReturnRoutedExperts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBody" /> class.
        /// </summary>
        /// <param name="modelInputs">
        /// Model inputs to sample from
        /// </param>
        /// <param name="samplingParams">
        /// Optional sampling parameters
        /// </param>
        /// <param name="numSamples">
        /// Number of completions to generate per prompt<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="promptLogprobs">
        /// When true, also compute teacher-forced log-probabilities for the model input tokens and return them in `SampleResult.prompt_logprobs`.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="topkPromptLogprobs">
        /// Number of most likely alternative tokens to return per model input token in `SampleResult.topk_prompt_logprobs`. 0 disables top-k prompt log-probabilities. Maximum 20.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="returnRoutedExperts">
        /// When true, enable reuse of the expert selections from sampled sequences during training. Only supported for mixture-of-experts models; ignored for other models.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleBody(
            global::System.Collections.Generic.IList<global::Together.RlModelInput> modelInputs,
            global::Together.RlSamplingParams? samplingParams,
            int? numSamples,
            bool? promptLogprobs,
            int? topkPromptLogprobs,
            bool? returnRoutedExperts)
        {
            this.ModelInputs = modelInputs ?? throw new global::System.ArgumentNullException(nameof(modelInputs));
            this.SamplingParams = samplingParams;
            this.NumSamples = numSamples;
            this.PromptLogprobs = promptLogprobs;
            this.TopkPromptLogprobs = topkPromptLogprobs;
            this.ReturnRoutedExperts = returnRoutedExperts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBody" /> class.
        /// </summary>
        public RlSampleBody()
        {
        }

    }
}