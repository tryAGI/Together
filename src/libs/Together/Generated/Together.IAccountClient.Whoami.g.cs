#nullable enable

namespace Together
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Identify the caller<br/>
        /// Returns identity information for the authenticated caller. Accepts project API keys and user session JWTs. The response `type` indicates which fields are present.<br/>
        /// For project-scoped credentials, `project.slug` can be used with an endpoint slug as `&lt;project_slug&gt;/&lt;endpoint_slug&gt;` to form the `model` value in dedicated endpoint inference calls.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// print(identity)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.WhoamiResponse> WhoamiAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Identify the caller<br/>
        /// Returns identity information for the authenticated caller. Accepts project API keys and user session JWTs. The response `type` indicates which fields are present.<br/>
        /// For project-scoped credentials, `project.slug` can be used with an endpoint slug as `&lt;project_slug&gt;/&lt;endpoint_slug&gt;` to form the `model` value in dedicated endpoint inference calls.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// print(identity)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.WhoamiResponse>> WhoamiAsResponseAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}