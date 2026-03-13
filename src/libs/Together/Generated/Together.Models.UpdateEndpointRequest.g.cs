
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEndpointRequest
    {
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
        /// New autoscaling configuration for the endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        public global::Together.Autoscaling? Autoscaling { get; set; }

        /// <summary>
        /// The number of minutes of inactivity after which the endpoint will be automatically stopped. Set to 0 to disable automatic timeout.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactive_timeout")]
        public int? InactiveTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// A human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </param>
        /// <param name="state">
        /// The desired state of the endpoint<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="autoscaling">
        /// New autoscaling configuration for the endpoint
        /// </param>
        /// <param name="inactiveTimeout">
        /// The number of minutes of inactivity after which the endpoint will be automatically stopped. Set to 0 to disable automatic timeout.<br/>
        /// Example: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEndpointRequest(
            string? displayName,
            global::Together.UpdateEndpointRequestState? state,
            global::Together.Autoscaling? autoscaling,
            int? inactiveTimeout)
        {
            this.DisplayName = displayName;
            this.State = state;
            this.Autoscaling = autoscaling;
            this.InactiveTimeout = inactiveTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequest" /> class.
        /// </summary>
        public UpdateEndpointRequest()
        {
        }
    }
}