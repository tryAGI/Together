#nullable enable

namespace Together
{
    public partial interface ICodeInterpreterClient
    {
        /// <summary>
        /// Execute code<br/>
        /// Executes the given code snippet and returns the output. Without a session_id, a new session is created to run the code. If you pass a valid session_id, the code runs in that session. This is useful for running multiple code snippets in the same environment, because dependencies and similar things are persisted<br/>
        /// between calls to the same session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.code_interpreter.execute(<br/>
        ///     code="print('Hello world!')",<br/>
        ///     language="python",<br/>
        /// )<br/>
        /// print(response.data.outputs[0].data);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ExecuteResponse> TciExecuteAsync(

            global::Together.ExecuteRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute code<br/>
        /// Executes the given code snippet and returns the output. Without a session_id, a new session is created to run the code. If you pass a valid session_id, the code runs in that session. This is useful for running multiple code snippets in the same environment, because dependencies and similar things are persisted<br/>
        /// between calls to the same session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.code_interpreter.execute(<br/>
        ///     code="print('Hello world!')",<br/>
        ///     language="python",<br/>
        /// )<br/>
        /// print(response.data.outputs[0].data);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ExecuteResponse>> TciExecuteAsResponseAsync(

            global::Together.ExecuteRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute code<br/>
        /// Executes the given code snippet and returns the output. Without a session_id, a new session is created to run the code. If you pass a valid session_id, the code runs in that session. This is useful for running multiple code snippets in the same environment, because dependencies and similar things are persisted<br/>
        /// between calls to the same session.
        /// </summary>
        /// <param name="code">
        /// Code snippet to execute.<br/>
        /// Example: print('Hello, world!')
        /// </param>
        /// <param name="files">
        /// Files to upload to the session. If present, files are uploaded before executing the given code.
        /// </param>
        /// <param name="language">
        /// Programming language for the code to execute. Currently only supports Python.<br/>
        /// Default Value: python
        /// </param>
        /// <param name="sessionId">
        /// Identifier of the current session. Used to make follow-up calls. Returns an error if the session does not belong to the caller or has expired.<br/>
        /// Example: ses_abcDEF123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ExecuteResponse> TciExecuteAsync(
            string code,
            global::System.Collections.Generic.IList<global::Together.ExecuteRequestFile>? files = default,
            global::Together.ExecuteRequestLanguage language = global::Together.ExecuteRequestLanguage.Python,
            string? sessionId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}