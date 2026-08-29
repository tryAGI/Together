#nullable enable

namespace Together
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Get API key identity<br/>
        /// Returns identity information about the authenticated API key. Useful for confirming which project and organization a key is scoped to, and for obtaining the project slug used to compose the `model` value (`&lt;project_slug&gt;/&lt;endpoint_slug&gt;`) in dedicated endpoint inference calls.<br/>
        /// Requires a Bearer API key in the `Authorization` header. Cookie, session, and SLS JWT credentials are not accepted.
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
        /// Get API key identity<br/>
        /// Returns identity information about the authenticated API key. Useful for confirming which project and organization a key is scoped to, and for obtaining the project slug used to compose the `model` value (`&lt;project_slug&gt;/&lt;endpoint_slug&gt;`) in dedicated endpoint inference calls.<br/>
        /// Requires a Bearer API key in the `Authorization` header. Cookie, session, and SLS JWT credentials are not accepted.
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