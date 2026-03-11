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
        /// Maximum number of sessions to return (1-100), defaults to 20<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Number of sessions to skip<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSessionsListResponse> ListTrainingSessionsAsync(
            global::Together.RlTrainingSessionStatus? status = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}