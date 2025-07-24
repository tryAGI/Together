
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationResponse
    {
        /// <summary>
        /// Initial status of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationResponseStatusJsonConverter))]
        public global::Together.EvaluationResponseStatus? Status { get; set; }

        /// <summary>
        /// The ID of the created evaluation job<br/>
        /// Example: eval-1234-1244513
        /// </summary>
        /// <example>eval-1234-1244513</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Initial status of the job
        /// </param>
        /// <param name="workflowId">
        /// The ID of the created evaluation job<br/>
        /// Example: eval-1234-1244513
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationResponse(
            global::Together.EvaluationResponseStatus? status,
            string? workflowId)
        {
            this.Status = status;
            this.WorkflowId = workflowId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        public EvaluationResponse()
        {
        }
    }
}