
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
        /// The evaluation job ID<br/>
        /// Example: eval-1234aedf
        /// </summary>
        /// <example>eval-1234aedf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// The type of evaluation<br/>
        /// Example: classify
        /// </summary>
        /// <example>classify</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJobTypeJsonConverter))]
        public global::Together.EvaluationJobType? Type { get; set; }

        /// <summary>
        /// ID of the job owner (admin only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

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
        /// The parameters used for this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// When the job was created<br/>
        /// Example: 2025-07-23T17:10:04.837888Z
        /// </summary>
        /// <example>2025-07-23T17:10:04.837888Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the job was last updated<br/>
        /// Example: 2025-07-23T17:10:04.837888Z
        /// </summary>
        /// <example>2025-07-23T17:10:04.837888Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Results of the evaluation (when completed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>))]
        public global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJob" /> class.
        /// </summary>
        /// <param name="workflowId">
        /// The evaluation job ID<br/>
        /// Example: eval-1234aedf
        /// </param>
        /// <param name="type">
        /// The type of evaluation<br/>
        /// Example: classify
        /// </param>
        /// <param name="ownerId">
        /// ID of the job owner (admin only)
        /// </param>
        /// <param name="status">
        /// Current status of the job<br/>
        /// Example: completed
        /// </param>
        /// <param name="statusUpdates">
        /// History of status updates (admin only)
        /// </param>
        /// <param name="parameters">
        /// The parameters used for this evaluation
        /// </param>
        /// <param name="createdAt">
        /// When the job was created<br/>
        /// Example: 2025-07-23T17:10:04.837888Z
        /// </param>
        /// <param name="updatedAt">
        /// When the job was last updated<br/>
        /// Example: 2025-07-23T17:10:04.837888Z
        /// </param>
        /// <param name="results">
        /// Results of the evaluation (when completed)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationJob(
            string? workflowId,
            global::Together.EvaluationJobType? type,
            string? ownerId,
            global::Together.EvaluationJobStatus? status,
            global::System.Collections.Generic.IList<global::Together.EvaluationJobStatusUpdate>? statusUpdates,
            object? parameters,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>? results)
        {
            this.WorkflowId = workflowId;
            this.Type = type;
            this.OwnerId = ownerId;
            this.Status = status;
            this.StatusUpdates = statusUpdates;
            this.Parameters = parameters;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJob" /> class.
        /// </summary>
        public EvaluationJob()
        {
        }
    }
}