#nullable enable

namespace Together
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Fetch video metadata<br/>
        /// Fetch video metadata
        /// </summary>
        /// <param name="id">
        /// Identifier of video from create response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VideoJob> RetrieveVideoAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}