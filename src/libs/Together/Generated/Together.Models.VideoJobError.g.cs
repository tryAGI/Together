
#nullable enable

namespace Together
{
    /// <summary>
    /// Error payload that explains why generation failed, if applicable.
    /// </summary>
    public sealed partial class VideoJobError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoJobError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoJobError(
            string message,
            string? code)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoJobError" /> class.
        /// </summary>
        public VideoJobError()
        {
        }
    }
}