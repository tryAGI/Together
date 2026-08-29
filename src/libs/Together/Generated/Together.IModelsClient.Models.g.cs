#nullable enable

namespace Together
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List all models<br/>
        /// Lists all of Together's open-source models and metadata including pricing, chat template, and context.
        /// </summary>
        /// <param name="dedicated">
        /// Filter models to only return dedicated models
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
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
        /// <summary>
        /// List all models<br/>
        /// Lists all of Together's open-source models and metadata including pricing, chat template, and context.
        /// </summary>
        /// <param name="dedicated">
        /// Filter models to only return dedicated models
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// models = client.models.list()<br/>
        /// for model in models:<br/>
        ///     print(model.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Together.ModelInfo>>> ModelsAsResponseAsync(
            bool? dedicated = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}