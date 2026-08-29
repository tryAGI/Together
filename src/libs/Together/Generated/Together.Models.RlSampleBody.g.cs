
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
        /// When true, capture the mixture-of-experts routing decisions made while generating and return them in `SampledSequence.routed_experts`, so training can reuse the same expert selection. Only available on mixture-of-experts models; ignored otherwise. The captured buffer scales with sequence length, so leave it off unless you replay routing during training.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_routed_experts")]
        public bool? ReturnRoutedExperts { get; set; }

        /// <summary>
        /// When true together with `return_routed_experts`, return each routing capture as a backend-owned `object_uri` plus shape instead of inline base64 data. Clients that do not opt in keep the legacy inline response.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_routed_experts_object_uri")]
        public bool? ReturnRoutedExpertsObjectUri { get; set; }

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
        /// When true, capture the mixture-of-experts routing decisions made while generating and return them in `SampledSequence.routed_experts`, so training can reuse the same expert selection. Only available on mixture-of-experts models; ignored otherwise. The captured buffer scales with sequence length, so leave it off unless you replay routing during training.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="returnRoutedExpertsObjectUri">
        /// When true together with `return_routed_experts`, return each routing capture as a backend-owned `object_uri` plus shape instead of inline base64 data. Clients that do not opt in keep the legacy inline response.<br/>
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
            bool? returnRoutedExperts,
            bool? returnRoutedExpertsObjectUri)
        {
            this.ModelInputs = modelInputs ?? throw new global::System.ArgumentNullException(nameof(modelInputs));
            this.SamplingParams = samplingParams;
            this.NumSamples = numSamples;
            this.PromptLogprobs = promptLogprobs;
            this.TopkPromptLogprobs = topkPromptLogprobs;
            this.ReturnRoutedExperts = returnRoutedExperts;
            this.ReturnRoutedExpertsObjectUri = returnRoutedExpertsObjectUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleBody" /> class.
        /// </summary>
        public RlSampleBody()
        {
        }

    }
}