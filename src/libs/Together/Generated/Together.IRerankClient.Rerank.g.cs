#nullable enable

namespace Together
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Create a rerank request<br/>
        /// Query a reranker model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RerankResponse> RerankAsync(
            global::Together.RerankRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a rerank request<br/>
        /// Query a reranker model
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RerankResponse> RerankAsync(
            global::Together.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> documents,
            global::Together.AnyOf<global::Together.RerankRequestModel?, string> model,
            string query,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            bool? returnDocuments = default,
            int? topN = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}