
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadModelResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.UploadModelResponseData Data { get; set; }

        /// <summary>
        /// Example: Processing model weights. Job created.
        /// </summary>
        /// <example>Processing model weights. Job created.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message">
        /// Example: Processing model weights. Job created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadModelResponse(
            global::Together.UploadModelResponseData data,
            string message)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelResponse" /> class.
        /// </summary>
        public UploadModelResponse()
        {
        }
    }
}