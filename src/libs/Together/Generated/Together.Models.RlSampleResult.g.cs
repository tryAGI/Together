
#nullable enable

namespace Together
{
    /// <summary>
    /// Completions generated for a single model input
    /// </summary>
    public sealed partial class RlSampleResult
    {
        /// <summary>
        /// Generated completions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlSampledSequence> Sequences { get; set; }

        /// <summary>
        /// Teacher-forced log-probability of each model input token. Full prompt length; entry i corresponds to prompt token i. Entry 0 is always 0 as a placeholder: the first prompt token has no conditioning context, so it has no log-probability. Present only when prompt_logprobs was set on the request.<br/>
        /// Example: [0, -0.5, -1.2]
        /// </summary>
        /// <example>[0, -0.5, -1.2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_logprobs")]
        public global::System.Collections.Generic.IList<double>? PromptLogprobs { get; set; }

        /// <summary>
        /// The most likely alternative tokens at each model input token, up to `topk_prompt_logprobs` per position. Full prompt length; entry i corresponds to prompt token i, and entry 0 is empty. Present only when topk_prompt_logprobs was set on the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topk_prompt_logprobs")]
        public global::System.Collections.Generic.IList<global::Together.RlPromptTopLogprobs>? TopkPromptLogprobs { get; set; }

        /// <summary>
        /// Policy versions that produced these completions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlPolicyVersionSegment> PolicySegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleResult" /> class.
        /// </summary>
        /// <param name="sequences">
        /// Generated completions
        /// </param>
        /// <param name="policySegments">
        /// Policy versions that produced these completions
        /// </param>
        /// <param name="promptLogprobs">
        /// Teacher-forced log-probability of each model input token. Full prompt length; entry i corresponds to prompt token i. Entry 0 is always 0 as a placeholder: the first prompt token has no conditioning context, so it has no log-probability. Present only when prompt_logprobs was set on the request.<br/>
        /// Example: [0, -0.5, -1.2]
        /// </param>
        /// <param name="topkPromptLogprobs">
        /// The most likely alternative tokens at each model input token, up to `topk_prompt_logprobs` per position. Full prompt length; entry i corresponds to prompt token i, and entry 0 is empty. Present only when topk_prompt_logprobs was set on the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSampleResult(
            global::System.Collections.Generic.IList<global::Together.RlSampledSequence> sequences,
            global::System.Collections.Generic.IList<global::Together.RlPolicyVersionSegment> policySegments,
            global::System.Collections.Generic.IList<double>? promptLogprobs,
            global::System.Collections.Generic.IList<global::Together.RlPromptTopLogprobs>? topkPromptLogprobs)
        {
            this.Sequences = sequences ?? throw new global::System.ArgumentNullException(nameof(sequences));
            this.PromptLogprobs = promptLogprobs;
            this.TopkPromptLogprobs = topkPromptLogprobs;
            this.PolicySegments = policySegments ?? throw new global::System.ArgumentNullException(nameof(policySegments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSampleResult" /> class.
        /// </summary>
        public RlSampleResult()
        {
        }

    }
}