
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsRequest
    {
        /// <summary>
        /// Example: Our solar system orbits the Milky Way galaxy at about 515,000 mph
        /// </summary>
        /// <example>Our solar system orbits the Milky Way galaxy at about 515,000 mph</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// The name of the embedding model to use.  [See all of Together AI's embedding models](https://docs.together.ai/docs/serverless-models#embedding-models)<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </summary>
        /// <example>togethercomputer/m2-bert-80M-8k-retrieval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.EmbeddingsRequestModel?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.EmbeddingsRequestModel?, string> Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Example: Our solar system orbits the Milky Way galaxy at about 515,000 mph
        /// </param>
        /// <param name="model">
        /// The name of the embedding model to use.  [See all of Together AI's embedding models](https://docs.together.ai/docs/serverless-models#embedding-models)<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EmbeddingsRequest(
            global::Together.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::Together.AnyOf<global::Together.EmbeddingsRequestModel?, string> model)
        {
            this.Input = input;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        public EmbeddingsRequest()
        {
        }
    }
}