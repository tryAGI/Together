#nullable enable

namespace Together
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Fetch available voices for each model<br/>
        /// Fetch available voices for each model
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListVoicesResponse> FetchVoicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}