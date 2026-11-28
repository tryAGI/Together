
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationJob
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WorkflowId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJobTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.EvaluationJobType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJobStatusJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.EvaluationJobStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_updates")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Together.EvaluationJobStatusUpdate>? StatusUpdates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJob" /> class.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="type"></param>
        /// <param name="ownerId"></param>
        /// <param name="status"></param>
        /// <param name="statusUpdates"></param>
        /// <param name="parameters"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="results"></param>
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