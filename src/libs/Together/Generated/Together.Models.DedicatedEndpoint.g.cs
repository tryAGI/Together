
#nullable enable

namespace Together
{
    /// <summary>
    /// Details about a dedicated endpoint deployment
    /// </summary>
    public sealed partial class DedicatedEndpoint
    {
        /// <summary>
        /// The object type, which is always `endpoint`.
        /// </summary>
        /// <default>"endpoint"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; } = "endpoint";

        /// <summary>
        /// Unique identifier for the endpoint<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </summary>
        /// <example>endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// System name for the endpoint<br/>
        /// Example: devuser/meta-llama/Llama-3-8b-chat-hf-a32b82a1
        /// </summary>
        /// <example>devuser/meta-llama/Llama-3-8b-chat-hf-a32b82a1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </summary>
        /// <example>My Llama3 70b endpoint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The model deployed on this endpoint<br/>
        /// Example: meta-llama/Llama-3-8b-chat-hf
        /// </summary>
        /// <example>meta-llama/Llama-3-8b-chat-hf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The hardware configuration used for this endpoint<br/>
        /// Example: 1x_nvidia_a100_80gb_sxm
        /// </summary>
        /// <example>1x_nvidia_a100_80gb_sxm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// The type of endpoint<br/>
        /// Example: dedicated
        /// </summary>
        /// <example>dedicated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DedicatedEndpointTypeJsonConverter))]
        public global::Together.DedicatedEndpointType Type { get; set; }

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
        /// Configuration for automatic scaling of the endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.Autoscaling Autoscaling { get; set; }

        /// <summary>
        /// Timestamp when the endpoint was created<br/>
        /// Example: 2025-02-04T10:43:55.405Z
        /// </summary>
        /// <example>2025-02-04T10:43:55.405Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedEndpoint" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `endpoint`.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the endpoint<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </param>
        /// <param name="name">
        /// System name for the endpoint<br/>
        /// Example: devuser/meta-llama/Llama-3-8b-chat-hf-a32b82a1
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </param>
        /// <param name="model">
        /// The model deployed on this endpoint<br/>
        /// Example: meta-llama/Llama-3-8b-chat-hf
        /// </param>
        /// <param name="hardware">
        /// The hardware configuration used for this endpoint<br/>
        /// Example: 1x_nvidia_a100_80gb_sxm
        /// </param>
        /// <param name="type">
        /// The type of endpoint<br/>
        /// Example: dedicated
        /// </param>
        /// <param name="owner">
        /// The owner of this endpoint<br/>
        /// Example: devuser
        /// </param>
        /// <param name="state">
        /// Current state of the endpoint<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="autoscaling">
        /// Configuration for automatic scaling of the endpoint
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the endpoint was created<br/>
        /// Example: 2025-02-04T10:43:55.405Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DedicatedEndpoint(
            string @object,
            string id,
            string name,
            string displayName,
            string model,
            string hardware,
            string owner,
            global::Together.DedicatedEndpointState state,
            global::Together.Autoscaling autoscaling,
            global::System.DateTime createdAt,
            global::Together.DedicatedEndpointType type)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.State = state;
            this.Autoscaling = autoscaling ?? throw new global::System.ArgumentNullException(nameof(autoscaling));
            this.CreatedAt = createdAt;
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