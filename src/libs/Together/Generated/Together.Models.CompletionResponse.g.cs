
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionResponse
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
        public required global::System.Collections.Generic.IList<global::Together.CompletionChoicesDataItem> Choices { get; set; }

        /// <summary>
        /// When `echo` is true, the prompt is included in the response. Additionally, when `logprobs` is also provided, log probability information is provided on the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.PromptPartItem> Prompt { get; set; }

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
        /// The object type, which is always `text.completion`.
        /// </summary>
        /// <default>"text.completion"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "text.completion";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="choices"></param>
        /// <param name="prompt">
        /// When `echo` is true, the prompt is included in the response. Additionally, when `logprobs` is also provided, log probability information is provided on the prompt.
        /// </param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="usage"></param>
        /// <param name="object">
        /// The object type, which is always `text.completion`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionResponse(
            string id,
            global::System.Collections.Generic.IList<global::Together.CompletionChoicesDataItem> choices,
            global::System.Collections.Generic.IList<global::Together.PromptPartItem> prompt,
            int created,
            string model,
            global::Together.UsageData? usage,
            string @object = "text.completion")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Usage = usage;
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        public CompletionResponse()
        {
        }
    }
}