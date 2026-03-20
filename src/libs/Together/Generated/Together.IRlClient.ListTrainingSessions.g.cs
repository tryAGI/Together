#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// List training sessions<br/>
        /// Lists all training sessions.
        /// </summary>
        /// <param name="status">
        /// Status of the training sessions to list<br/>
        /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
        /// </param>
        /// <param name="limit">
        /// Maximum number of sessions to return (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for pagination (ID of the last session from the previous page)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSessionsListResponse> ListTrainingSessionsAsync(
            global::Together.RlTrainingSessionStatus? status = default,
            int? limit = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}