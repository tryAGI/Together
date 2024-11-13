
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// List of documents, which can be either strings or objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> Documents { get; set; }

        /// <summary>
        /// The model to be used for the rerank request.  [See all of Together AI's rerank models](https://docs.together.ai/docs/serverless-models#rerank-models)<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </summary>
        /// <example>Salesforce/Llama-Rank-V1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.RerankRequestModel?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.RerankRequestModel?, string> Model { get; set; }

        /// <summary>
        /// The search query to be used for ranking.<br/>
        /// Example: What animals can I find near Peru?
        /// </summary>
        /// <example>What animals can I find near Peru?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </summary>
        /// <example>[title, text]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="documents">
        /// List of documents, which can be either strings or objects.
        /// </param>
        /// <param name="model">
        /// The model to be used for the rerank request.  [See all of Together AI's rerank models](https://docs.together.ai/docs/serverless-models#rerank-models)<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </param>
        /// <param name="query">
        /// The search query to be used for ranking.<br/>
        /// Example: What animals can I find near Peru?
        /// </param>
        /// <param name="rankFields">
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </param>
        /// <param name="topN">
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RerankRequest(
            global::Together.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> documents,
            global::Together.AnyOf<global::Together.RerankRequestModel?, string> model,
            string query,
            global::System.Collections.Generic.IList<string>? rankFields,
            bool? returnDocuments,
            int? topN)
        {
            this.Documents = documents;
            this.Model = model;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.RankFields = rankFields;
            this.ReturnDocuments = returnDocuments;
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }
    }
}