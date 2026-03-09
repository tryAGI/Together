
#nullable enable

namespace Together
{
    /// <summary>
    /// Structured information describing a generated video job.
    /// </summary>
    public sealed partial class VideoJob
    {
        /// <summary>
        /// Unix timestamp (seconds) for when the job completed, if finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) for when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// Error payload that explains why generation failed, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.VideoJobError? Error { get; set; }

        /// <summary>
        /// Unique identifier for the video job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The video generation model that produced the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The object type, which is always video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VideoJobObjectJsonConverter))]
        public global::Together.VideoJobObject? Object { get; set; }

        /// <summary>
        /// Available upon completion, the outputs provides the cost charged and the hosted url to access the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::Together.VideoJobOutputs? Outputs { get; set; }

        /// <summary>
        /// Duration of the generated clip in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Seconds { get; set; } = default!;

        /// <summary>
        /// The resolution of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Size { get; set; } = default!;

        /// <summary>
        /// Current lifecycle status of the video job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VideoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.VideoStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoJob" /> class.
        /// </summary>
        /// <param name="completedAt">
        /// Unix timestamp (seconds) for when the job completed, if finished.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (seconds) for when the job was created.
        /// </param>
        /// <param name="error">
        /// Error payload that explains why generation failed, if applicable.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the video job.
        /// </param>
        /// <param name="model">
        /// The video generation model that produced the job.
        /// </param>
        /// <param name="object">
        /// The object type, which is always video.
        /// </param>
        /// <param name="outputs">
        /// Available upon completion, the outputs provides the cost charged and the hosted url to access the video
        /// </param>
        /// <param name="seconds">
        /// Duration of the generated clip in seconds.
        /// </param>
        /// <param name="size">
        /// The resolution of the generated video.
        /// </param>
        /// <param name="status">
        /// Current lifecycle status of the video job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoJob(
            double createdAt,
            string id,
            string model,
            string seconds,
            string size,
            global::Together.VideoStatus status,
            double? completedAt,
            global::Together.VideoJobError? error,
            global::Together.VideoJobObject? @object,
            global::Together.VideoJobOutputs? outputs)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Seconds = seconds ?? throw new global::System.ArgumentNullException(nameof(seconds));
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.Status = status;
            this.CompletedAt = completedAt;
            this.Error = error;
            this.Object = @object;
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