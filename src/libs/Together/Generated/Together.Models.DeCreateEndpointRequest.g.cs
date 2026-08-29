
#nullable enable

namespace Together
{
    /// <summary>
    /// Request parameters for creating an endpoint.
    /// </summary>
    public sealed partial class DeCreateEndpointRequest
    {
        /// <summary>
        /// Inference-addressable endpoint name to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeCreateEndpointRequestVisibilityJsonConverter))]
        public global::Together.DeCreateEndpointRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateEndpointRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Inference-addressable endpoint name to create.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateEndpointRequest(
            string name,
            global::Together.DeCreateEndpointRequestVisibility? visibility)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateEndpointRequest" /> class.
        /// </summary>
        public DeCreateEndpointRequest()
        {
        }

    }
}