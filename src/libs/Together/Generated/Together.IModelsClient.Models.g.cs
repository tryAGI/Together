#nullable enable

namespace Together
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List all models<br/>
        /// Lists all of Together's open-source models
        /// </summary>
        /// <param name="dedicated">
        /// Filter models to only return dedicated models
        /// </param>
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
        /// models = client.models.list()<br/>
        /// for model in models:<br/>
        ///     print(model.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Together.ModelInfo>> ModelsAsync(
            bool? dedicated = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}