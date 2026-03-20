#nullable enable

namespace Together
{
    public partial interface IEndpoints2Client
    {

        /// <summary>
        /// List all available availability zones.<br/>
        /// List all available availability zones.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.endpoints.list_avzones()<br/>
        /// print(response.avzones)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ListAvailibilityZonesResponse> AvailabilityZonesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}