#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List supported models<br/>
        /// List models supported for fine-tuning.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// curl "https://api.together.xyz/v1/fine-tunes/models/supported" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GetFineTunesModelsSupportedResponse> GetFineTunesModelsSupportedAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}