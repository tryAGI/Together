
#nullable enable

namespace Together
{
    /// <summary>
    /// Structured information describing a generated video job.
    /// </summary>
    public sealed partial class VideoJob
    {
        /// <summary>
        /// Unique identifier for the video job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The video generation model that produced the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Current lifecycle status of the video job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VideoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.VideoStatus Status { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) for when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) for when the job completed, if finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// The resolution of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Size { get; set; }

        /// <summary>
        /// Duration of the generated clip in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Seconds { get; set; }

        /// <summary>
        /// Error payload that explains why generation failed, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.VideoJobError? Error { get; set; }

        /// <summary>
        /// Available upon completion, the outputs provides the cost charged and the hosted url to access the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::Together.VideoJobOutputs? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the video job.
        /// </param>
        /// <param name="model">
        /// The video generation model that produced the job.
        /// </param>
        /// <param name="status">
        /// Current lifecycle status of the video job.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (seconds) for when the job was created.
        /// </param>
        /// <param name="size">
        /// The resolution of the generated video.
        /// </param>
        /// <param name="seconds">
        /// Duration of the generated clip in seconds.
        /// </param>
        /// <param name="object">
        /// The object type, which is always video.
        /// </param>
        /// <param name="completedAt">
        /// Unix timestamp (seconds) for when the job completed, if finished.
        /// </param>
        /// <param name="error">
        /// Error payload that explains why generation failed, if applicable.
        /// </param>
        /// <param name="outputs">
        /// Available upon completion, the outputs provides the cost charged and the hosted url to access the video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoJob(
            string id,
            string model,
            global::Together.VideoStatus status,
            double createdAt,
            string size,
            string seconds,
            string? @object,
            double? completedAt,
            global::Together.VideoJobError? error,
            global::Together.VideoJobOutputs? outputs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.Seconds = seconds ?? throw new global::System.ArgumentNullException(nameof(seconds));
            this.Error = error;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoJob" /> class.
        /// </summary>
        public VideoJob()
        {
        }
    }
}