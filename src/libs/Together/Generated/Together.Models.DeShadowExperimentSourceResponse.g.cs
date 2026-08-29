
#nullable enable

namespace Together
{
    /// <summary>
    /// Endpoint traffic source returned for a shadow experiment.
    /// </summary>
    public sealed partial class DeShadowExperimentSourceResponse
    {
        /// <summary>
        /// Endpoint-level source that samples traffic at the API gateway.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentEndpointSourceResponse Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSourceResponse" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// Endpoint-level source that samples traffic at the API gateway.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentSourceResponse(
            global::Together.DeShadowExperimentEndpointSourceResponse endpoint)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentSourceResponse" /> class.
        /// </summary>
        public DeShadowExperimentSourceResponse()
        {
        }

    }
}