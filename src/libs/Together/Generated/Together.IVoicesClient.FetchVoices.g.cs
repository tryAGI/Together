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

        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.audio.voices.list()<br/>
        /// print(response.data)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ListVoicesResponse> FetchVoicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}