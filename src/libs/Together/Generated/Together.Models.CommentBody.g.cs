
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommentBody
    {
        /// <summary>
        /// Comment explaining the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentBody" /> class.
        /// </summary>
        /// <param name="comment">
        /// Comment explaining the action.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommentBody(
            string? comment)
        {
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentBody" /> class.
        /// </summary>
        public CommentBody()
        {
        }

    }
}