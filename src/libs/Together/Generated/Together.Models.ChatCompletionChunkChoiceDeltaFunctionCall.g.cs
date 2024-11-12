
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ChatCompletionChunkChoiceDeltaFunctionCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoiceDeltaFunctionCall" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="name"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionChunkChoiceDeltaFunctionCall(
            string arguments,
            string name)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoiceDeltaFunctionCall" /> class.
        /// </summary>
        public ChatCompletionChunkChoiceDeltaFunctionCall()
        {
        }
    }
}