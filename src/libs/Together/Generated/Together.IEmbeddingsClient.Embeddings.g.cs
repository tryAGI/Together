#nullable enable

namespace Together
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Create embedding<br/>
        /// Query an embedding model for a given string of text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EmbeddingsResponse> EmbeddingsAsync(
            global::Together.EmbeddingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create embedding<br/>
        /// Query an embedding model for a given string of text.
        /// </summary>
        /// <param name="input">
        /// Example: Our solar system orbits the Milky Way galaxy at about 515,000 mph
        /// </param>
        /// <param name="model">
        /// The name of the embedding model to use.  [See all of Together AI's embedding models](https://docs.together.ai/docs/serverless-models#embedding-models)<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EmbeddingsResponse> EmbeddingsAsync(
            global::Together.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::Together.AnyOf<global::Together.EmbeddingsRequestModel?, string> model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}