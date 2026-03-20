#nullable enable

namespace Together
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List all models<br/>
        /// Lists all of Together's open-source models
        /// </summary>
        /// <param name="dedicated">
        /// Filter models to only return dedicated models
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Together.ModelInfo>> ModelsAsync(
            bool? dedicated = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}