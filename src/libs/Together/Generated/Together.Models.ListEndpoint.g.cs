
#nullable enable

namespace Together
{
    /// <summary>
    /// Details about an endpoint when listed via the list endpoint
    /// </summary>
    public sealed partial class ListEndpoint
    {
        /// <summary>
        /// The object type, which is always `endpoint`.
        /// </summary>
        /// <default>"endpoint"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "endpoint";

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
        /// Example: allenai/OLMo-7B
        /// </summary>
        /// <example>allenai/OLMo-7B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The model deployed on this endpoint<br/>
        /// Example: allenai/OLMo-7B
        /// </summary>
        /// <example>allenai/OLMo-7B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The type of endpoint<br/>
        /// Example: serverless
        /// </summary>
        /// <example>serverless</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ListEndpointTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ListEndpointType Type { get; set; }

        /// <summary>
        /// The owner of this endpoint<br/>
        /// Example: together
        /// </summary>
        /// <example>together</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// Current state of the endpoint<br/>
        /// Example: STARTED
        /// </summary>
        /// <example>STARTED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ListEndpointStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ListEndpointState State { get; set; }

        /// <summary>
        /// Timestamp when the endpoint was created<br/>
        /// Example: 2024-02-28T21:34:35.444Z
        /// </summary>
        /// <example>2024-02-28T21:34:35.444Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the endpoint<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </param>
        /// <param name="name">
        /// System name for the endpoint<br/>
        /// Example: allenai/OLMo-7B
        /// </param>
        /// <param name="model">
        /// The model deployed on this endpoint<br/>
        /// Example: allenai/OLMo-7B
        /// </param>
        /// <param name="type">
        /// The type of endpoint<br/>
        /// Example: serverless
        /// </param>
        /// <param name="owner">
        /// The owner of this endpoint<br/>
        /// Example: together
        /// </param>
        /// <param name="state">
        /// Current state of the endpoint<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the endpoint was created<br/>
        /// Example: 2024-02-28T21:34:35.444Z
        /// </param>
        /// <param name="object">
        /// The object type, which is always `endpoint`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndpoint(
            string id,
            string name,
            string model,
            global::Together.ListEndpointType type,
            string owner,
            global::Together.ListEndpointState state,
            global::System.DateTime createdAt,
            string @object = "endpoint")
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Type = type;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.State = state;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpoint" /> class.
        /// </summary>
        public ListEndpoint()
        {
        }
    }
}