
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEndpointRequest
    {
        /// <summary>
        /// Configuration for automatic scaling of replicas based on demand.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.Autoscaling Autoscaling { get; set; }

        /// <summary>
        /// Whether to disable the prompt cache for this endpoint<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_prompt_cache")]
        public bool? DisablePromptCache { get; set; }

        /// <summary>
        /// Whether to disable speculative decoding for this endpoint<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_speculative_decoding")]
        public bool? DisableSpeculativeDecoding { get; set; }

        /// <summary>
        /// A human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </summary>
        /// <example>My Llama3 70b endpoint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The hardware configuration to use for this endpoint<br/>
        /// Example: 1x_nvidia_a100_80gb_sxm
        /// </summary>
        /// <example>1x_nvidia_a100_80gb_sxm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// The number of minutes of inactivity after which the endpoint will be automatically stopped. Set to null, omit or set to 0 to disable automatic timeout.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactive_timeout")]
        public int? InactiveTimeout { get; set; }

        /// <summary>
        /// The model to deploy on this endpoint<br/>
        /// Example: meta-llama/Llama-3-8b-chat-hf
        /// </summary>
        /// <example>meta-llama/Llama-3-8b-chat-hf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The desired state of the endpoint<br/>
        /// Default Value: STARTED<br/>
        /// Example: STARTED
        /// </summary>
        /// <example>STARTED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.CreateEndpointRequestStateJsonConverter))]
        public global::Together.CreateEndpointRequestState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndpointRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEndpointRequest(
            global::Together.Autoscaling autoscaling,
            string hardware,
            string model,
            bool? disablePromptCache,
            bool? disableSpeculativeDecoding,
            string? displayName,
            int? inactiveTimeout,
            global::Together.CreateEndpointRequestState? state)
        {
            this.Autoscaling = autoscaling ?? throw new global::System.ArgumentNullException(nameof(autoscaling));
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.DisablePromptCache = disablePromptCache;
            this.DisableSpeculativeDecoding = disableSpeculativeDecoding;
            this.DisplayName = displayName;
            this.InactiveTimeout = inactiveTimeout;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndpointRequest" /> class.
        /// </summary>
        public CreateEndpointRequest()
        {
        }
    }
}