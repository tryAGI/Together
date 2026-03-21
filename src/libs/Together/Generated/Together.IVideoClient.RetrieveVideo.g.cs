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
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.videos.retrieve(video_id)<br/>
        /// print(response.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.VideoJob> RetrieveVideoAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}