
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEvaluationJobStatusAndResultsResponse
    {
        /// <summary>
        /// The results of the evaluation job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>))]
        public global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>? Results { get; set; }

        /// <summary>
        /// The status of the evaluation job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusJsonConverter))]
        public global::Together.GetEvaluationJobStatusAndResultsResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvaluationJobStatusAndResultsResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// The results of the evaluation job
        /// </param>
        /// <param name="status">
        /// The status of the evaluation job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEvaluationJobStatusAndResultsResponse(
            global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>? results,
            global::Together.GetEvaluationJobStatusAndResultsResponseStatus? status)
        {
            this.Results = results;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvaluationJobStatusAndResultsResponse" /> class.
        /// </summary>
        public GetEvaluationJobStatusAndResultsResponse()
        {
        }
    }
}