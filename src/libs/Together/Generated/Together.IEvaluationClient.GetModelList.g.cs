#nullable enable

namespace Together
{
    public partial interface IEvaluationClient
    {
        /// <summary>
        /// Get model list
        /// </summary>
        /// <param name="modelSource">
        /// Filter models by source<br/>
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// models = client.get(<br/>
        ///     "/evaluation/model-list",<br/>
        ///     cast_to=object,<br/>
        ///     options={"params": {"model_source": "serverless"}},<br/>
        /// )<br/>
        /// print(models)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GetModelListResponse> GetModelListAsync(
            string? modelSource = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get model list
        /// </summary>
        /// <param name="modelSource">
        /// Filter models by source<br/>
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// models = client.get(<br/>
        ///     "/evaluation/model-list",<br/>
        ///     cast_to=object,<br/>
        ///     options={"params": {"model_source": "serverless"}},<br/>
        /// )<br/>
        /// print(models)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.GetModelListResponse>> GetModelListAsResponseAsync(
            string? modelSource = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}