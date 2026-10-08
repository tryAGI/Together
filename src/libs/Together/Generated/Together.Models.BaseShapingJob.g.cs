
#nullable enable

namespace Together
{
    /// <summary>
    /// Public fields common to shaping jobs.
    /// </summary>
    public sealed partial class BaseShapingJob
    {
        /// <summary>
        /// Unique shaping job ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of shaping job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ShapingJobTypeJsonConverter))]
        public global::Together.ShapingJobType JobType { get; set; }

        /// <summary>
        /// Current job status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ShapingJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ShapingJobStatus Status { get; set; }

        /// <summary>
        /// Time when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time when the job was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// User that created the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseShapingJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique shaping job ID.
        /// </param>
        /// <param name="status">
        /// Current job status.
        /// </param>
        /// <param name="createdAt">
        /// Time when the job was created.
        /// </param>
        /// <param name="updatedAt">
        /// Time when the job was last updated.
        /// </param>
        /// <param name="userId">
        /// User that created the job.
        /// </param>
        /// <param name="jobType">
        /// Type of shaping job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseShapingJob(
            string id,
            global::Together.ShapingJobStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string userId,
            global::Together.ShapingJobType jobType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.JobType = jobType;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseShapingJob" /> class.
        /// </summary>
        public BaseShapingJob()
        {
        }

    }
}