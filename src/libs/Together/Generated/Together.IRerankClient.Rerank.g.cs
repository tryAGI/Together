#nullable enable

namespace Together
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Create a rerank request<br/>
        /// Rerank a list of documents by relevance to a query. Returns a relevance score and ordering index for each document.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RerankResponse> RerankAsync(

            global::Together.RerankRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a rerank request<br/>
        /// Rerank a list of documents by relevance to a query. Returns a relevance score and ordering index for each document.
        /// </summary>
        /// <param name="model">
        /// The model to be used for the rerank request.  [See all of Together AI's rerank models](https://docs.together.ai/docs/serverless-models#rerank-models)<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </param>
        /// <param name="query">
        /// The search query to be used for ranking.<br/>
        /// Example: What animals can I find near Peru?
        /// </param>
        /// <param name="documents">
        /// List of documents, which can be either strings or objects.<br/>
        /// Example: [{"title":"Llama","text":"The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era."}, {"title":"Panda","text":"The giant panda (Ailuropoda melanoleuca), also known as the panda bear or simply panda, is a bear species endemic to China."}, {"title":"Guanaco","text":"The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations."}, {"title":"Wild Bactrian camel","text":"The wild Bactrian camel (Camelus ferus) is an endangered species of camel endemic to Northwest China and southwestern Mongolia."}]
        /// </param>
        /// <param name="topN">
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </param>
        /// <param name="rankFields">
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RerankResponse> RerankAsync(
            global::Together.AnyOf<global::Together.RerankRequestModel?, string> model,
            string query,
            global::Together.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> documents,
            int? topN = default,
            bool? returnDocuments = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}