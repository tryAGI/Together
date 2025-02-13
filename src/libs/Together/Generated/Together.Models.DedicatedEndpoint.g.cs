
#nullable enable

namespace Together
{
    /// <summary>
    /// Details about a dedicated endpoint deployment
    /// </summary>
    public sealed partial class DedicatedEndpoint
    {
        /// <summary>
        /// Configuration for automatic scaling of replicas based on demand.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.Autoscaling Autoscaling { get; set; }

        /// <summary>
        /// Timestamp when the endpoint was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </summary>
        /// <example>My Llama3 70b endpoint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The hardware configuration used for this endpoint<br/>
        /// Example: 1x_nvidia_a100_80gb_sxm
        /// </summary>
        /// <example>1x_nvidia_a100_80gb_sxm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// Unique identifier for the endpoint<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </summary>
        /// <example>endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The model deployed on this endpoint<br/>
        /// Example: meta-llama/Llama-3-8b-chat-hf
        /// </summary>
        /// <example>meta-llama/Llama-3-8b-chat-hf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// System name for the endpoint<br/>
        /// Example: devuser/meta-llama/Llama-3-8b-chat-hf-a32b82a1
        /// </summary>
        /// <example>devuser/meta-llama/Llama-3-8b-chat-hf-a32b82a1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of object<br/>
        /// Example: endpoint
        /// </summary>
        /// <example>endpoint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DedicatedEndpointObjectJsonConverter))]
        public global::Together.DedicatedEndpointObject Object { get; set; }

        /// <summary>
        /// The owner of this endpoint<br/>
        /// Example: devuser
        /// </summary>
        /// <example>devuser</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// Current state of the endpoint<br/>
        /// Example: STARTED
        /// </summary>
        /// <example>STARTED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DedicatedEndpointStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DedicatedEndpointState State { get; set; }

        /// <summary>
        /// The type of endpoint<br/>
        /// Example: dedicated
        /// </summary>
        /// <example>dedicated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DedicatedEndpointTypeJsonConverter))]
        public global::Together.DedicatedEndpointType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedEndpoint" /> class.
        /// </summary>
        /// <param name="autoscaling">
        /// Configuration for automatic scaling of replicas based on demand.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the endpoint was created
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </param>
        /// <param name="hardware">
        /// The hardware configuration used for this endpoint<br/>
        /// Example: 1x_nvidia_a100_80gb_sxm
        /// </param>
        /// <param name="id">
        /// Unique identifier for the endpoint<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </param>
        /// <param name="model">
        /// The model deployed on this endpoint<br/>
        /// Example: meta-llama/Llama-3-8b-chat-hf
        /// </param>
        /// <param name="name">
        /// System name for the endpoint<br/>
        /// Example: devuser/meta-llama/Llama-3-8b-chat-hf-a32b82a1
        /// </param>
        /// <param name="object">
        /// The type of object<br/>
        /// Example: endpoint
        /// </param>
        /// <param name="owner">
        /// The owner of this endpoint<br/>
        /// Example: devuser
        /// </param>
        /// <param name="state">
        /// Current state of the endpoint<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="type">
        /// The type of endpoint<br/>
        /// Example: dedicated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DedicatedEndpoint(
            global::Together.Autoscaling autoscaling,
            global::System.DateTime createdAt,
            string displayName,
            string hardware,
            string id,
            string model,
            string name,
            string owner,
            global::Together.DedicatedEndpointState state,
            global::Together.DedicatedEndpointObject @object,
            global::Together.DedicatedEndpointType type)
        {
            this.Autoscaling = autoscaling ?? throw new global::System.ArgumentNullException(nameof(autoscaling));
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.State = state;
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedEndpoint" /> class.
        /// </summary>
        public DedicatedEndpoint()
        {
        }
    }
}