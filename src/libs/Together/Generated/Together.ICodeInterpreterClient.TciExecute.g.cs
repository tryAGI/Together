#nullable enable

namespace Together
{
    public partial interface ICodeInterpreterClient
    {
        /// <summary>
        /// Executes the given code snippet and returns the output. Without a session_id, a new session will be created to run the code. If you do pass in a valid session_id, the code will be run in that session. This is useful for running multiple code snippets in the same environment, because dependencies and similar things are persisted<br/>
        /// between calls to the same session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ExecuteResponse> TciExecuteAsync(
            global::Together.ExecuteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Executes the given code snippet and returns the output. Without a session_id, a new session will be created to run the code. If you do pass in a valid session_id, the code will be run in that session. This is useful for running multiple code snippets in the same environment, because dependencies and similar things are persisted<br/>
        /// between calls to the same session.
        /// </summary>
        /// <param name="code">
        /// Code snippet to execute.<br/>
        /// Example: print('Hello, world!')
        /// </param>
        /// <param name="language">
        /// Programming language for the code to execute. Currently only supports Python, but more will be added.<br/>
        /// Default Value: python
        /// </param>
        /// <param name="sessionId">
        /// Identifier of the current session. Used to make follow-up calls. Requests will return an error if the session does not belong to the caller or has expired.<br/>
        /// Example: ses_abcDEF123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ExecuteResponse> TciExecuteAsync(
            string code,
            global::Together.ExecuteRequestLanguage language = global::Together.ExecuteRequestLanguage.Python,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}