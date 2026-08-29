
#nullable enable

namespace Together
{
    /// <summary>
    /// Endpoint-level source returned for a shadow experiment.
    /// </summary>
    public sealed partial class DeShadowExperimentEndpointSourceResponse
    {
        /// <summary>
        /// Resolved sampling strategy applied to endpoint traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeShadowExperimentSamplingResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentSamplingResponse Sampling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentEndpointSourceResponse" /> class.
        /// </summary>
        /// <param name="sampling">
        /// Resolved sampling strategy applied to endpoint traffic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentEndpointSourceResponse(
            global::Together.DeShadowExperimentSamplingResponse sampling)
        {
            this.Sampling = sampling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentEndpointSourceResponse" /> class.
        /// </summary>
        public DeShadowExperimentEndpointSourceResponse()
        {
        }

    }
}