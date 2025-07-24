
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationJob
    {
        /// <summary>
        /// When the job was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// ID of the job owner (admin only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// The parameters used for this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Results of the evaluation (when completed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>))]
        public global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>? Results { get; set; }

        /// <summary>
        /// Current status of the job<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJobStatusJsonConverter))]
        public global::Together.EvaluationJobStatus? Status { get; set; }

        /// <summary>
        /// History of status updates (admin only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_updates")]
        public global::System.Collections.Generic.IList<global::Together.EvaluationJobStatusUpdate>? StatusUpdates { get; set; }

        /// <summary>
        /// The type of evaluation<br/>
        /// Example: classify
        /// </summary>
        /// <example>classify</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJobTypeJsonConverter))]
        public global::Together.EvaluationJobType? Type { get; set; }

        /// <summary>
        /// When the job was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The evaluation job ID<br/>
        /// Example: eval-1234aedf
        /// </summary>
        /// <example>eval-1234aedf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJob" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When the job was created
        /// </param>
        /// <param name="ownerId">
        /// ID of the job owner (admin only)
        /// </param>
        /// <param name="parameters">
        /// The parameters used for this evaluation
        /// </param>
        /// <param name="results">
        /// Results of the evaluation (when completed)
        /// </param>
        /// <param name="status">
        /// Current status of the job<br/>
        /// Example: completed
        /// </param>
        /// <param name="statusUpdates">
        /// History of status updates (admin only)
        /// </param>
        /// <param name="type">
        /// The type of evaluation<br/>
        /// Example: classify
        /// </param>
        /// <param name="updatedAt">
        /// When the job was last updated
        /// </param>
        /// <param name="workflowId">
        /// The evaluation job ID<br/>
        /// Example: eval-1234aedf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationJob(
            global::System.DateTime? createdAt,
            string? ownerId,
            object? parameters,
            global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>? results,
            global::Together.EvaluationJobStatus? status,
            global::System.Collections.Generic.IList<global::Together.EvaluationJobStatusUpdate>? statusUpdates,
            global::Together.EvaluationJobType? type,
            global::System.DateTime? updatedAt,
            string? workflowId)
        {
            this.CreatedAt = createdAt;
            this.OwnerId = ownerId;
            this.Parameters = parameters;
            this.Results = results;
            this.Status = status;
            this.StatusUpdates = statusUpdates;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.WorkflowId = workflowId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJob" /> class.
        /// </summary>
        public EvaluationJob()
        {
        }
    }
}