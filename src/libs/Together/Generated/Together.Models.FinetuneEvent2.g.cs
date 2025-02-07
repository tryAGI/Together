
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneEvent2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneEventLevelsJsonConverter))]
        public global::Together.FinetuneEventLevels? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneEventObject2JsonConverter))]
        public global::Together.FinetuneEventObject2? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_count")]
        public int? ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FinetuneEventType2JsonConverter))]
        public global::Together.FinetuneEventType2? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_url")]
        public string? WandbUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneEvent2" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="hash"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="object"></param>
        /// <param name="paramCount"></param>
        /// <param name="tokenCount"></param>
        /// <param name="type"></param>
        /// <param name="wandbUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuneEvent2(
            string? createdAt,
            string? hash,
            global::Together.FinetuneEventLevels? level,
            string? message,
            global::Together.FinetuneEventObject2? @object,
            int? paramCount,
            int? tokenCount,
            global::Together.FinetuneEventType2? type,
            string? wandbUrl)
        {
            this.CreatedAt = createdAt;
            this.Hash = hash;
            this.Level = level;
            this.Message = message;
            this.Object = @object;
            this.ParamCount = paramCount;
            this.TokenCount = tokenCount;
            this.Type = type;
            this.WandbUrl = wandbUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneEvent2" /> class.
        /// </summary>
        public FinetuneEvent2()
        {
        }
    }
}