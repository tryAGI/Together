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
        global::System.Threading.Tasks.Task<global::Together.Response42> GetFineTunesModelsSupportedAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}