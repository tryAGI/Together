#nullable enable

namespace Together
{
    public partial interface IHardwareClient
    {
        /// <summary>
        /// List available hardware configurations<br/>
        /// Returns a list of available hardware configurations for deploying models. When a model parameter is provided, it returns only hardware configurations compatible with that model, including their current availability status.
        /// </summary>
        /// <param name="model">
        /// Filter hardware configurations by model compatibility. When provided,<br/>
        /// the response includes availability status for each compatible configuration.<br/>
        /// [See all of Together AI's dedicated models](https://docs.together.ai/docs/dedicated-models)<br/>
        /// Example: deepseek-ai/DeepSeek-R1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.endpoints.list_hardware()<br/>
        /// for hardware in response.data:<br/>
        ///     print(hardware.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ListHardwareResponse> ListHardwareAsync(
            string? model = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}