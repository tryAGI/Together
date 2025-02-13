
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEndpointRequest
    {
        /// <summary>
        /// Configuration for automatic scaling of replicas based on demand.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        public global::Together.Autoscaling? Autoscaling { get; set; }

        /// <summary>
        /// A human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </summary>
        /// <example>My Llama3 70b endpoint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The desired state of the endpoint<br/>
        /// Example: STARTED
        /// </summary>
        /// <example>STARTED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.UpdateEndpointRequestStateJsonConverter))]
        public global::Together.UpdateEndpointRequestState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequest" /> class.
        /// </summary>
        /// <param name="autoscaling">
        /// Configuration for automatic scaling of replicas based on demand.
        /// </param>
        /// <param name="displayName">
        /// A human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </param>
        /// <param name="state">
        /// The desired state of the endpoint<br/>
        /// Example: STARTED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEndpointRequest(
            global::Together.Autoscaling? autoscaling,
            string? displayName,
            global::Together.UpdateEndpointRequestState? state)
        {
            this.Autoscaling = autoscaling;
            this.DisplayName = displayName;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequest" /> class.
        /// </summary>
        public UpdateEndpointRequest()
        {
        }
    }
}