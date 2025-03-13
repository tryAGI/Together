#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Create a dedicated endpoint, it will start automatically<br/>
        /// Creates a new dedicated endpoint for serving models. The endpoint will automatically start after creation. You can deploy any supported model on hardware configurations that meet the model's requirements.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> CreateEndpointAsync(
            global::Together.CreateEndpointRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a dedicated endpoint, it will start automatically<br/>
        /// Creates a new dedicated endpoint for serving models. The endpoint will automatically start after creation. You can deploy any supported model on hardware configurations that meet the model's requirements.
        /// </summary>
        /// <param name="autoscaling">
        /// Configuration for automatic scaling of replicas based on demand.
        /// </param>
        /// <param name="disablePromptCache">
        /// Whether to disable the prompt cache for this endpoint<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableSpeculativeDecoding">
        /// Whether to disable speculative decoding for this endpoint<br/>
        /// Default Value: false
        /// </param>
        /// <param name="displayName">
        /// A human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </param>
        /// <param name="hardware">
        /// The hardware configuration to use for this endpoint<br/>
        /// Example: 1x_nvidia_a100_80gb_sxm
        /// </param>
        /// <param name="inactiveTimeout">
        /// The number of minutes of inactivity after which the endpoint will be automatically stopped. Set to null, omit or set to 0 to disable automatic timeout.<br/>
        /// Example: 60
        /// </param>
        /// <param name="model">
        /// The model to deploy on this endpoint<br/>
        /// Example: meta-llama/Llama-3-8b-chat-hf
        /// </param>
        /// <param name="state">
        /// The desired state of the endpoint<br/>
        /// Default Value: STARTED<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> CreateEndpointAsync(
            global::Together.Autoscaling autoscaling,
            string hardware,
            string model,
            bool? disablePromptCache = default,
            bool? disableSpeculativeDecoding = default,
            string? displayName = default,
            int? inactiveTimeout = default,
            global::Together.CreateEndpointRequestState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}