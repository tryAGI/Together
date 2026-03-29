
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.ChatCompletionChoicesDataItem> Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Together.UsageData? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// When `echo` is true, the prompt is included in the response. Additionally, when `logprobs` is also provided, log probability information is provided on the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.PromptPartItem> Prompt { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion`.
        /// </summary>
        /// <default>"chat.completion"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "chat.completion";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Together.InferenceWarning>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="choices"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="prompt">
        /// When `echo` is true, the prompt is included in the response. Additionally, when `logprobs` is also provided, log probability information is provided on the prompt.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="warnings"></param>
        /// <param name="object">
        /// The object type, which is always `chat.completion`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponse(
            string id,
            global::System.Collections.Generic.IList<global::Together.ChatCompletionChoicesDataItem> choices,
            int created,
            string model,
            global::System.Collections.Generic.IList<global::Together.PromptPartItem> prompt,
            global::Together.UsageData? usage,
            global::System.Collections.Generic.IList<global::Together.InferenceWarning>? warnings,
            string @object = "chat.completion")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage;
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Object = @object;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }
    }
}