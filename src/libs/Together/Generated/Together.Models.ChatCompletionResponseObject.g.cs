
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `chat.completion`.
    /// </summary>
    public sealed partial class ChatCompletionResponseObject
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}