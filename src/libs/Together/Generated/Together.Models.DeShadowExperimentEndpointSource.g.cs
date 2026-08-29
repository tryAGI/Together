
#nullable enable

namespace Together
{
    /// <summary>
    /// Endpoint-level source that samples endpoint traffic at the API gateway.
    /// </summary>
    public sealed partial class DeShadowExperimentEndpointSource
    {
        /// <summary>
        /// Sampling strategy applied to endpoint traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeShadowExperimentSamplingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentSampling Sampling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentEndpointSource" /> class.
        /// </summary>
        /// <param name="sampling">
        /// Sampling strategy applied to endpoint traffic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentEndpointSource(
            global::Together.DeShadowExperimentSampling sampling)
        {
            this.Sampling = sampling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentEndpointSource" /> class.
        /// </summary>
        public DeShadowExperimentEndpointSource()
        {
        }

    }
}