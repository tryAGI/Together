
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationUpdateRequest
    {
        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>))]
        public global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>? Results { get; set; }

        /// <summary>
        /// The new status for the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationUpdateRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EvaluationUpdateRequestStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationUpdateRequest" /> class.
        /// </summary>
        /// <param name="error">
        /// Error message
        /// </param>
        /// <param name="results"></param>
        /// <param name="status">
        /// The new status for the job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationUpdateRequest(
            global::Together.EvaluationUpdateRequestStatus status,
            string? error,
            global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>? results)
        {
            this.Status = status;
            this.Error = error;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationUpdateRequest" /> class.
        /// </summary>
        public EvaluationUpdateRequest()
        {
        }
    }
}