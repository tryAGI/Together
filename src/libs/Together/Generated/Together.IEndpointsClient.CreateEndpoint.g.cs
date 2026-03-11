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
        /// <param name="displayName">
        /// A human-readable name for the endpoint
        /// </param>
        /// <param name="model">
        /// The model to deploy on this endpoint
        /// </param>
        /// <param name="hardware">
        /// The hardware configuration to use for this endpoint
        /// </param>
        /// <param name="autoscaling">
        /// Configuration for automatic scaling of the endpoint
        /// </param>
        /// <param name="disableSpeculativeDecoding">
        /// Whether to disable speculative decoding for this endpoint<br/>
        /// Default Value: false
        /// </param>
        /// <param name="state">
        /// The desired state of the endpoint<br/>
        /// Default Value: STARTED<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="inactiveTimeout">
        /// The number of minutes of inactivity after which the endpoint will be automatically stopped. Set to null, omit or set to 0 to disable automatic timeout.<br/>
        /// Example: 60
        /// </param>
        /// <param name="availabilityZone">
        /// Create the endpoint in a specified availability zone (e.g., us-central-4b)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> CreateEndpointAsync(
            string model,
            string hardware,
            global::Together.Autoscaling autoscaling,
            string? displayName = default,
            bool? disableSpeculativeDecoding = default,
            global::Together.CreateEndpointRequestState? state = default,
            int? inactiveTimeout = default,
            string? availabilityZone = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}