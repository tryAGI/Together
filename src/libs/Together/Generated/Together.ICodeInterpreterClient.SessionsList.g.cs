#nullable enable

namespace Together
{
    public partial interface ICodeInterpreterClient
    {
        /// <summary>
        /// Lists all your currently active sessions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.SessionListResponse> SessionsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}