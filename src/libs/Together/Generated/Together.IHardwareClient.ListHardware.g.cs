#nullable enable

namespace Together
{
    public partial interface IHardwareClient
    {
        /// <summary>
        /// List available hardware configurations<br/>
        /// Returns a list of available hardware configurations for deploying models. When a model parameter is provided, it returns only hardware configurations compatible  with that model, including their current availability status.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListHardwareResponse> ListHardwareAsync(
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}