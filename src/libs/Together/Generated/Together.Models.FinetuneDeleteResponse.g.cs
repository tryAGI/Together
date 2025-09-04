
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneDeleteResponse
    {
        /// <summary>
        /// Message indicating the result of the deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDeleteResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Message indicating the result of the deletion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuneDeleteResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDeleteResponse" /> class.
        /// </summary>
        public FinetuneDeleteResponse()
        {
        }
    }
}