
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Together.CompletionChoice> Choices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.FinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `completion.chunk`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.CompletionChunkObjectJsonConverter))]
        public global::Together.CompletionChunkObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.CompletionToken Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.UsageData? Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChunk" /> class.
        /// </summary>
        /// <param name="choices"></param>
        /// <param name="created"></param>
        /// <param name="finishReason"></param>
        /// <param name="id"></param>
        /// <param name="object">
        /// The object type, which is always `completion.chunk`.
        /// </param>
        /// <param name="seed"></param>
        /// <param name="token"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionChunk(
            global::System.Collections.Generic.IList<global::Together.CompletionChoice> choices,
            global::Together.FinishReason finishReason,
            string id,
            global::Together.CompletionToken token,
            global::Together.UsageData? usage,
            int? created,
            global::Together.CompletionChunkObject? @object,
            int? seed)
        {
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.FinishReason = finishReason;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Created = created;
            this.Object = @object;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChunk" /> class.
        /// </summary>
        public CompletionChunk()
        {
        }
    }
}