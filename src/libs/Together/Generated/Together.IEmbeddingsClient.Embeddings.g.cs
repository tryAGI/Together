#nullable enable

namespace Together
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Create embedding<br/>
        /// Generate vector embeddings for one or more text inputs. Returns numerical arrays representing semantic meaning, useful for search, classification, and retrieval.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.embeddings.create(<br/>
        ///     model="BAAI/bge-large-en-v1.5",<br/>
        ///     input="New York City",<br/>
        /// )<br/>
        /// print(response.data[0].embedding)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.EmbeddingsResponse> EmbeddingsAsync(

            global::Together.EmbeddingsRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create embedding<br/>
        /// Generate vector embeddings for one or more text inputs. Returns numerical arrays representing semantic meaning, useful for search, classification, and retrieval.
        /// </summary>
        /// <param name="model">
        /// The name of the embedding model to use.  [See all of Together AI's embedding models](https://docs.together.ai/docs/serverless-models#embedding-models)<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </param>
        /// <param name="input">
        /// Example: Our solar system orbits the Milky Way galaxy at about 515,000 mph
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EmbeddingsResponse> EmbeddingsAsync(
            global::Together.AnyOf<global::Together.EmbeddingsRequestModel?, string> model,
            global::Together.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}